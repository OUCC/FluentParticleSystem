using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class NoiseModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.noise"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditNoise(this ParticleSystem particleSystem, Action<NoiseModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.noise);
            return particleSystem;
        }

        #region Damping
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.damping"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseDamping(this ParticleSystem particleSystem, bool damping)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.damping = damping;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.damping"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseDamping(this ParticleSystem particleSystem, Func<bool, bool> dampingChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(dampingChanger != null, "dampingChanger cannot be null");
            var module = particleSystem.noise;
            module.damping = dampingChanger(module.damping);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.damping"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetDamping(this NoiseModule module, bool damping)
        {
            module.damping = damping;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.damping"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetDamping(this NoiseModule module, Func<bool, bool> dampingChanger)
        {
            Debug.Assert(dampingChanger != null, "dampingChanger cannot be null");
            module.damping = dampingChanger(module.damping);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.noise;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetEnabled(this NoiseModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetEnabled(this NoiseModule module, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Frequency
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.frequency"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseFrequency(this ParticleSystem particleSystem, float frequency)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.frequency = frequency;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.frequency"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseFrequency(this ParticleSystem particleSystem, Func<float, float> frequencyChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(frequencyChanger != null, "frequencyChanger cannot be null");
            var module = particleSystem.noise;
            module.frequency = frequencyChanger(module.frequency);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.frequency"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetFrequency(this NoiseModule module, float frequency)
        {
            module.frequency = frequency;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.frequency"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetFrequency(this NoiseModule module, Func<float, float> frequencyChanger)
        {
            Debug.Assert(frequencyChanger != null, "frequencyChanger cannot be null");
            module.frequency = frequencyChanger(module.frequency);
            return module;
        }
        #endregion

        #region OctaveCount
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.octaveCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseOctaveCount(this ParticleSystem particleSystem, int octaveCount)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.octaveCount = octaveCount;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.octaveCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseOctaveCount(this ParticleSystem particleSystem, Func<int, int> octaveCountChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(octaveCountChanger != null, "octaveCountChanger cannot be null");
            var module = particleSystem.noise;
            module.octaveCount = octaveCountChanger(module.octaveCount);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.octaveCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetOctaveCount(this NoiseModule module, int octaveCount)
        {
            module.octaveCount = octaveCount;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.octaveCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetOctaveCount(this NoiseModule module, Func<int, int> octaveCountChanger)
        {
            Debug.Assert(octaveCountChanger != null, "octaveCountChanger cannot be null");
            module.octaveCount = octaveCountChanger(module.octaveCount);
            return module;
        }
        #endregion

        #region OctaveMultiplier
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.octaveMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseOctaveMultiplier(this ParticleSystem particleSystem, float octaveMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.octaveMultiplier = octaveMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.octaveMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseOctaveMultiplier(this ParticleSystem particleSystem, Func<float, float> octaveMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(octaveMultiplierChanger != null, "octaveMultiplierChanger cannot be null");
            var module = particleSystem.noise;
            module.octaveMultiplier = octaveMultiplierChanger(module.octaveMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.octaveMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetOctaveMultiplier(this NoiseModule module, float octaveMultiplier)
        {
            module.octaveMultiplier = octaveMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.octaveMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetOctaveMultiplier(this NoiseModule module, Func<float, float> octaveMultiplierChanger)
        {
            Debug.Assert(octaveMultiplierChanger != null, "octaveMultiplierChanger cannot be null");
            module.octaveMultiplier = octaveMultiplierChanger(module.octaveMultiplier);
            return module;
        }
        #endregion

        #region OctaveScale
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.octaveScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseOctaveScale(this ParticleSystem particleSystem, float octaveScale)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.octaveScale = octaveScale;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.octaveScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseOctaveScale(this ParticleSystem particleSystem, Func<float, float> octaveScaleChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(octaveScaleChanger != null, "octaveScaleChanger cannot be null");
            var module = particleSystem.noise;
            module.octaveScale = octaveScaleChanger(module.octaveScale);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.octaveScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetOctaveScale(this NoiseModule module, float octaveScale)
        {
            module.octaveScale = octaveScale;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.octaveScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetOctaveScale(this NoiseModule module, Func<float, float> octaveScaleChanger)
        {
            Debug.Assert(octaveScaleChanger != null, "octaveScaleChanger cannot be null");
            module.octaveScale = octaveScaleChanger(module.octaveScale);
            return module;
        }
        #endregion

        #region PositionAmount
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.positionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoisePositionAmount(this ParticleSystem particleSystem, MinMaxCurve positionAmount)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.positionAmount = positionAmount;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.positionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoisePositionAmount(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> positionAmountChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(positionAmountChanger != null, "positionAmountChanger cannot be null");
            var module = particleSystem.noise;
            module.positionAmount = positionAmountChanger(module.positionAmount);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.positionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetPositionAmount(this NoiseModule module, MinMaxCurve positionAmount)
        {
            module.positionAmount = positionAmount;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.positionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetPositionAmount(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> positionAmountChanger)
        {
            Debug.Assert(positionAmountChanger != null, "positionAmountChanger cannot be null");
            module.positionAmount = positionAmountChanger(module.positionAmount);
            return module;
        }
        #endregion

        #region Quality
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.quality"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseQuality(this ParticleSystem particleSystem, ParticleSystemNoiseQuality quality)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.quality = quality;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.quality"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseQuality(this ParticleSystem particleSystem, Func<ParticleSystemNoiseQuality, ParticleSystemNoiseQuality> qualityChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(qualityChanger != null, "qualityChanger cannot be null");
            var module = particleSystem.noise;
            module.quality = qualityChanger(module.quality);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.quality"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetQuality(this NoiseModule module, ParticleSystemNoiseQuality quality)
        {
            module.quality = quality;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.quality"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetQuality(this NoiseModule module, Func<ParticleSystemNoiseQuality, ParticleSystemNoiseQuality> qualityChanger)
        {
            Debug.Assert(qualityChanger != null, "qualityChanger cannot be null");
            module.quality = qualityChanger(module.quality);
            return module;
        }
        #endregion

        #region Remap
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remap"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemap(this ParticleSystem particleSystem, MinMaxCurve remap)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.remap = remap;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remap"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemap(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> remapChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(remapChanger != null, "remapChanger cannot be null");
            var module = particleSystem.noise;
            module.remap = remapChanger(module.remap);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remap"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemap(this NoiseModule module, MinMaxCurve remap)
        {
            module.remap = remap;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remap"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemap(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> remapChanger)
        {
            Debug.Assert(remapChanger != null, "remapChanger cannot be null");
            module.remap = remapChanger(module.remap);
            return module;
        }
        #endregion

        #region RemapEnabled
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapEnabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapEnabled(this ParticleSystem particleSystem, bool remapEnabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.remapEnabled = remapEnabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapEnabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapEnabled(this ParticleSystem particleSystem, Func<bool, bool> remapEnabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(remapEnabledChanger != null, "remapEnabledChanger cannot be null");
            var module = particleSystem.noise;
            module.remapEnabled = remapEnabledChanger(module.remapEnabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapEnabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapEnabled(this NoiseModule module, bool remapEnabled)
        {
            module.remapEnabled = remapEnabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapEnabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapEnabled(this NoiseModule module, Func<bool, bool> remapEnabledChanger)
        {
            Debug.Assert(remapEnabledChanger != null, "remapEnabledChanger cannot be null");
            module.remapEnabled = remapEnabledChanger(module.remapEnabled);
            return module;
        }
        #endregion

        #region RemapMultiplier
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapMultiplier(this ParticleSystem particleSystem, float remapMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.remapMultiplier = remapMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapMultiplier(this ParticleSystem particleSystem, Func<float, float> remapMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(remapMultiplierChanger != null, "remapMultiplierChanger cannot be null");
            var module = particleSystem.noise;
            module.remapMultiplier = remapMultiplierChanger(module.remapMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapMultiplier(this NoiseModule module, float remapMultiplier)
        {
            module.remapMultiplier = remapMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapMultiplier(this NoiseModule module, Func<float, float> remapMultiplierChanger)
        {
            Debug.Assert(remapMultiplierChanger != null, "remapMultiplierChanger cannot be null");
            module.remapMultiplier = remapMultiplierChanger(module.remapMultiplier);
            return module;
        }
        #endregion

        #region RemapX
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapX(this ParticleSystem particleSystem, MinMaxCurve remapX)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.remapX = remapX;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> remapXChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(remapXChanger != null, "remapXChanger cannot be null");
            var module = particleSystem.noise;
            module.remapX = remapXChanger(module.remapX);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapX(this NoiseModule module, MinMaxCurve remapX)
        {
            module.remapX = remapX;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapX(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> remapXChanger)
        {
            Debug.Assert(remapXChanger != null, "remapXChanger cannot be null");
            module.remapX = remapXChanger(module.remapX);
            return module;
        }
        #endregion

        #region RemapXMultiplier
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapXMultiplier(this ParticleSystem particleSystem, float remapXMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.remapXMultiplier = remapXMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapXMultiplier(this ParticleSystem particleSystem, Func<float, float> remapXMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(remapXMultiplierChanger != null, "remapXMultiplierChanger cannot be null");
            var module = particleSystem.noise;
            module.remapXMultiplier = remapXMultiplierChanger(module.remapXMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapXMultiplier(this NoiseModule module, float remapXMultiplier)
        {
            module.remapXMultiplier = remapXMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapXMultiplier(this NoiseModule module, Func<float, float> remapXMultiplierChanger)
        {
            Debug.Assert(remapXMultiplierChanger != null, "remapXMultiplierChanger cannot be null");
            module.remapXMultiplier = remapXMultiplierChanger(module.remapXMultiplier);
            return module;
        }
        #endregion

        #region RemapY
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapY(this ParticleSystem particleSystem, MinMaxCurve remapY)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.remapY = remapY;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> remapYChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(remapYChanger != null, "remapYChanger cannot be null");
            var module = particleSystem.noise;
            module.remapY = remapYChanger(module.remapY);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapY(this NoiseModule module, MinMaxCurve remapY)
        {
            module.remapY = remapY;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapY(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> remapYChanger)
        {
            Debug.Assert(remapYChanger != null, "remapYChanger cannot be null");
            module.remapY = remapYChanger(module.remapY);
            return module;
        }
        #endregion

        #region RemapYMultiplier
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapYMultiplier(this ParticleSystem particleSystem, float remapYMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.remapYMultiplier = remapYMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapYMultiplier(this ParticleSystem particleSystem, Func<float, float> remapYMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(remapYMultiplierChanger != null, "remapYMultiplierChanger cannot be null");
            var module = particleSystem.noise;
            module.remapYMultiplier = remapYMultiplierChanger(module.remapYMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapYMultiplier(this NoiseModule module, float remapYMultiplier)
        {
            module.remapYMultiplier = remapYMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapYMultiplier(this NoiseModule module, Func<float, float> remapYMultiplierChanger)
        {
            Debug.Assert(remapYMultiplierChanger != null, "remapYMultiplierChanger cannot be null");
            module.remapYMultiplier = remapYMultiplierChanger(module.remapYMultiplier);
            return module;
        }
        #endregion

        #region RemapZ
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapZ(this ParticleSystem particleSystem, MinMaxCurve remapZ)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.remapZ = remapZ;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> remapZChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(remapZChanger != null, "remapZChanger cannot be null");
            var module = particleSystem.noise;
            module.remapZ = remapZChanger(module.remapZ);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapZ(this NoiseModule module, MinMaxCurve remapZ)
        {
            module.remapZ = remapZ;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapZ(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> remapZChanger)
        {
            Debug.Assert(remapZChanger != null, "remapZChanger cannot be null");
            module.remapZ = remapZChanger(module.remapZ);
            return module;
        }
        #endregion

        #region RemapZMultiplier
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapZMultiplier(this ParticleSystem particleSystem, float remapZMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.remapZMultiplier = remapZMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRemapZMultiplier(this ParticleSystem particleSystem, Func<float, float> remapZMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(remapZMultiplierChanger != null, "remapZMultiplierChanger cannot be null");
            var module = particleSystem.noise;
            module.remapZMultiplier = remapZMultiplierChanger(module.remapZMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.remapZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapZMultiplier(this NoiseModule module, float remapZMultiplier)
        {
            module.remapZMultiplier = remapZMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.remapZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRemapZMultiplier(this NoiseModule module, Func<float, float> remapZMultiplierChanger)
        {
            Debug.Assert(remapZMultiplierChanger != null, "remapZMultiplierChanger cannot be null");
            module.remapZMultiplier = remapZMultiplierChanger(module.remapZMultiplier);
            return module;
        }
        #endregion

        #region RotationAmount
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.rotationAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRotationAmount(this ParticleSystem particleSystem, MinMaxCurve rotationAmount)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.rotationAmount = rotationAmount;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.rotationAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseRotationAmount(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> rotationAmountChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rotationAmountChanger != null, "rotationAmountChanger cannot be null");
            var module = particleSystem.noise;
            module.rotationAmount = rotationAmountChanger(module.rotationAmount);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.rotationAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRotationAmount(this NoiseModule module, MinMaxCurve rotationAmount)
        {
            module.rotationAmount = rotationAmount;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.rotationAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetRotationAmount(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> rotationAmountChanger)
        {
            Debug.Assert(rotationAmountChanger != null, "rotationAmountChanger cannot be null");
            module.rotationAmount = rotationAmountChanger(module.rotationAmount);
            return module;
        }
        #endregion

        #region ScrollSpeed
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.scrollSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseScrollSpeed(this ParticleSystem particleSystem, MinMaxCurve scrollSpeed)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.scrollSpeed = scrollSpeed;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.scrollSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseScrollSpeed(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> scrollSpeedChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(scrollSpeedChanger != null, "scrollSpeedChanger cannot be null");
            var module = particleSystem.noise;
            module.scrollSpeed = scrollSpeedChanger(module.scrollSpeed);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.scrollSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetScrollSpeed(this NoiseModule module, MinMaxCurve scrollSpeed)
        {
            module.scrollSpeed = scrollSpeed;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.scrollSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetScrollSpeed(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> scrollSpeedChanger)
        {
            Debug.Assert(scrollSpeedChanger != null, "scrollSpeedChanger cannot be null");
            module.scrollSpeed = scrollSpeedChanger(module.scrollSpeed);
            return module;
        }
        #endregion

        #region ScrollSpeedMultiplier
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.scrollSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseScrollSpeedMultiplier(this ParticleSystem particleSystem, float scrollSpeedMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.scrollSpeedMultiplier = scrollSpeedMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.scrollSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseScrollSpeedMultiplier(this ParticleSystem particleSystem, Func<float, float> scrollSpeedMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(scrollSpeedMultiplierChanger != null, "scrollSpeedMultiplierChanger cannot be null");
            var module = particleSystem.noise;
            module.scrollSpeedMultiplier = scrollSpeedMultiplierChanger(module.scrollSpeedMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.scrollSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetScrollSpeedMultiplier(this NoiseModule module, float scrollSpeedMultiplier)
        {
            module.scrollSpeedMultiplier = scrollSpeedMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.scrollSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetScrollSpeedMultiplier(this NoiseModule module, Func<float, float> scrollSpeedMultiplierChanger)
        {
            Debug.Assert(scrollSpeedMultiplierChanger != null, "scrollSpeedMultiplierChanger cannot be null");
            module.scrollSpeedMultiplier = scrollSpeedMultiplierChanger(module.scrollSpeedMultiplier);
            return module;
        }
        #endregion

        #region SeparateAxes
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseSeparateAxes(this ParticleSystem particleSystem, bool separateAxes)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.separateAxes = separateAxes;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseSeparateAxes(this ParticleSystem particleSystem, Func<bool, bool> separateAxesChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(separateAxesChanger != null, "separateAxesChanger cannot be null");
            var module = particleSystem.noise;
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetSeparateAxes(this NoiseModule module, bool separateAxes)
        {
            module.separateAxes = separateAxes;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetSeparateAxes(this NoiseModule module, Func<bool, bool> separateAxesChanger)
        {
            Debug.Assert(separateAxesChanger != null, "separateAxesChanger cannot be null");
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return module;
        }
        #endregion

        #region SizeAmount
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.sizeAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseSizeAmount(this ParticleSystem particleSystem, MinMaxCurve sizeAmount)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.sizeAmount = sizeAmount;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.sizeAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseSizeAmount(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> sizeAmountChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(sizeAmountChanger != null, "sizeAmountChanger cannot be null");
            var module = particleSystem.noise;
            module.sizeAmount = sizeAmountChanger(module.sizeAmount);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.sizeAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetSizeAmount(this NoiseModule module, MinMaxCurve sizeAmount)
        {
            module.sizeAmount = sizeAmount;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.sizeAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetSizeAmount(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> sizeAmountChanger)
        {
            Debug.Assert(sizeAmountChanger != null, "sizeAmountChanger cannot be null");
            module.sizeAmount = sizeAmountChanger(module.sizeAmount);
            return module;
        }
        #endregion

        #region Strength
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strength"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrength(this ParticleSystem particleSystem, MinMaxCurve strength)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.strength = strength;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strength"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrength(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> strengthChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(strengthChanger != null, "strengthChanger cannot be null");
            var module = particleSystem.noise;
            module.strength = strengthChanger(module.strength);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strength"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrength(this NoiseModule module, MinMaxCurve strength)
        {
            module.strength = strength;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strength"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrength(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> strengthChanger)
        {
            Debug.Assert(strengthChanger != null, "strengthChanger cannot be null");
            module.strength = strengthChanger(module.strength);
            return module;
        }
        #endregion

        #region StrengthMultiplier
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthMultiplier(this ParticleSystem particleSystem, float strengthMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.strengthMultiplier = strengthMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthMultiplier(this ParticleSystem particleSystem, Func<float, float> strengthMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(strengthMultiplierChanger != null, "strengthMultiplierChanger cannot be null");
            var module = particleSystem.noise;
            module.strengthMultiplier = strengthMultiplierChanger(module.strengthMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthMultiplier(this NoiseModule module, float strengthMultiplier)
        {
            module.strengthMultiplier = strengthMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthMultiplier(this NoiseModule module, Func<float, float> strengthMultiplierChanger)
        {
            Debug.Assert(strengthMultiplierChanger != null, "strengthMultiplierChanger cannot be null");
            module.strengthMultiplier = strengthMultiplierChanger(module.strengthMultiplier);
            return module;
        }
        #endregion

        #region StrengthX
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthX(this ParticleSystem particleSystem, MinMaxCurve strengthX)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.strengthX = strengthX;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> strengthXChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(strengthXChanger != null, "strengthXChanger cannot be null");
            var module = particleSystem.noise;
            module.strengthX = strengthXChanger(module.strengthX);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthX(this NoiseModule module, MinMaxCurve strengthX)
        {
            module.strengthX = strengthX;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthX(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> strengthXChanger)
        {
            Debug.Assert(strengthXChanger != null, "strengthXChanger cannot be null");
            module.strengthX = strengthXChanger(module.strengthX);
            return module;
        }
        #endregion

        #region StrengthXMultiplier
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthXMultiplier(this ParticleSystem particleSystem, float strengthXMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.strengthXMultiplier = strengthXMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthXMultiplier(this ParticleSystem particleSystem, Func<float, float> strengthXMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(strengthXMultiplierChanger != null, "strengthXMultiplierChanger cannot be null");
            var module = particleSystem.noise;
            module.strengthXMultiplier = strengthXMultiplierChanger(module.strengthXMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthXMultiplier(this NoiseModule module, float strengthXMultiplier)
        {
            module.strengthXMultiplier = strengthXMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthXMultiplier(this NoiseModule module, Func<float, float> strengthXMultiplierChanger)
        {
            Debug.Assert(strengthXMultiplierChanger != null, "strengthXMultiplierChanger cannot be null");
            module.strengthXMultiplier = strengthXMultiplierChanger(module.strengthXMultiplier);
            return module;
        }
        #endregion

        #region StrengthY
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthY(this ParticleSystem particleSystem, MinMaxCurve strengthY)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.strengthY = strengthY;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> strengthYChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(strengthYChanger != null, "strengthYChanger cannot be null");
            var module = particleSystem.noise;
            module.strengthY = strengthYChanger(module.strengthY);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthY(this NoiseModule module, MinMaxCurve strengthY)
        {
            module.strengthY = strengthY;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthY(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> strengthYChanger)
        {
            Debug.Assert(strengthYChanger != null, "strengthYChanger cannot be null");
            module.strengthY = strengthYChanger(module.strengthY);
            return module;
        }
        #endregion

        #region StrengthYMultiplier
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthYMultiplier(this ParticleSystem particleSystem, float strengthYMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.strengthYMultiplier = strengthYMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthYMultiplier(this ParticleSystem particleSystem, Func<float, float> strengthYMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(strengthYMultiplierChanger != null, "strengthYMultiplierChanger cannot be null");
            var module = particleSystem.noise;
            module.strengthYMultiplier = strengthYMultiplierChanger(module.strengthYMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthYMultiplier(this NoiseModule module, float strengthYMultiplier)
        {
            module.strengthYMultiplier = strengthYMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthYMultiplier(this NoiseModule module, Func<float, float> strengthYMultiplierChanger)
        {
            Debug.Assert(strengthYMultiplierChanger != null, "strengthYMultiplierChanger cannot be null");
            module.strengthYMultiplier = strengthYMultiplierChanger(module.strengthYMultiplier);
            return module;
        }
        #endregion

        #region StrengthZ
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthZ(this ParticleSystem particleSystem, MinMaxCurve strengthZ)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.strengthZ = strengthZ;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> strengthZChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(strengthZChanger != null, "strengthZChanger cannot be null");
            var module = particleSystem.noise;
            module.strengthZ = strengthZChanger(module.strengthZ);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthZ(this NoiseModule module, MinMaxCurve strengthZ)
        {
            module.strengthZ = strengthZ;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthZ(this NoiseModule module, Func<MinMaxCurve, MinMaxCurve> strengthZChanger)
        {
            Debug.Assert(strengthZChanger != null, "strengthZChanger cannot be null");
            module.strengthZ = strengthZChanger(module.strengthZ);
            return module;
        }
        #endregion

        #region StrengthZMultiplier
        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthZMultiplier(this ParticleSystem particleSystem, float strengthZMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.noise;
            module.strengthZMultiplier = strengthZMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetNoiseStrengthZMultiplier(this ParticleSystem particleSystem, Func<float, float> strengthZMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(strengthZMultiplierChanger != null, "strengthZMultiplierChanger cannot be null");
            var module = particleSystem.noise;
            module.strengthZMultiplier = strengthZMultiplierChanger(module.strengthZMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="NoiseModule.strengthZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthZMultiplier(this NoiseModule module, float strengthZMultiplier)
        {
            module.strengthZMultiplier = strengthZMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="NoiseModule.strengthZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static NoiseModule SetStrengthZMultiplier(this NoiseModule module, Func<float, float> strengthZMultiplierChanger)
        {
            Debug.Assert(strengthZMultiplierChanger != null, "strengthZMultiplierChanger cannot be null");
            module.strengthZMultiplier = strengthZMultiplierChanger(module.strengthZMultiplier);
            return module;
        }
        #endregion
#endif
    }
}
