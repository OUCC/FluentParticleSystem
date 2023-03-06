using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class NoiseModuleExtension
    {
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditNoise(this ParticleSystem particleSystem, Action<NoiseModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.noise);
            return particleSystem;
        }

        #region Damping
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseDamping(this ParticleSystem particleSystem, bool damping)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.damping = damping;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseDamping(this ParticleSystem particleSystem, Func<bool, bool> dampingChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.damping = dampingChanger(module.damping);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetDamping(this NoiseModule module, bool damping)
        {
            module.damping = damping;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetDamping(this NoiseModule module, Func<bool, bool> dampingChanger)
        {
            module.damping = dampingChanger(module.damping);
            return module;
        }
#endif
        #endregion

        #region Enabled
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetEnabled(this NoiseModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetEnabled(this NoiseModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
#endif
        #endregion

        #region Frequency
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseFrequency(this ParticleSystem particleSystem, float frequency)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.frequency = frequency;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseFrequency(this ParticleSystem particleSystem, Func<float, float> frequencyChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.frequency = frequencyChanger(module.frequency);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetFrequency(this NoiseModule module, float frequency)
        {
            module.frequency = frequency;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetFrequency(this NoiseModule module, Func<float, float> frequencyChanger)
        {
            module.frequency = frequencyChanger(module.frequency);
            return module;
        }
#endif
        #endregion

        #region OctaveCount
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseOctaveCount(this ParticleSystem particleSystem, int octaveCount)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.octaveCount = octaveCount;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseOctaveCount(this ParticleSystem particleSystem, Func<int, int> octaveCountChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.octaveCount = octaveCountChanger(module.octaveCount);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetOctaveCount(this NoiseModule module, int octaveCount)
        {
            module.octaveCount = octaveCount;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetOctaveCount(this NoiseModule module, Func<int, int> octaveCountChanger)
        {
            module.octaveCount = octaveCountChanger(module.octaveCount);
            return module;
        }
#endif
        #endregion

        #region OctaveMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseOctaveMultiplier(this ParticleSystem particleSystem, float octaveMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.octaveMultiplier = octaveMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseOctaveMultiplier(this ParticleSystem particleSystem, Func<float, float> octaveMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.octaveMultiplier = octaveMultiplierChanger(module.octaveMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetOctaveMultiplier(this NoiseModule module, float octaveMultiplier)
        {
            module.octaveMultiplier = octaveMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetOctaveMultiplier(this NoiseModule module, Func<float, float> octaveMultiplierChanger)
        {
            module.octaveMultiplier = octaveMultiplierChanger(module.octaveMultiplier);
            return module;
        }
#endif
        #endregion

        #region OctaveScale
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseOctaveScale(this ParticleSystem particleSystem, float octaveScale)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.octaveScale = octaveScale;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseOctaveScale(this ParticleSystem particleSystem, Func<float, float> octaveScaleChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.octaveScale = octaveScaleChanger(module.octaveScale);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetOctaveScale(this NoiseModule module, float octaveScale)
        {
            module.octaveScale = octaveScale;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetOctaveScale(this NoiseModule module, Func<float, float> octaveScaleChanger)
        {
            module.octaveScale = octaveScaleChanger(module.octaveScale);
            return module;
        }
#endif
        #endregion

        #region PositionAmount
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoisePositionAmount(this ParticleSystem particleSystem, MinMaxCurve positionAmount)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.positionAmount = positionAmount;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoisePositionAmount(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> positionAmountChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.positionAmount = positionAmountChanger(module.positionAmount);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetPositionAmount(this NoiseModule module, MinMaxCurve positionAmount)
        {
            module.positionAmount = positionAmount;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetPositionAmount(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> positionAmountChanger)
        {
            module.positionAmount = positionAmountChanger(module.positionAmount);
            return module;
        }
#endif
        #endregion

        #region Quality
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseQuality(this ParticleSystem particleSystem, ParticleSystemNoiseQuality quality)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.quality = quality;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseQuality(this ParticleSystem particleSystem, Func<ParticleSystemNoiseQuality, ParticleSystemNoiseQuality> qualityChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.quality = qualityChanger(module.quality);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetQuality(this NoiseModule module, ParticleSystemNoiseQuality quality)
        {
            module.quality = quality;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetQuality(this NoiseModule module, Func<ParticleSystemNoiseQuality, ParticleSystemNoiseQuality> qualityChanger)
        {
            module.quality = qualityChanger(module.quality);
            return module;
        }
#endif
        #endregion

        #region Remap
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemap(this ParticleSystem particleSystem, MinMaxCurve remap)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remap = remap;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemap(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> remapChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remap = remapChanger(module.remap);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemap(this NoiseModule module, MinMaxCurve remap)
        {
            module.remap = remap;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemap(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> remapChanger)
        {
            module.remap = remapChanger(module.remap);
            return module;
        }
#endif
        #endregion

        #region RemapEnabled
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapEnabled(this ParticleSystem particleSystem, bool remapEnabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapEnabled = remapEnabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapEnabled(this ParticleSystem particleSystem, Func<bool, bool> remapEnabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapEnabled = remapEnabledChanger(module.remapEnabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapEnabled(this NoiseModule module, bool remapEnabled)
        {
            module.remapEnabled = remapEnabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapEnabled(this NoiseModule module, Func<bool, bool> remapEnabledChanger)
        {
            module.remapEnabled = remapEnabledChanger(module.remapEnabled);
            return module;
        }
#endif
        #endregion

        #region RemapMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapMultiplier(this ParticleSystem particleSystem, float remapMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapMultiplier = remapMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapMultiplier(this ParticleSystem particleSystem, Func<float, float> remapMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapMultiplier = remapMultiplierChanger(module.remapMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapMultiplier(this NoiseModule module, float remapMultiplier)
        {
            module.remapMultiplier = remapMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapMultiplier(this NoiseModule module, Func<float, float> remapMultiplierChanger)
        {
            module.remapMultiplier = remapMultiplierChanger(module.remapMultiplier);
            return module;
        }
#endif
        #endregion

        #region RemapX
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapX(this ParticleSystem particleSystem, MinMaxCurve remapX)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapX = remapX;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> remapXChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapX = remapXChanger(module.remapX);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapX(this NoiseModule module, MinMaxCurve remapX)
        {
            module.remapX = remapX;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapX(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> remapXChanger)
        {
            module.remapX = remapXChanger(module.remapX);
            return module;
        }
#endif
        #endregion

        #region RemapXMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapXMultiplier(this ParticleSystem particleSystem, float remapXMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapXMultiplier = remapXMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapXMultiplier(this ParticleSystem particleSystem, Func<float, float> remapXMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapXMultiplier = remapXMultiplierChanger(module.remapXMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapXMultiplier(this NoiseModule module, float remapXMultiplier)
        {
            module.remapXMultiplier = remapXMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapXMultiplier(this NoiseModule module, Func<float, float> remapXMultiplierChanger)
        {
            module.remapXMultiplier = remapXMultiplierChanger(module.remapXMultiplier);
            return module;
        }
#endif
        #endregion

        #region RemapY
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapY(this ParticleSystem particleSystem, MinMaxCurve remapY)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapY = remapY;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> remapYChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapY = remapYChanger(module.remapY);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapY(this NoiseModule module, MinMaxCurve remapY)
        {
            module.remapY = remapY;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapY(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> remapYChanger)
        {
            module.remapY = remapYChanger(module.remapY);
            return module;
        }
#endif
        #endregion

        #region RemapYMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapYMultiplier(this ParticleSystem particleSystem, float remapYMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapYMultiplier = remapYMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapYMultiplier(this ParticleSystem particleSystem, Func<float, float> remapYMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapYMultiplier = remapYMultiplierChanger(module.remapYMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapYMultiplier(this NoiseModule module, float remapYMultiplier)
        {
            module.remapYMultiplier = remapYMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapYMultiplier(this NoiseModule module, Func<float, float> remapYMultiplierChanger)
        {
            module.remapYMultiplier = remapYMultiplierChanger(module.remapYMultiplier);
            return module;
        }
#endif
        #endregion

        #region RemapZ
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapZ(this ParticleSystem particleSystem, MinMaxCurve remapZ)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapZ = remapZ;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> remapZChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapZ = remapZChanger(module.remapZ);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapZ(this NoiseModule module, MinMaxCurve remapZ)
        {
            module.remapZ = remapZ;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapZ(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> remapZChanger)
        {
            module.remapZ = remapZChanger(module.remapZ);
            return module;
        }
#endif
        #endregion

        #region RemapZMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapZMultiplier(this ParticleSystem particleSystem, float remapZMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapZMultiplier = remapZMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapZMultiplier(this ParticleSystem particleSystem, Func<float, float> remapZMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.remapZMultiplier = remapZMultiplierChanger(module.remapZMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapZMultiplier(this NoiseModule module, float remapZMultiplier)
        {
            module.remapZMultiplier = remapZMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapZMultiplier(this NoiseModule module, Func<float, float> remapZMultiplierChanger)
        {
            module.remapZMultiplier = remapZMultiplierChanger(module.remapZMultiplier);
            return module;
        }
#endif
        #endregion

        #region RotationAmount
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRotationAmount(this ParticleSystem particleSystem, MinMaxCurve rotationAmount)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.rotationAmount = rotationAmount;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRotationAmount(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> rotationAmountChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.rotationAmount = rotationAmountChanger(module.rotationAmount);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRotationAmount(this NoiseModule module, MinMaxCurve rotationAmount)
        {
            module.rotationAmount = rotationAmount;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRotationAmount(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> rotationAmountChanger)
        {
            module.rotationAmount = rotationAmountChanger(module.rotationAmount);
            return module;
        }
#endif
        #endregion

        #region ScrollSpeed
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseScrollSpeed(this ParticleSystem particleSystem, MinMaxCurve scrollSpeed)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.scrollSpeed = scrollSpeed;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseScrollSpeed(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> scrollSpeedChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.scrollSpeed = scrollSpeedChanger(module.scrollSpeed);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetScrollSpeed(this NoiseModule module, MinMaxCurve scrollSpeed)
        {
            module.scrollSpeed = scrollSpeed;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetScrollSpeed(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> scrollSpeedChanger)
        {
            module.scrollSpeed = scrollSpeedChanger(module.scrollSpeed);
            return module;
        }
#endif
        #endregion

        #region ScrollSpeedMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseScrollSpeedMultiplier(this ParticleSystem particleSystem, float scrollSpeedMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.scrollSpeedMultiplier = scrollSpeedMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseScrollSpeedMultiplier(this ParticleSystem particleSystem, Func<float, float> scrollSpeedMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.scrollSpeedMultiplier = scrollSpeedMultiplierChanger(module.scrollSpeedMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetScrollSpeedMultiplier(this NoiseModule module, float scrollSpeedMultiplier)
        {
            module.scrollSpeedMultiplier = scrollSpeedMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetScrollSpeedMultiplier(this NoiseModule module, Func<float, float> scrollSpeedMultiplierChanger)
        {
            module.scrollSpeedMultiplier = scrollSpeedMultiplierChanger(module.scrollSpeedMultiplier);
            return module;
        }
#endif
        #endregion

        #region SeparateAxes
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseSeparateAxes(this ParticleSystem particleSystem, bool separateAxes)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.separateAxes = separateAxes;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseSeparateAxes(this ParticleSystem particleSystem, Func<bool, bool> separateAxesChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetSeparateAxes(this NoiseModule module, bool separateAxes)
        {
            module.separateAxes = separateAxes;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetSeparateAxes(this NoiseModule module, Func<bool, bool> separateAxesChanger)
        {
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return module;
        }
#endif
        #endregion

        #region SizeAmount
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseSizeAmount(this ParticleSystem particleSystem, MinMaxCurve sizeAmount)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.sizeAmount = sizeAmount;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseSizeAmount(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> sizeAmountChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.sizeAmount = sizeAmountChanger(module.sizeAmount);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetSizeAmount(this NoiseModule module, MinMaxCurve sizeAmount)
        {
            module.sizeAmount = sizeAmount;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetSizeAmount(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> sizeAmountChanger)
        {
            module.sizeAmount = sizeAmountChanger(module.sizeAmount);
            return module;
        }
#endif
        #endregion

        #region Strength
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrength(this ParticleSystem particleSystem, MinMaxCurve strength)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strength = strength;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrength(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> strengthChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strength = strengthChanger(module.strength);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrength(this NoiseModule module, MinMaxCurve strength)
        {
            module.strength = strength;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrength(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> strengthChanger)
        {
            module.strength = strengthChanger(module.strength);
            return module;
        }
#endif
        #endregion

        #region StrengthMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthMultiplier(this ParticleSystem particleSystem, float strengthMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthMultiplier = strengthMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthMultiplier(this ParticleSystem particleSystem, Func<float, float> strengthMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthMultiplier = strengthMultiplierChanger(module.strengthMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthMultiplier(this NoiseModule module, float strengthMultiplier)
        {
            module.strengthMultiplier = strengthMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthMultiplier(this NoiseModule module, Func<float, float> strengthMultiplierChanger)
        {
            module.strengthMultiplier = strengthMultiplierChanger(module.strengthMultiplier);
            return module;
        }
#endif
        #endregion

        #region StrengthX
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthX(this ParticleSystem particleSystem, MinMaxCurve strengthX)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthX = strengthX;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> strengthXChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthX = strengthXChanger(module.strengthX);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthX(this NoiseModule module, MinMaxCurve strengthX)
        {
            module.strengthX = strengthX;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthX(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> strengthXChanger)
        {
            module.strengthX = strengthXChanger(module.strengthX);
            return module;
        }
#endif
        #endregion

        #region StrengthXMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthXMultiplier(this ParticleSystem particleSystem, float strengthXMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthXMultiplier = strengthXMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthXMultiplier(this ParticleSystem particleSystem, Func<float, float> strengthXMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthXMultiplier = strengthXMultiplierChanger(module.strengthXMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthXMultiplier(this NoiseModule module, float strengthXMultiplier)
        {
            module.strengthXMultiplier = strengthXMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthXMultiplier(this NoiseModule module, Func<float, float> strengthXMultiplierChanger)
        {
            module.strengthXMultiplier = strengthXMultiplierChanger(module.strengthXMultiplier);
            return module;
        }
#endif
        #endregion

        #region StrengthY
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthY(this ParticleSystem particleSystem, MinMaxCurve strengthY)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthY = strengthY;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> strengthYChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthY = strengthYChanger(module.strengthY);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthY(this NoiseModule module, MinMaxCurve strengthY)
        {
            module.strengthY = strengthY;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthY(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> strengthYChanger)
        {
            module.strengthY = strengthYChanger(module.strengthY);
            return module;
        }
#endif
        #endregion

        #region StrengthYMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthYMultiplier(this ParticleSystem particleSystem, float strengthYMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthYMultiplier = strengthYMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthYMultiplier(this ParticleSystem particleSystem, Func<float, float> strengthYMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthYMultiplier = strengthYMultiplierChanger(module.strengthYMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthYMultiplier(this NoiseModule module, float strengthYMultiplier)
        {
            module.strengthYMultiplier = strengthYMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthYMultiplier(this NoiseModule module, Func<float, float> strengthYMultiplierChanger)
        {
            module.strengthYMultiplier = strengthYMultiplierChanger(module.strengthYMultiplier);
            return module;
        }
#endif
        #endregion

        #region StrengthZ
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthZ(this ParticleSystem particleSystem, MinMaxCurve strengthZ)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthZ = strengthZ;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> strengthZChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthZ = strengthZChanger(module.strengthZ);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthZ(this NoiseModule module, MinMaxCurve strengthZ)
        {
            module.strengthZ = strengthZ;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthZ(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> strengthZChanger)
        {
            module.strengthZ = strengthZChanger(module.strengthZ);
            return module;
        }
#endif
        #endregion

        #region StrengthZMultiplier
#if (UNITY_2021)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthZMultiplier(this ParticleSystem particleSystem, float strengthZMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthZMultiplier = strengthZMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthZMultiplier(this ParticleSystem particleSystem, Func<float, float> strengthZMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.noise;
            module.strengthZMultiplier = strengthZMultiplierChanger(module.strengthZMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthZMultiplier(this NoiseModule module, float strengthZMultiplier)
        {
            module.strengthZMultiplier = strengthZMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthZMultiplier(this NoiseModule module, Func<float, float> strengthZMultiplierChanger)
        {
            module.strengthZMultiplier = strengthZMultiplierChanger(module.strengthZMultiplier);
            return module;
        }
#endif
        #endregion
#endif
    }
}
