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
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="ExternalForcesModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetEnabled(this ExternalForcesModule module, Func<bool, bool> enabledChanger)
        {
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
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="ExternalForcesModule.influenceFilter"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetInfluenceFilter(this ExternalForcesModule module, Func<ParticleSystemGameObjectFilter, ParticleSystemGameObjectFilter> influenceFilterChanger)
        {
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
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="ExternalForcesModule.influenceMask"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetInfluenceMask(this ExternalForcesModule module, Func<LayerMask, LayerMask> influenceMaskChanger)
        {
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
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="ExternalForcesModule.multiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetMultiplier(this ExternalForcesModule module, Func<float, float> multiplierChanger)
        {
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
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="ExternalForcesModule.multiplierCurve"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ExternalForcesModule SetMultiplierCurve(this ExternalForcesModule module, Func<MinMaxCurve, MinMaxCurve> multiplierCurveChanger)
        {
            module.multiplierCurve = multiplierCurveChanger(module.multiplierCurve);
            return module;
        }
        #endregion
#endif
    }
}
