using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class EmissionModuleExtension
    {
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditEmission(this ParticleSystem particleSystem, Action<EmissionModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.emission);
            return particleSystem;
        }

        #region BurstCount
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionBurstCount(this ParticleSystem particleSystem, int burstCount)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.burstCount = burstCount;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionBurstCount(this ParticleSystem particleSystem, Func<int, int> burstCountChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.burstCount = burstCountChanger(module.burstCount);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetBurstCount(this EmissionModule module, int burstCount)
        {
            module.burstCount = burstCount;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetBurstCount(this EmissionModule module, Func<int, int> burstCountChanger)
        {
            module.burstCount = burstCountChanger(module.burstCount);
            return module;
        }
#endif
        #endregion

        #region Enabled
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetEnabled(this EmissionModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetEnabled(this EmissionModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
#endif
        #endregion

        #region RateOverDistance
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverDistance(this ParticleSystem particleSystem, MinMaxCurve rateOverDistance)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.rateOverDistance = rateOverDistance;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverDistance(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> rateOverDistanceChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.rateOverDistance = rateOverDistanceChanger(module.rateOverDistance);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverDistance(this EmissionModule module, MinMaxCurve rateOverDistance)
        {
            module.rateOverDistance = rateOverDistance;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverDistance(this EmissionModule module, Func<MinMaxCurve, MinMaxCurve> rateOverDistanceChanger)
        {
            module.rateOverDistance = rateOverDistanceChanger(module.rateOverDistance);
            return module;
        }
#endif
        #endregion

        #region RateOverDistanceMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverDistanceMultiplier(this ParticleSystem particleSystem, float rateOverDistanceMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.rateOverDistanceMultiplier = rateOverDistanceMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverDistanceMultiplier(this ParticleSystem particleSystem, Func<float, float> rateOverDistanceMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.rateOverDistanceMultiplier = rateOverDistanceMultiplierChanger(module.rateOverDistanceMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverDistanceMultiplier(this EmissionModule module, float rateOverDistanceMultiplier)
        {
            module.rateOverDistanceMultiplier = rateOverDistanceMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverDistanceMultiplier(this EmissionModule module, Func<float, float> rateOverDistanceMultiplierChanger)
        {
            module.rateOverDistanceMultiplier = rateOverDistanceMultiplierChanger(module.rateOverDistanceMultiplier);
            return module;
        }
#endif
        #endregion

        #region RateOverTime
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverTime(this ParticleSystem particleSystem, MinMaxCurve rateOverTime)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.rateOverTime = rateOverTime;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverTime(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> rateOverTimeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.rateOverTime = rateOverTimeChanger(module.rateOverTime);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverTime(this EmissionModule module, MinMaxCurve rateOverTime)
        {
            module.rateOverTime = rateOverTime;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverTime(this EmissionModule module, Func<MinMaxCurve, MinMaxCurve> rateOverTimeChanger)
        {
            module.rateOverTime = rateOverTimeChanger(module.rateOverTime);
            return module;
        }
#endif
        #endregion

        #region RateOverTimeMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverTimeMultiplier(this ParticleSystem particleSystem, float rateOverTimeMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.rateOverTimeMultiplier = rateOverTimeMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverTimeMultiplier(this ParticleSystem particleSystem, Func<float, float> rateOverTimeMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.rateOverTimeMultiplier = rateOverTimeMultiplierChanger(module.rateOverTimeMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverTimeMultiplier(this EmissionModule module, float rateOverTimeMultiplier)
        {
            module.rateOverTimeMultiplier = rateOverTimeMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverTimeMultiplier(this EmissionModule module, Func<float, float> rateOverTimeMultiplierChanger)
        {
            module.rateOverTimeMultiplier = rateOverTimeMultiplierChanger(module.rateOverTimeMultiplier);
            return module;
        }
#endif
        #endregion
#endif
    }
}
