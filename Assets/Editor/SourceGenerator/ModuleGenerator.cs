using System.IO;
using UnityEditor;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem.SourceGenerator
{
    public static class ModuleGenerator
    {
        private const string FLOAT = "float";
        private const string BOOL = "bool";

        [MenuItem("Tools/Generate Scripts")]
        public static void Generate() {
            var parameters = new (string moduleName, string moduleParameter, (string methodName, string type, string parameterName)[])[]{
                (nameof(MainModule), nameof(ParticleSystem.main), new (string, string, string)[]{
                    ("Duration", FLOAT, nameof(MainModule.duration)),
                    ("Looping", BOOL, nameof(MainModule.loop)),
                    ("Prewarm", BOOL, nameof(MainModule.prewarm)),

                }),
            };

            foreach (var parameter in parameters) {
                var filePath = $"Packages/FluentParticleSystem/Runtime/{parameter.moduleName}Extension.cs";
                using var sw = new StreamWriter(filePath, false);

                sw.Write($@"using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace OUCC.FluentParticleSystem
{{
    public static class {parameter.moduleName}Extension
    {{");
                foreach (var (methodName, type, parameterName) in parameter.Item3) {
                    sw.Write($@"
        #region {methodName}
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem Set{parameter.moduleParameter.c2p()}{methodName}(this ParticleSystem particleSystem, {type} {methodName.p2c()}) {{
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.{parameter.moduleParameter};
            module.{parameterName} = {methodName.p2c()};
            return particleSystem;
        }}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem Set{parameter.moduleParameter.c2p()}{methodName}(this ParticleSystem particleSystem, Func<{type}, {type}> {methodName.p2c()}Changer) {{
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.{parameter.moduleParameter};
            module.{parameterName} = {methodName.p2c()}Changer(module.{parameterName});
            return particleSystem;
        }}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem.{parameter.moduleName} Set{methodName}(this ParticleSystem.{parameter.moduleName} module, {type} {methodName.p2c()}) {{
            module.{parameterName} = {methodName.p2c()};    
            return module;
        }}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem.{parameter.moduleName} Set{methodName}(this ParticleSystem.{parameter.moduleName} module, Func<{type}, {type}> {methodName.p2c()}Changer) {{
            module.{parameterName} = {methodName.p2c()}Changer(module.{parameterName});
            return module;
        }}
        #endregion
");
                }
                sw.Write($@"    }}
}}
");
                sw.Flush();
            }
            AssetDatabase.Refresh();
        }
    }
}
