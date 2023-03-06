#nullable enable

namespace OUCC.FluentParticleSystem.Generator
{
    internal class PSModuleInfo
    {
        public PSModuleInfo()
        {
            TypeName = string.Empty;
            PropertyName = string.Empty;
            AvailableVersions = new string[0];
            Properties = new ModuleProperty[0];
        }

        /// <summary>
        /// モジュールの型名
        /// </summary>
        public string TypeName { get; set; }

        /// <summary>
        /// ParticleSystemでのプロパティ名
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// 利用可能なバージョン
        /// </summary>
        public string[] AvailableVersions { get; set; }

        /// <summary>
        /// プロパティ
        /// </summary>
        public ModuleProperty[] Properties { get; set; }
    }

    internal class ModuleProperty
    {
        /// <summary>
        /// プロパティの名前
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 型名
        /// </summary>
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 利用可能なバージョン
        /// </summary>
        public string[] AvailableVersions { get; set; } = new string[0];
    }
}
