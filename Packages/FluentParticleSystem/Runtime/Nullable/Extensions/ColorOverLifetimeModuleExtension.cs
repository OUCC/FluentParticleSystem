#nullable enable
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class ColorOverLifetimeModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.colorOverLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditColorOverLifetime(this ParticleSystem particleSystem, Action<ColorOverLifetimeModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.colorOverLifetime);
            return particleSystem;
        }

        #region Color
        /// <summary>
        /// Assign a value to <see cref="ColorOverLifetimeModule.color"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorOverLifetimeColor(this ParticleSystem particleSystem, MinMaxGradient color)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.colorOverLifetime;
            module.color = color;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ColorOverLifetimeModule.color"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorOverLifetimeColor(this ParticleSystem particleSystem, Func<MinMaxGradient, MinMaxGradient> colorChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(colorChanger != null, "colorChanger cannot be null");
            var module = particleSystem.colorOverLifetime;
            module.color = colorChanger(module.color);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ColorOverLifetimeModule.color"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorOverLifetimeModule SetColor(this ColorOverLifetimeModule module, MinMaxGradient color)
        {
            module.color = color;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ColorOverLifetimeModule.color"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorOverLifetimeModule SetColor(this ColorOverLifetimeModule module, Func<MinMaxGradient, MinMaxGradient> colorChanger)
        {
            Debug.Assert(colorChanger != null, "colorChanger cannot be null");
            module.color = colorChanger(module.color);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="ColorOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorOverLifetimeEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.colorOverLifetime;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ColorOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorOverLifetimeEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.colorOverLifetime;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ColorOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorOverLifetimeModule SetEnabled(this ColorOverLifetimeModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ColorOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorOverLifetimeModule SetEnabled(this ColorOverLifetimeModule module, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion
#endif
    }
}
