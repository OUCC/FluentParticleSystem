using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class InheritVelocityModuleExtension
    {
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditInheritVelocity(this ParticleSystem particleSystem, Action<InheritVelocityModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.inheritVelocity);
            return particleSystem;
        }

        #region Curve
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityCurve(this ParticleSystem particleSystem, MinMaxCurve curve)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.inheritVelocity;
            module.curve = curve;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityCurve(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> curveChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.inheritVelocity;
            module.curve = curveChanger(module.curve);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetCurve(this InheritVelocityModule module, MinMaxCurve curve)
        {
            module.curve = curve;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetCurve(this InheritVelocityModule module, Func<MinMaxCurve, MinMaxCurve> curveChanger)
        {
            module.curve = curveChanger(module.curve);
            return module;
        }
#endif
        #endregion

        #region CurveMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityCurveMultiplier(this ParticleSystem particleSystem, float curveMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.inheritVelocity;
            module.curveMultiplier = curveMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityCurveMultiplier(this ParticleSystem particleSystem, Func<float, float> curveMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.inheritVelocity;
            module.curveMultiplier = curveMultiplierChanger(module.curveMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetCurveMultiplier(this InheritVelocityModule module, float curveMultiplier)
        {
            module.curveMultiplier = curveMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetCurveMultiplier(this InheritVelocityModule module, Func<float, float> curveMultiplierChanger)
        {
            module.curveMultiplier = curveMultiplierChanger(module.curveMultiplier);
            return module;
        }
#endif
        #endregion

        #region Enabled
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.inheritVelocity;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.inheritVelocity;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetEnabled(this InheritVelocityModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetEnabled(this InheritVelocityModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
#endif
        #endregion

        #region Mode
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityMode(this ParticleSystem particleSystem, ParticleSystemInheritVelocityMode mode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.inheritVelocity;
            module.mode = mode;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityMode(this ParticleSystem particleSystem, Func<ParticleSystemInheritVelocityMode, ParticleSystemInheritVelocityMode> modeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.inheritVelocity;
            module.mode = modeChanger(module.mode);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetMode(this InheritVelocityModule module, ParticleSystemInheritVelocityMode mode)
        {
            module.mode = mode;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetMode(this InheritVelocityModule module, Func<ParticleSystemInheritVelocityMode, ParticleSystemInheritVelocityMode> modeChanger)
        {
            module.mode = modeChanger(module.mode);
            return module;
        }
#endif
        #endregion
#endif
    }
}
