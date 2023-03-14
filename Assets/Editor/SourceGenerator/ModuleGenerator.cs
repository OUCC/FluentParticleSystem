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
using System.Text.RegularExpressions;

namespace OUCC.FluentParticleSystem.SourceGenerator
{
    public static class ModuleGenerator
    {
        private const string INFO_PATH = "Assets/Editor/SourceGenerator/module-info.json";

        #region generate scripts
        internal static void WriteExtensionFile(string filePath, PSModuleInfo module)
        {
            var builder = new StringWriter();
            var isSameAsPrevious = module.Properties.Any() && module.Properties.First().ReleaseVersion == module.ReleaseVersion;

            builder.Write(
$@"using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{{
    public static class {module.Type}Extension
    {{
#if UNITY_{module.ReleaseVersion.Replace('.', '_')}_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem Edit{module.PropertyName.c2p()}(this ParticleSystem particleSystem, Action<{module.Type}> moduleEditor)
        {{
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.{module.PropertyName});
            return particleSystem;
        }}
{(isSameAsPrevious ? "" : "#endif\n")}");

            for (var i = 0; i < module.Properties.Length; i++)
            {
                var property = module.Properties[i];
                var isSameAsNext = i + 1 != module.Properties.Length && module.Properties[i + 1].ReleaseVersion == property.ReleaseVersion;
                var obsolete = property.ObsoleteData is null ? "" :
@$"
#if UNITY_{property.ObsoleteVersion.Replace('.', '_')}_OR_NEWER
        [Obsolete(""{property.ObsoleteData.Message}"", {property.ObsoleteData.IsError.ToString().ToLower()})]
#endif";

                builder.Write($@"{(isSameAsPrevious ? "" : $"\n#if UNITY_{property.ReleaseVersion.Replace('.', '_')}_OR_NEWER")}
        #region {property.PropertyName.c2p()}{obsolete}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem Set{module.PropertyName.c2p()}{property.PropertyName.c2p()}(this ParticleSystem particleSystem, {property.Type} {property.PropertyName.p2c()})
        {{
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.{module.PropertyName};
            module.{property.PropertyName} = {property.PropertyName.p2c()};
            return particleSystem;
        }}
{obsolete}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem Set{module.PropertyName.c2p()}{property.PropertyName.c2p()}(this ParticleSystem particleSystem, Func<{property.Type}, {property.Type}> {property.PropertyName.p2c()}Changer)
        {{
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.{module.PropertyName};
            module.{property.PropertyName} = {property.PropertyName.p2c()}Changer(module.{property.PropertyName});
            return particleSystem;
        }}
{obsolete}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {module.Type} Set{property.PropertyName.c2p()}(this {module.Type} module, {property.Type} {property.PropertyName.p2c()})
        {{
            module.{property.PropertyName} = {property.PropertyName.p2c()};
            return module;
        }}
{obsolete}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {module.Type} Set{property.PropertyName.c2p()}(this {module.Type} module, Func<{property.Type}, {property.Type}> {property.PropertyName.p2c()}Changer)
        {{
            module.{property.PropertyName} = {property.PropertyName.p2c()}Changer(module.{property.PropertyName});
            return module;
        }}
        #endregion
{(isSameAsNext ? "" : "#endif\n")}");
                isSameAsPrevious = isSameAsNext;
            }

            builder.Write(
$@"    }}
}}
");

            File.WriteAllText(filePath, builder.ToString().Replace("\r\n", "\n"));
        }

        /// <summary>
        /// Tools/Generate Scripts からコードを自動生成します。
        /// </summary>
        [MenuItem("Tools/Generate Scripts")]
        public static void GenerateWithReflection()
        {
            var modules = LoadModules(INFO_PATH)
                .Where(m => m.Enabled)
                .Select(m =>
                {
                    m.Properties = m.Properties.Where(p => p.Enabled).ToArray();
                    return m;
                });
            foreach (var module in modules)
            {
                var filePath = $"Packages/FluentParticleSystem/Runtime/{module.Type}Extension.cs";
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
            var currentVersion = Regex.Match(Application.unityVersion, @"[0-9]*\.[0-9]*").Value;
            var currentModules = typeof(ParticleSystem)
                    .GetProperties()
                    .Where(m => m.PropertyType.Name.EndsWith("Module"))
                    .Select(m =>
                    {
                        var mobsolete = m.GetCustomAttribute<ObsoleteAttribute>();
                        return new
                        {
                            Type = m.PropertyType.Name,
                            PropertyName = m.Name,
                            ReleaseVersion = currentVersion,
                            ObsoleteVersion = mobsolete is null ? string.Empty : currentVersion,
                            ObsoleteData = mobsolete is null ? null : new ObsoleteData(mobsolete),
                            Properties = m.PropertyType
                                .GetProperties()
                                .Where(p => p.CanWrite)
                                .Select(p =>
                                {
                                    var pobsolete = p.GetCustomAttribute<ObsoleteAttribute>();
                                    return new ModuleProperty
                                    {
                                        Type = GetSimpleTypeName(p.PropertyType.FullName),
                                        PropertyName = p.Name,
                                        ReleaseVersion = currentVersion,
                                        ObsoleteVersion = pobsolete is null ? string.Empty : currentVersion,
                                        ObsoleteData = pobsolete is null ? null : new ObsoleteData(pobsolete),
                                    };
                                }).ToDictionary(p => p.PropertyName),
                        };
                    }).ToDictionary(m => m.Type);

            var modules = LoadModules(INFO_PATH);
            modules = modules.Select(m =>
                    {
                        if (!currentModules.TryGetValue(m.Type, out var cm))
                            return m;
                        currentModules.Remove(m.Type);

                        if (m.ReleaseVersion.CompareTo(cm.ReleaseVersion) > 0)
                            m.ReleaseVersion = cm.ReleaseVersion;

                        m.ObsoleteVersion
                                = m.ObsoleteVersion == string.Empty
                                    ? cm.ObsoleteVersion
                                : cm.ObsoleteVersion == string.Empty
                                    ? m.ObsoleteVersion
                                : m.ObsoleteVersion.CompareTo(cm.ObsoleteVersion) < 0
                                    ? m.ObsoleteVersion
                                    : cm.ObsoleteVersion;
                        m.ObsoleteData
                                = m.ObsoleteVersion == string.Empty
                                    ? cm.ObsoleteData
                                : cm.ObsoleteVersion == string.Empty
                                    ? m.ObsoleteData
                                : m.ObsoleteVersion.CompareTo(cm.ObsoleteVersion) < 0
                                    ? m.ObsoleteData
                                    : cm.ObsoleteData;

                        m.Properties = m.Properties.Select(p =>
                        {
                            if (!cm.Properties.TryGetValue(p.PropertyName, out var cp))
                                return p;
                            cm.Properties.Remove(p.PropertyName);

                            if (p.ReleaseVersion.CompareTo(cp.ReleaseVersion) > 0)
                                p.ReleaseVersion = cp.ReleaseVersion;

                            p.ObsoleteVersion
                                    = p.ObsoleteVersion == string.Empty
                                        ? cp.ObsoleteVersion
                                    : cp.ObsoleteVersion == string.Empty
                                        ? p.ObsoleteVersion
                                    : p.ObsoleteVersion.CompareTo(cp.ObsoleteVersion) < 0
                                        ? p.ObsoleteVersion
                                        : cp.ObsoleteVersion;
                            p.ObsoleteData
                                    = p.ObsoleteVersion == string.Empty
                                        ? cp.ObsoleteData
                                    : cp.ObsoleteVersion == string.Empty
                                        ? p.ObsoleteData
                                    : p.ObsoleteVersion.CompareTo(cp.ObsoleteVersion) < 0
                                        ? p.ObsoleteData
                                        : cp.ObsoleteData;
                            return p;
                        }).Concat(cm.Properties.Select(p => p.Value))
                        .Distinct(EqualityCompareSelecter.Create<ModuleProperty>(m => m.PropertyName))
                        .OrderBy(m => m.PropertyName)
                        .ToArray();
                        return m;
                    }).Concat(currentModules
                        .Select(m => new PSModuleInfo
                        {
                            Type = m.Value.Type,
                            PropertyName = m.Value.PropertyName,
                            ReleaseVersion = m.Value.ReleaseVersion,
                            ObsoleteVersion = m.Value.ObsoleteVersion,
                            Properties = m.Value.Properties.Select(p => p.Value).ToArray(),
                        }))
                    .Distinct(EqualityCompareSelecter.Create<PSModuleInfo>(m => m.Type))
                    .OrderBy(m => m.Type)
                    .ToArray();

            var json = JsonConvert.SerializeObject(modules, Formatting.Indented).Replace("\r\n", "\n");
            File.WriteAllText(INFO_PATH, json, Encoding.UTF8);
            AssetDatabase.Refresh();
            Debug.Log("Generating module-info.json Completed");
        }

        internal static PSModuleInfo[] LoadModules(string path)
        {
            if (!File.Exists(path))
                return new PSModuleInfo[0];

            var json = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<PSModuleInfo[]>(json) ?? new PSModuleInfo[0];
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
