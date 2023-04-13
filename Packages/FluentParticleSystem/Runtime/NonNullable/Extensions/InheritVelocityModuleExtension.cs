using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class InheritVelocityModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.inheritVelocity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditInheritVelocity(this ParticleSystem particleSystem, Action<InheritVelocityModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.inheritVelocity);
            return particleSystem;
        }

        #region Curve
        /// <summary>
        /// Assign a value to <see cref="InheritVelocityModule.curve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityCurve(this ParticleSystem particleSystem, MinMaxCurve curve)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.inheritVelocity;
            module.curve = curve;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="InheritVelocityModule.curve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityCurve(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> curveChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(curveChanger != null, "curveChanger cannot be null");
            var module = particleSystem.inheritVelocity;
            module.curve = curveChanger(module.curve);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="InheritVelocityModule.curve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetCurve(this InheritVelocityModule module, MinMaxCurve curve)
        {
            module.curve = curve;
            return module;
        }

        /// <summary>
        /// Edit <see cref="InheritVelocityModule.curve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetCurve(this InheritVelocityModule module, Func<MinMaxCurve, MinMaxCurve> curveChanger)
        {
            Debug.Assert(curveChanger != null, "curveChanger cannot be null");
            module.curve = curveChanger(module.curve);
            return module;
        }
        #endregion

        #region CurveMultiplier
        /// <summary>
        /// Assign a value to <see cref="InheritVelocityModule.curveMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityCurveMultiplier(this ParticleSystem particleSystem, float curveMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.inheritVelocity;
            module.curveMultiplier = curveMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="InheritVelocityModule.curveMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityCurveMultiplier(this ParticleSystem particleSystem, Func<float, float> curveMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(curveMultiplierChanger != null, "curveMultiplierChanger cannot be null");
            var module = particleSystem.inheritVelocity;
            module.curveMultiplier = curveMultiplierChanger(module.curveMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="InheritVelocityModule.curveMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetCurveMultiplier(this InheritVelocityModule module, float curveMultiplier)
        {
            module.curveMultiplier = curveMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="InheritVelocityModule.curveMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetCurveMultiplier(this InheritVelocityModule module, Func<float, float> curveMultiplierChanger)
        {
            Debug.Assert(curveMultiplierChanger != null, "curveMultiplierChanger cannot be null");
            module.curveMultiplier = curveMultiplierChanger(module.curveMultiplier);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="InheritVelocityModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.inheritVelocity;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="InheritVelocityModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.inheritVelocity;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="InheritVelocityModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetEnabled(this InheritVelocityModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="InheritVelocityModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetEnabled(this InheritVelocityModule module, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Mode
        /// <summary>
        /// Assign a value to <see cref="InheritVelocityModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityMode(this ParticleSystem particleSystem, ParticleSystemInheritVelocityMode mode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.inheritVelocity;
            module.mode = mode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="InheritVelocityModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetInheritVelocityMode(this ParticleSystem particleSystem, Func<ParticleSystemInheritVelocityMode, ParticleSystemInheritVelocityMode> modeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(modeChanger != null, "modeChanger cannot be null");
            var module = particleSystem.inheritVelocity;
            module.mode = modeChanger(module.mode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="InheritVelocityModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetMode(this InheritVelocityModule module, ParticleSystemInheritVelocityMode mode)
        {
            module.mode = mode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="InheritVelocityModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static InheritVelocityModule SetMode(this InheritVelocityModule module, Func<ParticleSystemInheritVelocityMode, ParticleSystemInheritVelocityMode> modeChanger)
        {
            Debug.Assert(modeChanger != null, "modeChanger cannot be null");
            module.mode = modeChanger(module.mode);
            return module;
        }
        #endregion
#endif
    }
}
