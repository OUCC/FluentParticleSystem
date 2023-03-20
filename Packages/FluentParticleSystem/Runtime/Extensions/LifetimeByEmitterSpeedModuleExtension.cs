using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class LifetimeByEmitterSpeedModuleExtension
    {
#if UNITY_2020_3_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.lifetimeByEmitterSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditLifetimeByEmitterSpeed(this ParticleSystem particleSystem, Action<LifetimeByEmitterSpeedModule> moduleEditor)
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
        public static ParticleSystem SetLifetimeByEmitterSpeedCurve(this ParticleSystem particleSystem, MinMaxCurve curve)
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
        public static ParticleSystem SetLifetimeByEmitterSpeedCurve(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> curveChanger)
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
        public static LifetimeByEmitterSpeedModule SetCurve(this LifetimeByEmitterSpeedModule module, Func<MinMaxCurve, MinMaxCurve> curveChanger)
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
        public static ParticleSystem SetLifetimeByEmitterSpeedCurveMultiplier(this ParticleSystem particleSystem, float curveMultiplier)
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
        public static ParticleSystem SetLifetimeByEmitterSpeedCurveMultiplier(this ParticleSystem particleSystem, Func<float, float> curveMultiplierChanger)
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
        public static LifetimeByEmitterSpeedModule SetCurveMultiplier(this LifetimeByEmitterSpeedModule module, Func<float, float> curveMultiplierChanger)
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
        public static ParticleSystem SetLifetimeByEmitterSpeedEnabled(this ParticleSystem particleSystem, bool enabled)
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
        public static ParticleSystem SetLifetimeByEmitterSpeedEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
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
        public static LifetimeByEmitterSpeedModule SetEnabled(this LifetimeByEmitterSpeedModule module, Func<bool, bool> enabledChanger)
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
        public static ParticleSystem SetLifetimeByEmitterSpeedRange(this ParticleSystem particleSystem, Vector2 range)
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
        public static ParticleSystem SetLifetimeByEmitterSpeedRange(this ParticleSystem particleSystem, Func<Vector2, Vector2> rangeChanger)
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
        public static LifetimeByEmitterSpeedModule SetRange(this LifetimeByEmitterSpeedModule module, Func<Vector2, Vector2> rangeChanger)
        {
            Debug.Assert(rangeChanger != null, "rangeChanger cannot be null");
            module.range = rangeChanger(module.range);
            return module;
        }
        #endregion
#endif
    }
}
