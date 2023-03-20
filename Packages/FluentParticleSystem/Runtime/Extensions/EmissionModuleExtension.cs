#nullable enable
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class EmissionModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.emission"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditEmission(this ParticleSystem particleSystem, Action<EmissionModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.emission);
            return particleSystem;
        }

        #region BurstCount
        /// <summary>
        /// Assign a value to <see cref="EmissionModule.burstCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionBurstCount(this ParticleSystem particleSystem, int burstCount)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.emission;
            module.burstCount = burstCount;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.burstCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionBurstCount(this ParticleSystem particleSystem, Func<int, int> burstCountChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(burstCountChanger != null, "burstCountChanger cannot be null");
            var module = particleSystem.emission;
            module.burstCount = burstCountChanger(module.burstCount);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="EmissionModule.burstCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetBurstCount(this EmissionModule module, int burstCount)
        {
            module.burstCount = burstCount;
            return module;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.burstCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetBurstCount(this EmissionModule module, Func<int, int> burstCountChanger)
        {
            Debug.Assert(burstCountChanger != null, "burstCountChanger cannot be null");
            module.burstCount = burstCountChanger(module.burstCount);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="EmissionModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.emission;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.emission;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="EmissionModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetEnabled(this EmissionModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetEnabled(this EmissionModule module, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Rate
        /// <summary>
        /// Assign a value to <see cref="EmissionModule.rate"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("rate property is deprecated. Use rateOverTime or rateOverDistance instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRate(this ParticleSystem particleSystem, MinMaxCurve rate)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.emission;
            module.rate = rate;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.rate"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("rate property is deprecated. Use rateOverTime or rateOverDistance instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRate(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> rateChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rateChanger != null, "rateChanger cannot be null");
            var module = particleSystem.emission;
            module.rate = rateChanger(module.rate);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="EmissionModule.rate"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("rate property is deprecated. Use rateOverTime or rateOverDistance instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRate(this EmissionModule module, MinMaxCurve rate)
        {
            module.rate = rate;
            return module;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.rate"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("rate property is deprecated. Use rateOverTime or rateOverDistance instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRate(this EmissionModule module, Func<MinMaxCurve, MinMaxCurve> rateChanger)
        {
            Debug.Assert(rateChanger != null, "rateChanger cannot be null");
            module.rate = rateChanger(module.rate);
            return module;
        }
        #endregion

        #region RateMultiplier
        /// <summary>
        /// Assign a value to <see cref="EmissionModule.rateMultiplier"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("rateMultiplier property is deprecated. Use rateOverTimeMultiplier or rateOverDistanceMultiplier instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateMultiplier(this ParticleSystem particleSystem, float rateMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.emission;
            module.rateMultiplier = rateMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.rateMultiplier"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("rateMultiplier property is deprecated. Use rateOverTimeMultiplier or rateOverDistanceMultiplier instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateMultiplier(this ParticleSystem particleSystem, Func<float, float> rateMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rateMultiplierChanger != null, "rateMultiplierChanger cannot be null");
            var module = particleSystem.emission;
            module.rateMultiplier = rateMultiplierChanger(module.rateMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="EmissionModule.rateMultiplier"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("rateMultiplier property is deprecated. Use rateOverTimeMultiplier or rateOverDistanceMultiplier instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateMultiplier(this EmissionModule module, float rateMultiplier)
        {
            module.rateMultiplier = rateMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.rateMultiplier"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("rateMultiplier property is deprecated. Use rateOverTimeMultiplier or rateOverDistanceMultiplier instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateMultiplier(this EmissionModule module, Func<float, float> rateMultiplierChanger)
        {
            Debug.Assert(rateMultiplierChanger != null, "rateMultiplierChanger cannot be null");
            module.rateMultiplier = rateMultiplierChanger(module.rateMultiplier);
            return module;
        }
        #endregion

        #region RateOverDistance
        /// <summary>
        /// Assign a value to <see cref="EmissionModule.rateOverDistance"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverDistance(this ParticleSystem particleSystem, MinMaxCurve rateOverDistance)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.emission;
            module.rateOverDistance = rateOverDistance;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.rateOverDistance"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverDistance(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> rateOverDistanceChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rateOverDistanceChanger != null, "rateOverDistanceChanger cannot be null");
            var module = particleSystem.emission;
            module.rateOverDistance = rateOverDistanceChanger(module.rateOverDistance);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="EmissionModule.rateOverDistance"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverDistance(this EmissionModule module, MinMaxCurve rateOverDistance)
        {
            module.rateOverDistance = rateOverDistance;
            return module;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.rateOverDistance"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverDistance(this EmissionModule module, Func<MinMaxCurve, MinMaxCurve> rateOverDistanceChanger)
        {
            Debug.Assert(rateOverDistanceChanger != null, "rateOverDistanceChanger cannot be null");
            module.rateOverDistance = rateOverDistanceChanger(module.rateOverDistance);
            return module;
        }
        #endregion

        #region RateOverDistanceMultiplier
        /// <summary>
        /// Assign a value to <see cref="EmissionModule.rateOverDistanceMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverDistanceMultiplier(this ParticleSystem particleSystem, float rateOverDistanceMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.emission;
            module.rateOverDistanceMultiplier = rateOverDistanceMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.rateOverDistanceMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverDistanceMultiplier(this ParticleSystem particleSystem, Func<float, float> rateOverDistanceMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rateOverDistanceMultiplierChanger != null, "rateOverDistanceMultiplierChanger cannot be null");
            var module = particleSystem.emission;
            module.rateOverDistanceMultiplier = rateOverDistanceMultiplierChanger(module.rateOverDistanceMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="EmissionModule.rateOverDistanceMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverDistanceMultiplier(this EmissionModule module, float rateOverDistanceMultiplier)
        {
            module.rateOverDistanceMultiplier = rateOverDistanceMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.rateOverDistanceMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverDistanceMultiplier(this EmissionModule module, Func<float, float> rateOverDistanceMultiplierChanger)
        {
            Debug.Assert(rateOverDistanceMultiplierChanger != null, "rateOverDistanceMultiplierChanger cannot be null");
            module.rateOverDistanceMultiplier = rateOverDistanceMultiplierChanger(module.rateOverDistanceMultiplier);
            return module;
        }
        #endregion

        #region RateOverTime
        /// <summary>
        /// Assign a value to <see cref="EmissionModule.rateOverTime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverTime(this ParticleSystem particleSystem, MinMaxCurve rateOverTime)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.emission;
            module.rateOverTime = rateOverTime;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.rateOverTime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverTime(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> rateOverTimeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rateOverTimeChanger != null, "rateOverTimeChanger cannot be null");
            var module = particleSystem.emission;
            module.rateOverTime = rateOverTimeChanger(module.rateOverTime);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="EmissionModule.rateOverTime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverTime(this EmissionModule module, MinMaxCurve rateOverTime)
        {
            module.rateOverTime = rateOverTime;
            return module;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.rateOverTime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverTime(this EmissionModule module, Func<MinMaxCurve, MinMaxCurve> rateOverTimeChanger)
        {
            Debug.Assert(rateOverTimeChanger != null, "rateOverTimeChanger cannot be null");
            module.rateOverTime = rateOverTimeChanger(module.rateOverTime);
            return module;
        }
        #endregion

        #region RateOverTimeMultiplier
        /// <summary>
        /// Assign a value to <see cref="EmissionModule.rateOverTimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverTimeMultiplier(this ParticleSystem particleSystem, float rateOverTimeMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.emission;
            module.rateOverTimeMultiplier = rateOverTimeMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.rateOverTimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionRateOverTimeMultiplier(this ParticleSystem particleSystem, Func<float, float> rateOverTimeMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rateOverTimeMultiplierChanger != null, "rateOverTimeMultiplierChanger cannot be null");
            var module = particleSystem.emission;
            module.rateOverTimeMultiplier = rateOverTimeMultiplierChanger(module.rateOverTimeMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="EmissionModule.rateOverTimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverTimeMultiplier(this EmissionModule module, float rateOverTimeMultiplier)
        {
            module.rateOverTimeMultiplier = rateOverTimeMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.rateOverTimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetRateOverTimeMultiplier(this EmissionModule module, Func<float, float> rateOverTimeMultiplierChanger)
        {
            Debug.Assert(rateOverTimeMultiplierChanger != null, "rateOverTimeMultiplierChanger cannot be null");
            module.rateOverTimeMultiplier = rateOverTimeMultiplierChanger(module.rateOverTimeMultiplier);
            return module;
        }
        #endregion

        #region Type
        /// <summary>
        /// Assign a value to <see cref="EmissionModule.type"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("ParticleSystemEmissionType no longer does anything. Time and Distance based emission are now both always active.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionType(this ParticleSystem particleSystem, ParticleSystemEmissionType type)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.emission;
            module.type = type;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.type"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("ParticleSystemEmissionType no longer does anything. Time and Distance based emission are now both always active.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionType(this ParticleSystem particleSystem, Func<ParticleSystemEmissionType, ParticleSystemEmissionType> typeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(typeChanger != null, "typeChanger cannot be null");
            var module = particleSystem.emission;
            module.type = typeChanger(module.type);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="EmissionModule.type"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("ParticleSystemEmissionType no longer does anything. Time and Distance based emission are now both always active.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetType(this EmissionModule module, ParticleSystemEmissionType type)
        {
            module.type = type;
            return module;
        }

        /// <summary>
        /// Edit <see cref="EmissionModule.type"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("ParticleSystemEmissionType no longer does anything. Time and Distance based emission are now both always active.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static EmissionModule SetType(this EmissionModule module, Func<ParticleSystemEmissionType, ParticleSystemEmissionType> typeChanger)
        {
            Debug.Assert(typeChanger != null, "typeChanger cannot be null");
            module.type = typeChanger(module.type);
            return module;
        }
        #endregion
#endif
    }
}
