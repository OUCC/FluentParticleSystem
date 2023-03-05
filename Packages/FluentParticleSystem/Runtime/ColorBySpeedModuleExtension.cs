using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class ColorBySpeedModuleExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditColorBySpeed(this ParticleSystem particleSystem, Action<ColorBySpeedModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.colorBySpeed);
            return particleSystem;
        }

        #region Color
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorBySpeedColor(this ParticleSystem particleSystem, MinMaxGradient color)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.colorBySpeed;
            module.color = color;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorBySpeedColor(this ParticleSystem particleSystem, Func<MinMaxGradient, MinMaxGradient> colorChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.colorBySpeed;
            module.color = colorChanger(module.color);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorBySpeedModule SetColor(this ColorBySpeedModule module, MinMaxGradient color)
        {
            module.color = color;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorBySpeedModule SetColor(this ColorBySpeedModule module, Func<MinMaxGradient, MinMaxGradient> colorChanger)
        {
            module.color = colorChanger(module.color);
            return module;
        }
        #endregion

        #region Enabled
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorBySpeedEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.colorBySpeed;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorBySpeedEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.colorBySpeed;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorBySpeedModule SetEnabled(this ColorBySpeedModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorBySpeedModule SetEnabled(this ColorBySpeedModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Range
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorBySpeedRange(this ParticleSystem particleSystem, UnityEngine.Vector2 range)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.colorBySpeed;
            module.range = range;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetColorBySpeedRange(this ParticleSystem particleSystem, Func<UnityEngine.Vector2, UnityEngine.Vector2> rangeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.colorBySpeed;
            module.range = rangeChanger(module.range);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorBySpeedModule SetRange(this ColorBySpeedModule module, UnityEngine.Vector2 range)
        {
            module.range = range;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ColorBySpeedModule SetRange(this ColorBySpeedModule module, Func<UnityEngine.Vector2, UnityEngine.Vector2> rangeChanger)
        {
            module.range = rangeChanger(module.range);
            return module;
        }
        #endregion
    }
}
