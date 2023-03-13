using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class LightsModuleExtension
    {
#if UNITY_2021_3_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditLights(this ParticleSystem particleSystem, Action<LightsModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.lights);
            return particleSystem;
        }

        #region Enabled
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetEnabled(this LightsModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetEnabled(this LightsModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Ratio
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsRatio(this ParticleSystem particleSystem, float ratio)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.ratio = ratio;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsRatio(this ParticleSystem particleSystem, Func<float, float> ratioChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.ratio = ratioChanger(module.ratio);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetRatio(this LightsModule module, float ratio)
        {
            module.ratio = ratio;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetRatio(this LightsModule module, Func<float, float> ratioChanger)
        {
            module.ratio = ratioChanger(module.ratio);
            return module;
        }
        #endregion

        #region UseRandomDistribution
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsUseRandomDistribution(this ParticleSystem particleSystem, bool useRandomDistribution)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.useRandomDistribution = useRandomDistribution;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsUseRandomDistribution(this ParticleSystem particleSystem, Func<bool, bool> useRandomDistributionChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.useRandomDistribution = useRandomDistributionChanger(module.useRandomDistribution);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetUseRandomDistribution(this LightsModule module, bool useRandomDistribution)
        {
            module.useRandomDistribution = useRandomDistribution;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetUseRandomDistribution(this LightsModule module, Func<bool, bool> useRandomDistributionChanger)
        {
            module.useRandomDistribution = useRandomDistributionChanger(module.useRandomDistribution);
            return module;
        }
        #endregion

        #region Light
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsLight(this ParticleSystem particleSystem, Light light)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.light = light;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsLight(this ParticleSystem particleSystem, Func<Light, Light> lightChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.light = lightChanger(module.light);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetLight(this LightsModule module, Light light)
        {
            module.light = light;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetLight(this LightsModule module, Func<Light, Light> lightChanger)
        {
            module.light = lightChanger(module.light);
            return module;
        }
        #endregion

        #region UseParticleColor
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsUseParticleColor(this ParticleSystem particleSystem, bool useParticleColor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.useParticleColor = useParticleColor;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsUseParticleColor(this ParticleSystem particleSystem, Func<bool, bool> useParticleColorChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.useParticleColor = useParticleColorChanger(module.useParticleColor);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetUseParticleColor(this LightsModule module, bool useParticleColor)
        {
            module.useParticleColor = useParticleColor;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetUseParticleColor(this LightsModule module, Func<bool, bool> useParticleColorChanger)
        {
            module.useParticleColor = useParticleColorChanger(module.useParticleColor);
            return module;
        }
        #endregion

        #region SizeAffectsRange
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsSizeAffectsRange(this ParticleSystem particleSystem, bool sizeAffectsRange)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.sizeAffectsRange = sizeAffectsRange;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsSizeAffectsRange(this ParticleSystem particleSystem, Func<bool, bool> sizeAffectsRangeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.sizeAffectsRange = sizeAffectsRangeChanger(module.sizeAffectsRange);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetSizeAffectsRange(this LightsModule module, bool sizeAffectsRange)
        {
            module.sizeAffectsRange = sizeAffectsRange;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetSizeAffectsRange(this LightsModule module, Func<bool, bool> sizeAffectsRangeChanger)
        {
            module.sizeAffectsRange = sizeAffectsRangeChanger(module.sizeAffectsRange);
            return module;
        }
        #endregion

        #region AlphaAffectsIntensity
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsAlphaAffectsIntensity(this ParticleSystem particleSystem, bool alphaAffectsIntensity)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.alphaAffectsIntensity = alphaAffectsIntensity;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsAlphaAffectsIntensity(this ParticleSystem particleSystem, Func<bool, bool> alphaAffectsIntensityChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.alphaAffectsIntensity = alphaAffectsIntensityChanger(module.alphaAffectsIntensity);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetAlphaAffectsIntensity(this LightsModule module, bool alphaAffectsIntensity)
        {
            module.alphaAffectsIntensity = alphaAffectsIntensity;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetAlphaAffectsIntensity(this LightsModule module, Func<bool, bool> alphaAffectsIntensityChanger)
        {
            module.alphaAffectsIntensity = alphaAffectsIntensityChanger(module.alphaAffectsIntensity);
            return module;
        }
        #endregion

        #region Range
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsRange(this ParticleSystem particleSystem, MinMaxCurve range)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.range = range;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsRange(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> rangeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.range = rangeChanger(module.range);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetRange(this LightsModule module, MinMaxCurve range)
        {
            module.range = range;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetRange(this LightsModule module, Func<MinMaxCurve, MinMaxCurve> rangeChanger)
        {
            module.range = rangeChanger(module.range);
            return module;
        }
        #endregion

        #region RangeMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsRangeMultiplier(this ParticleSystem particleSystem, float rangeMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.rangeMultiplier = rangeMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsRangeMultiplier(this ParticleSystem particleSystem, Func<float, float> rangeMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.rangeMultiplier = rangeMultiplierChanger(module.rangeMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetRangeMultiplier(this LightsModule module, float rangeMultiplier)
        {
            module.rangeMultiplier = rangeMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetRangeMultiplier(this LightsModule module, Func<float, float> rangeMultiplierChanger)
        {
            module.rangeMultiplier = rangeMultiplierChanger(module.rangeMultiplier);
            return module;
        }
        #endregion

        #region Intensity
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsIntensity(this ParticleSystem particleSystem, MinMaxCurve intensity)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.intensity = intensity;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsIntensity(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> intensityChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.intensity = intensityChanger(module.intensity);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetIntensity(this LightsModule module, MinMaxCurve intensity)
        {
            module.intensity = intensity;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetIntensity(this LightsModule module, Func<MinMaxCurve, MinMaxCurve> intensityChanger)
        {
            module.intensity = intensityChanger(module.intensity);
            return module;
        }
        #endregion

        #region IntensityMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsIntensityMultiplier(this ParticleSystem particleSystem, float intensityMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.intensityMultiplier = intensityMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsIntensityMultiplier(this ParticleSystem particleSystem, Func<float, float> intensityMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.intensityMultiplier = intensityMultiplierChanger(module.intensityMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetIntensityMultiplier(this LightsModule module, float intensityMultiplier)
        {
            module.intensityMultiplier = intensityMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetIntensityMultiplier(this LightsModule module, Func<float, float> intensityMultiplierChanger)
        {
            module.intensityMultiplier = intensityMultiplierChanger(module.intensityMultiplier);
            return module;
        }
        #endregion

        #region MaxLights
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsMaxLights(this ParticleSystem particleSystem, int maxLights)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.maxLights = maxLights;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLightsMaxLights(this ParticleSystem particleSystem, Func<int, int> maxLightsChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.lights;
            module.maxLights = maxLightsChanger(module.maxLights);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetMaxLights(this LightsModule module, int maxLights)
        {
            module.maxLights = maxLights;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetMaxLights(this LightsModule module, Func<int, int> maxLightsChanger)
        {
            module.maxLights = maxLightsChanger(module.maxLights);
            return module;
        }
        #endregion
#endif
    }
}
