#nullable enable
using System;
using System.IO;
using System.Reflection;
using System.Linq;
using UnityEditor;
using UnityEngine;
using System.Text;
using OUCC.FluentParticleSystem.Generator;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace OUCC.FluentParticleSystem.SourceGenerator
{
    public static class ModuleGenerator
    {
        private const string INFO_PATH = "Assets/Editor/SourceGenerator/module-info.json";

        #region generate scripts
        internal static void WriteExtensionFile(string filePath, PSModuleInfo module)
        {
            using var sw = new StreamWriter(filePath, false, Encoding.UTF8);

            sw.Write(
$@"using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{{
    public static class {module.TypeName}Extension
    {{
#if ({GetConditionString(module.AvailableVersions)})
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem Edit{module.PropertyName.c2p()}(this ParticleSystem particleSystem, Action<{module.TypeName}> moduleEditor)
        {{
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.{module.PropertyName});
            return particleSystem;
        }}
".Replace("\r\n", "\n"));

            foreach (var property in module.Properties)
            {
                sw.Write($@"
        #region {property.Name.c2p()}
#if ({GetConditionString(property.AvailableVersions)})
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem Set{module.PropertyName.c2p()}{property.Name.c2p()}(this ParticleSystem particleSystem, {property.Type} {property.Name.p2c()})
        {{
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.{module.PropertyName};
            module.{property.Name} = {property.Name.p2c()};
            return particleSystem;
        }}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem Set{module.PropertyName.c2p()}{property.Name.c2p()}(this ParticleSystem particleSystem, Func<{property.Type}, {property.Type}> {property.Name.p2c()}Changer)
        {{
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.{module.PropertyName};
            module.{property.Name} = {property.Name.p2c()}Changer(module.{property.Name});
            return particleSystem;
        }}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {module.TypeName} Set{property.Name.c2p()}(this {module.TypeName} module, {property.Type} {property.Name.p2c()})
        {{
            module.{property.Name} = {property.Name.p2c()};
            return module;
        }}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {module.TypeName} Set{property.Name.c2p()}(this {module.TypeName} module, Func<{property.Type}, {property.Type}> {property.Name.p2c()}Changer)
        {{
            module.{property.Name} = {property.Name.p2c()}Changer(module.{property.Name});
            return module;
        }}
#endif
        #endregion
".Replace("\r\n", "\n"));
            }

            sw.Write(
$@"#endif
    }}
}}
".Replace("\r\n", "\n"));
            sw.Flush();
        }

        /// <summary>
        /// Tools/Generate Scripts からコードを自動生成します。
        /// </summary>
        [MenuItem("Tools/Generate Scripts")]
        public static void GenerateWithReflection()
        {
            var modules = LoadModules(INFO_PATH);
            foreach (var module in modules)
            {
                var filePath = $"Packages/FluentParticleSystem/Runtime/{module.TypeName}Extension.cs";
                WriteExtensionFile(filePath, module);
            }
            AssetDatabase.Refresh();
        }

        public static string GetConditionString(string[] versions) => string.Join(" || ", versions.Select(v => $"UNITY_{v.Replace('.', '_')}"));
        #endregion

        #region generate json
        /// <summary>
        /// リフレクションから必要な情報を生成します
        /// </summary>
        [MenuItem("Tools/Generate JSON")]
        public static void GenerateJsonWithReflection()
        {
            var currentVersion = Application.unityVersion;
            currentVersion = currentVersion[..currentVersion.LastIndexOf('.')];
            var modules = LoadModules(INFO_PATH);

            var currentModules = typeof(ParticleSystem)
                    .GetProperties()
                    .Where(m => m.PropertyType.Name.EndsWith("Module"))
                    .OrderBy(m => m.PropertyType.Name)
                    .Select(m => new PSModuleInfo
                    {
                        TypeName = m.PropertyType.Name,
                        PropertyName = m.Name,
                        AvailableVersions = new string[] { currentVersion },
                        Properties = m.PropertyType
                            .GetProperties()
                            .Where(p => p.GetCustomAttribute<ObsoleteAttribute>() is null && p.CanWrite)
                            .OrderBy(p => p.Name)
                            .Select(p => new ModuleProperty
                            {
                                Name = p.Name,
                                Type = GetSimpleTypeName(p.PropertyType.FullName),
                                AvailableVersions = new string[] { currentVersion }
                            }).ToArray()
                    });

            modules = modules.Concat(currentModules)
                .GroupBy(m => m.PropertyName)
                .Select(g =>
                {
                    var m = g.FirstOrDefault()!;
                    m.AvailableVersions = g.SelectMany(mi => mi.AvailableVersions)
                                           .Distinct()
                                           .ToArray();
                    m.Properties = g.SelectMany(p => p.Properties)
                                    .GroupBy(p => p.Name)
                                    .Select(gp =>
                                    {
                                        var p = gp.FirstOrDefault()!;
                                        p.AvailableVersions = g.SelectMany(mp => mp.AvailableVersions)
                                                               .Distinct()
                                                               .ToArray();
                                        return p;
                                    }).ToArray();
                    return m;
                }).ToList();

            var json = JsonConvert.SerializeObject(modules, Formatting.Indented).Replace("\r\n", "\n");
            File.WriteAllText(INFO_PATH, json, Encoding.UTF8);
            Debug.Log("Generating module-info.json Completed");
        }

        internal static List<PSModuleInfo> LoadModules(string path)
        {
            if (!File.Exists(path))
                return new();

            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<List<PSModuleInfo>>(json) ?? new();
        }

        private static string GetSimpleTypeName(string typeName) => typeName switch
        {
            "System.Int32" => "int",
            "System.Single" => "float",
            "System.Boolean" => "bool",
            var n => n.StartsWith("UnityEngine.ParticleSystem+")
                ? n.Split('+').LastOrDefault()
                : n.Split('.').Length == 2 && n.StartsWith("UnityEngine.")
                ? n.Replace("UnityEngine.", "")
                : n
        };
        #endregion
    }
}
