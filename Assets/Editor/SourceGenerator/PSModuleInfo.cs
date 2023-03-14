using System;

namespace OUCC.FluentParticleSystem.Generator
{
    internal class PSModuleInfo
    {
        /// <summary>
        /// 有効/無効
        /// </summary>
        public bool Enabled = true;

        /// <summary>
        /// モジュールの型名
        /// </summary>
        public string Type = string.Empty;

        /// <summary>
        /// ParticleSystemでのプロパティ名
        /// </summary>
        public string PropertyName = string.Empty;

        /// <summary>
        /// 利用可能な最初のバージョン
        /// </summary>
        public string ReleaseVersion = string.Empty;

        /// <summary>
        /// 利用可能な最後のバージョン
        /// 空文字のときはリリースされてから非推奨になっていない
        /// 手動で編集してください
        /// </summary>
        public string ObsoleteVersion = string.Empty;

        public ObsoleteData ObsoleteData = null;

        /// <summary>
        /// プロパティ
        /// </summary>
        public ModuleProperty[] Properties = new ModuleProperty[0];
    }

    internal class ModuleProperty
    {
        /// <summary>
        /// 有効/無効
        /// </summary>
        public bool Enabled = true;

        /// <summary>
        /// プロパティの名前
        /// </summary>
        public string PropertyName = string.Empty;

        /// <summary>
        /// 型名
        /// </summary>
        public string Type = string.Empty;

        /// <summary>
        /// 利用可能な最初のバージョン
        /// </summary>
        public string ReleaseVersion = string.Empty;

        /// <summary>
        /// 非推奨になったバージョン
        /// </summary>
        public string ObsoleteVersion = string.Empty;

        public ObsoleteData ObsoleteData = null;
    }

    public class ObsoleteData
    {
        public ObsoleteData() { }
        public ObsoleteData(ObsoleteAttribute attribute) {
            IsError = attribute.IsError;
            Message = attribute.Message;
        }

        public bool IsError = false;
        public string Message = string.Empty;
    }
}
