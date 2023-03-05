using System;
using System.IO;
using System.Reflection;
using System.Linq;
using UnityEditor;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem.SourceGenerator
{
    public static class ModuleGenerator
    {
        public static void WriteExtensionFile(string filePath, PropertyInfo module)
        {
            var moduleType = module.PropertyType.Name;
            var moduleName = module.Name;
            using var sw = new StreamWriter(filePath, false);

                sw.Write(
$@"using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.ParticleSystem;


namespace OUCC.FluentParticleSystem
{{
    public static class {moduleType}Extension
    {{
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem Edit{moduleName.c2p()}(this ParticleSystem particleSystem, Action<{moduleType}> moduleEditor)
        {{
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.{moduleName});
            return particleSystem;
        }}
"               );
                foreach (var property in module.PropertyType.GetProperties().OrderBy(p => p.Name))
                {
                    if (property.GetCustomAttribute<ObsoleteAttribute>() != null)
                    {
                        continue;
                    }

                    if (!property.CanWrite)
                    {
                        continue;
                    }

                    string propertyType;

                    if (property.PropertyType == typeof(float))
                    {
                        propertyType = "float";
                    }
                    else if (property.PropertyType == typeof(bool))
                    {
                        propertyType = "bool";
                    }
                    else
                    {
                        propertyType = property.PropertyType.Name;
                    }

                    var propertyName = property.Name;

                    sw.Write($@"
        #region {propertyName.c2p()}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem Set{moduleName.c2p()}{propertyName.c2p()}(this ParticleSystem particleSystem, {propertyType} {propertyName.p2c()})
        {{
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.{moduleName};
            module.{propertyName} = {propertyName.p2c()};
            return particleSystem;
        }}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem Set{moduleName.c2p()}{propertyName.c2p()}(this ParticleSystem particleSystem, Func<{propertyType}, {propertyType}> {propertyName.p2c()}Changer)
        {{
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.{moduleName};
            module.{propertyName} = {propertyName.p2c()}Changer(module.{propertyName});
            return particleSystem;
        }}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {moduleType} Set{propertyName.c2p()}(this {moduleType} module, {propertyType} {propertyName.p2c()})
        {{
            module.{propertyName} = {propertyName.p2c()};
            return module;
        }}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static {moduleType} Set{propertyName.c2p()}(this {moduleType} module, Func<{propertyType}, {propertyType}> {propertyName.p2c()}Changer)
        {{
            module.{propertyName} = {propertyName.p2c()}Changer(module.{propertyName});
            return module;
        }}
        #endregion
"                   );
                }

                sw.Write($@"
    }}
}}
"               );
                sw.Flush();
            }


        /// <summary>
        /// Tools/Generate Scripts からコードを自動生成します。
        /// </summary>
        [MenuItem("Tools/Generate Scripts")]
        public static void GenerateWithReflection()
        {
            var modules = typeof(ParticleSystem).GetProperties();
            foreach (var module in modules.OrderBy(m => m.Name))
            {
                if (!module.PropertyType.Name.Contains("Module"))
                {
                    continue;
                }

                var filePath = $"Packages/FluentParticleSystem/Runtime/{module.PropertyType.Name}Extension.cs";
                WriteExtensionFile(filePath, module);
            }
            AssetDatabase.Refresh();

        }
    }
}
