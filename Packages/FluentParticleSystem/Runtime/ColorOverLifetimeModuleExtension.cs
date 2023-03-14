using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class ColorOverLifetimeModuleExtension
    {
#if UNITY_2021_3_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditColorOverLifetime(this ParticleSystem particleSystem, Action<ColorOverLifetimeModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.colorOverLifetime);
            return particleSystem;
        }

        #region Color
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorOverLifetimeColor(this ParticleSystem particleSystem, MinMaxGradient color)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.colorOverLifetime;
            module.color = color;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorOverLifetimeColor(this ParticleSystem particleSystem, Func<MinMaxGradient, MinMaxGradient> colorChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.colorOverLifetime;
            module.color = colorChanger(module.color);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorOverLifetimeModule SetColor(this ColorOverLifetimeModule module, MinMaxGradient color)
        {
            module.color = color;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorOverLifetimeModule SetColor(this ColorOverLifetimeModule module, Func<MinMaxGradient, MinMaxGradient> colorChanger)
        {
            module.color = colorChanger(module.color);
            return module;
        }
        #endregion

        #region Enabled
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorOverLifetimeEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.colorOverLifetime;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorOverLifetimeEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.colorOverLifetime;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorOverLifetimeModule SetEnabled(this ColorOverLifetimeModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorOverLifetimeModule SetEnabled(this ColorOverLifetimeModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion
#endif
    }
}
