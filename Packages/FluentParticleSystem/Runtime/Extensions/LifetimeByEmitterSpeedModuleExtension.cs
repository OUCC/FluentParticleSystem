using System;
using System.Runtime.CompilerServices;
using UnityEngine;

using static UnityEngine.ParticleSystem;

#if UNITY_2020_2_OR_NEWER
using System.Diagnostics.CodeAnalysis;
#endif

namespace OUCC.FluentParticleSystem
{
    public static class LifetimeByEmitterSpeedModuleExtension
    {
#if UNITY_2020_3_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.lifetimeByEmitterSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem EditLifetimeByEmitterSpeed(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Action<LifetimeByEmitterSpeedModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.lifetimeByEmitterSpeed);
            return particleSystem;
        }

        #region Curve
        /// <summary>
        /// Assign a value to <see cref="LifetimeByEmitterSpeedModule.curve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLifetimeByEmitterSpeedCurve(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve curve)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lifetimeByEmitterSpeed;
            module.curve = curve;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LifetimeByEmitterSpeedModule.curve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLifetimeByEmitterSpeedCurve(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<MinMaxCurve, MinMaxCurve> curveChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(curveChanger != null, "curveChanger cannot be null");
            var module = particleSystem.lifetimeByEmitterSpeed;
            module.curve = curveChanger(module.curve);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LifetimeByEmitterSpeedModule.curve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LifetimeByEmitterSpeedModule SetCurve(this LifetimeByEmitterSpeedModule module, MinMaxCurve curve)
        {
            module.curve = curve;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LifetimeByEmitterSpeedModule.curve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LifetimeByEmitterSpeedModule SetCurve(this LifetimeByEmitterSpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<MinMaxCurve, MinMaxCurve> curveChanger)
        {
            Debug.Assert(curveChanger != null, "curveChanger cannot be null");
            module.curve = curveChanger(module.curve);
            return module;
        }
        #endregion

        #region CurveMultiplier
        /// <summary>
        /// Assign a value to <see cref="LifetimeByEmitterSpeedModule.curveMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLifetimeByEmitterSpeedCurveMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float curveMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lifetimeByEmitterSpeed;
            module.curveMultiplier = curveMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LifetimeByEmitterSpeedModule.curveMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLifetimeByEmitterSpeedCurveMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> curveMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(curveMultiplierChanger != null, "curveMultiplierChanger cannot be null");
            var module = particleSystem.lifetimeByEmitterSpeed;
            module.curveMultiplier = curveMultiplierChanger(module.curveMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LifetimeByEmitterSpeedModule.curveMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LifetimeByEmitterSpeedModule SetCurveMultiplier(this LifetimeByEmitterSpeedModule module, float curveMultiplier)
        {
            module.curveMultiplier = curveMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LifetimeByEmitterSpeedModule.curveMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LifetimeByEmitterSpeedModule SetCurveMultiplier(this LifetimeByEmitterSpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> curveMultiplierChanger)
        {
            Debug.Assert(curveMultiplierChanger != null, "curveMultiplierChanger cannot be null");
            module.curveMultiplier = curveMultiplierChanger(module.curveMultiplier);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="LifetimeByEmitterSpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLifetimeByEmitterSpeedEnabled(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lifetimeByEmitterSpeed;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LifetimeByEmitterSpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLifetimeByEmitterSpeedEnabled(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.lifetimeByEmitterSpeed;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LifetimeByEmitterSpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LifetimeByEmitterSpeedModule SetEnabled(this LifetimeByEmitterSpeedModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LifetimeByEmitterSpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LifetimeByEmitterSpeedModule SetEnabled(this LifetimeByEmitterSpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Range
        /// <summary>
        /// Assign a value to <see cref="LifetimeByEmitterSpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLifetimeByEmitterSpeedRange(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, Vector2 range)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lifetimeByEmitterSpeed;
            module.range = range;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LifetimeByEmitterSpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLifetimeByEmitterSpeedRange(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<Vector2, Vector2> rangeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rangeChanger != null, "rangeChanger cannot be null");
            var module = particleSystem.lifetimeByEmitterSpeed;
            module.range = rangeChanger(module.range);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LifetimeByEmitterSpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LifetimeByEmitterSpeedModule SetRange(this LifetimeByEmitterSpeedModule module, Vector2 range)
        {
            module.range = range;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LifetimeByEmitterSpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LifetimeByEmitterSpeedModule SetRange(this LifetimeByEmitterSpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<Vector2, Vector2> rangeChanger)
        {
            Debug.Assert(rangeChanger != null, "rangeChanger cannot be null");
            module.range = rangeChanger(module.range);
            return module;
        }
        #endregion
#endif
    }
}
