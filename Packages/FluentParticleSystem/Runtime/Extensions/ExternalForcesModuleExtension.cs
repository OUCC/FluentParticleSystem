#if UNITY_2020_2_OR_NEWER
#nullable enable
#endif
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class ExternalForcesModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.externalForces"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditExternalForces(this ParticleSystem particleSystem, Action<ExternalForcesModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.externalForces);
            return particleSystem;
        }

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="ExternalForcesModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetExternalForcesEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.externalForces;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ExternalForcesModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetExternalForcesEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.externalForces;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ExternalForcesModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetEnabled(this ExternalForcesModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ExternalForcesModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetEnabled(this ExternalForcesModule module, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region InfluenceFilter
        /// <summary>
        /// Assign a value to <see cref="ExternalForcesModule.influenceFilter"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetExternalForcesInfluenceFilter(this ParticleSystem particleSystem, ParticleSystemGameObjectFilter influenceFilter)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.externalForces;
            module.influenceFilter = influenceFilter;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ExternalForcesModule.influenceFilter"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetExternalForcesInfluenceFilter(this ParticleSystem particleSystem, Func<ParticleSystemGameObjectFilter, ParticleSystemGameObjectFilter> influenceFilterChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(influenceFilterChanger != null, "influenceFilterChanger cannot be null");
            var module = particleSystem.externalForces;
            module.influenceFilter = influenceFilterChanger(module.influenceFilter);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ExternalForcesModule.influenceFilter"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetInfluenceFilter(this ExternalForcesModule module, ParticleSystemGameObjectFilter influenceFilter)
        {
            module.influenceFilter = influenceFilter;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ExternalForcesModule.influenceFilter"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetInfluenceFilter(this ExternalForcesModule module, Func<ParticleSystemGameObjectFilter, ParticleSystemGameObjectFilter> influenceFilterChanger)
        {
            Debug.Assert(influenceFilterChanger != null, "influenceFilterChanger cannot be null");
            module.influenceFilter = influenceFilterChanger(module.influenceFilter);
            return module;
        }
        #endregion
#endif

#if UNITY_2019_4_OR_NEWER
        #region InfluenceMask
        /// <summary>
        /// Assign a value to <see cref="ExternalForcesModule.influenceMask"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetExternalForcesInfluenceMask(this ParticleSystem particleSystem, LayerMask influenceMask)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.externalForces;
            module.influenceMask = influenceMask;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ExternalForcesModule.influenceMask"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetExternalForcesInfluenceMask(this ParticleSystem particleSystem, Func<LayerMask, LayerMask> influenceMaskChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(influenceMaskChanger != null, "influenceMaskChanger cannot be null");
            var module = particleSystem.externalForces;
            module.influenceMask = influenceMaskChanger(module.influenceMask);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ExternalForcesModule.influenceMask"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetInfluenceMask(this ExternalForcesModule module, LayerMask influenceMask)
        {
            module.influenceMask = influenceMask;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ExternalForcesModule.influenceMask"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetInfluenceMask(this ExternalForcesModule module, Func<LayerMask, LayerMask> influenceMaskChanger)
        {
            Debug.Assert(influenceMaskChanger != null, "influenceMaskChanger cannot be null");
            module.influenceMask = influenceMaskChanger(module.influenceMask);
            return module;
        }
        #endregion
#endif

#if UNITY_2018_4_OR_NEWER
        #region Multiplier
        /// <summary>
        /// Assign a value to <see cref="ExternalForcesModule.multiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetExternalForcesMultiplier(this ParticleSystem particleSystem, float multiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.externalForces;
            module.multiplier = multiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ExternalForcesModule.multiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetExternalForcesMultiplier(this ParticleSystem particleSystem, Func<float, float> multiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(multiplierChanger != null, "multiplierChanger cannot be null");
            var module = particleSystem.externalForces;
            module.multiplier = multiplierChanger(module.multiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ExternalForcesModule.multiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetMultiplier(this ExternalForcesModule module, float multiplier)
        {
            module.multiplier = multiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ExternalForcesModule.multiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetMultiplier(this ExternalForcesModule module, Func<float, float> multiplierChanger)
        {
            Debug.Assert(multiplierChanger != null, "multiplierChanger cannot be null");
            module.multiplier = multiplierChanger(module.multiplier);
            return module;
        }
        #endregion
#endif

#if UNITY_2019_4_OR_NEWER
        #region MultiplierCurve
        /// <summary>
        /// Assign a value to <see cref="ExternalForcesModule.multiplierCurve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetExternalForcesMultiplierCurve(this ParticleSystem particleSystem, MinMaxCurve multiplierCurve)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.externalForces;
            module.multiplierCurve = multiplierCurve;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ExternalForcesModule.multiplierCurve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetExternalForcesMultiplierCurve(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> multiplierCurveChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(multiplierCurveChanger != null, "multiplierCurveChanger cannot be null");
            var module = particleSystem.externalForces;
            module.multiplierCurve = multiplierCurveChanger(module.multiplierCurve);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ExternalForcesModule.multiplierCurve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetMultiplierCurve(this ExternalForcesModule module, MinMaxCurve multiplierCurve)
        {
            module.multiplierCurve = multiplierCurve;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ExternalForcesModule.multiplierCurve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetMultiplierCurve(this ExternalForcesModule module, Func<MinMaxCurve, MinMaxCurve> multiplierCurveChanger)
        {
            Debug.Assert(multiplierCurveChanger != null, "multiplierCurveChanger cannot be null");
            module.multiplierCurve = multiplierCurveChanger(module.multiplierCurve);
            return module;
        }
        #endregion
#endif
    }
}
