using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class CustomDataModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.customData"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditCustomData(this ParticleSystem particleSystem, Action<CustomDataModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.customData);
            return particleSystem;
        }

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="CustomDataModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCustomDataEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.customData;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CustomDataModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCustomDataEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.customData;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CustomDataModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CustomDataModule SetEnabled(this CustomDataModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CustomDataModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CustomDataModule SetEnabled(this CustomDataModule module, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion
#endif
    }
}
