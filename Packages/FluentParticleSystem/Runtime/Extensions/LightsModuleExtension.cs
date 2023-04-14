using System;
using System.Runtime.CompilerServices;
using UnityEngine;

using static UnityEngine.ParticleSystem;

#if UNITY_2020_2_OR_NEWER
using System.Diagnostics.CodeAnalysis;
#endif

namespace OUCC.FluentParticleSystem
{
    public static class LightsModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.lights"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem EditLights(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Action<LightsModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.lights);
            return particleSystem;
        }

        #region AlphaAffectsIntensity
        /// <summary>
        /// Assign a value to <see cref="LightsModule.alphaAffectsIntensity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsAlphaAffectsIntensity(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool alphaAffectsIntensity)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lights;
            module.alphaAffectsIntensity = alphaAffectsIntensity;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.alphaAffectsIntensity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsAlphaAffectsIntensity(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> alphaAffectsIntensityChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(alphaAffectsIntensityChanger != null, "alphaAffectsIntensityChanger cannot be null");
            var module = particleSystem.lights;
            module.alphaAffectsIntensity = alphaAffectsIntensityChanger(module.alphaAffectsIntensity);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LightsModule.alphaAffectsIntensity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetAlphaAffectsIntensity(this LightsModule module, bool alphaAffectsIntensity)
        {
            module.alphaAffectsIntensity = alphaAffectsIntensity;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.alphaAffectsIntensity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetAlphaAffectsIntensity(this LightsModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> alphaAffectsIntensityChanger)
        {
            Debug.Assert(alphaAffectsIntensityChanger != null, "alphaAffectsIntensityChanger cannot be null");
            module.alphaAffectsIntensity = alphaAffectsIntensityChanger(module.alphaAffectsIntensity);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="LightsModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsEnabled(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lights;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsEnabled(
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
            var module = particleSystem.lights;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LightsModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetEnabled(this LightsModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetEnabled(this LightsModule module,
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

        #region Intensity
        /// <summary>
        /// Assign a value to <see cref="LightsModule.intensity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsIntensity(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve intensity)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lights;
            module.intensity = intensity;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.intensity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsIntensity(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<MinMaxCurve, MinMaxCurve> intensityChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(intensityChanger != null, "intensityChanger cannot be null");
            var module = particleSystem.lights;
            module.intensity = intensityChanger(module.intensity);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LightsModule.intensity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetIntensity(this LightsModule module, MinMaxCurve intensity)
        {
            module.intensity = intensity;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.intensity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetIntensity(this LightsModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<MinMaxCurve, MinMaxCurve> intensityChanger)
        {
            Debug.Assert(intensityChanger != null, "intensityChanger cannot be null");
            module.intensity = intensityChanger(module.intensity);
            return module;
        }
        #endregion

        #region IntensityMultiplier
        /// <summary>
        /// Assign a value to <see cref="LightsModule.intensityMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsIntensityMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float intensityMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lights;
            module.intensityMultiplier = intensityMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.intensityMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsIntensityMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> intensityMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(intensityMultiplierChanger != null, "intensityMultiplierChanger cannot be null");
            var module = particleSystem.lights;
            module.intensityMultiplier = intensityMultiplierChanger(module.intensityMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LightsModule.intensityMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetIntensityMultiplier(this LightsModule module, float intensityMultiplier)
        {
            module.intensityMultiplier = intensityMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.intensityMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetIntensityMultiplier(this LightsModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> intensityMultiplierChanger)
        {
            Debug.Assert(intensityMultiplierChanger != null, "intensityMultiplierChanger cannot be null");
            module.intensityMultiplier = intensityMultiplierChanger(module.intensityMultiplier);
            return module;
        }
        #endregion

        #region Light
        /// <summary>
        /// Assign a value to <see cref="LightsModule.light"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsLight(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, Light light)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lights;
            module.light = light;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.light"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsLight(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<Light, Light> lightChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(lightChanger != null, "lightChanger cannot be null");
            var module = particleSystem.lights;
            module.light = lightChanger(module.light);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LightsModule.light"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetLight(this LightsModule module, Light light)
        {
            module.light = light;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.light"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetLight(this LightsModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<Light, Light> lightChanger)
        {
            Debug.Assert(lightChanger != null, "lightChanger cannot be null");
            module.light = lightChanger(module.light);
            return module;
        }
        #endregion

        #region MaxLights
        /// <summary>
        /// Assign a value to <see cref="LightsModule.maxLights"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsMaxLights(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, int maxLights)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lights;
            module.maxLights = maxLights;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.maxLights"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsMaxLights(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<int, int> maxLightsChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(maxLightsChanger != null, "maxLightsChanger cannot be null");
            var module = particleSystem.lights;
            module.maxLights = maxLightsChanger(module.maxLights);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LightsModule.maxLights"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetMaxLights(this LightsModule module, int maxLights)
        {
            module.maxLights = maxLights;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.maxLights"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetMaxLights(this LightsModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<int, int> maxLightsChanger)
        {
            Debug.Assert(maxLightsChanger != null, "maxLightsChanger cannot be null");
            module.maxLights = maxLightsChanger(module.maxLights);
            return module;
        }
        #endregion

        #region Range
        /// <summary>
        /// Assign a value to <see cref="LightsModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsRange(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve range)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lights;
            module.range = range;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsRange(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<MinMaxCurve, MinMaxCurve> rangeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rangeChanger != null, "rangeChanger cannot be null");
            var module = particleSystem.lights;
            module.range = rangeChanger(module.range);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LightsModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetRange(this LightsModule module, MinMaxCurve range)
        {
            module.range = range;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetRange(this LightsModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<MinMaxCurve, MinMaxCurve> rangeChanger)
        {
            Debug.Assert(rangeChanger != null, "rangeChanger cannot be null");
            module.range = rangeChanger(module.range);
            return module;
        }
        #endregion

        #region RangeMultiplier
        /// <summary>
        /// Assign a value to <see cref="LightsModule.rangeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsRangeMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float rangeMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lights;
            module.rangeMultiplier = rangeMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.rangeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsRangeMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> rangeMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rangeMultiplierChanger != null, "rangeMultiplierChanger cannot be null");
            var module = particleSystem.lights;
            module.rangeMultiplier = rangeMultiplierChanger(module.rangeMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LightsModule.rangeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetRangeMultiplier(this LightsModule module, float rangeMultiplier)
        {
            module.rangeMultiplier = rangeMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.rangeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetRangeMultiplier(this LightsModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> rangeMultiplierChanger)
        {
            Debug.Assert(rangeMultiplierChanger != null, "rangeMultiplierChanger cannot be null");
            module.rangeMultiplier = rangeMultiplierChanger(module.rangeMultiplier);
            return module;
        }
        #endregion

        #region Ratio
        /// <summary>
        /// Assign a value to <see cref="LightsModule.ratio"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsRatio(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float ratio)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lights;
            module.ratio = ratio;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.ratio"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsRatio(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> ratioChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(ratioChanger != null, "ratioChanger cannot be null");
            var module = particleSystem.lights;
            module.ratio = ratioChanger(module.ratio);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LightsModule.ratio"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetRatio(this LightsModule module, float ratio)
        {
            module.ratio = ratio;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.ratio"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetRatio(this LightsModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> ratioChanger)
        {
            Debug.Assert(ratioChanger != null, "ratioChanger cannot be null");
            module.ratio = ratioChanger(module.ratio);
            return module;
        }
        #endregion

        #region SizeAffectsRange
        /// <summary>
        /// Assign a value to <see cref="LightsModule.sizeAffectsRange"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsSizeAffectsRange(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool sizeAffectsRange)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lights;
            module.sizeAffectsRange = sizeAffectsRange;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.sizeAffectsRange"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsSizeAffectsRange(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> sizeAffectsRangeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(sizeAffectsRangeChanger != null, "sizeAffectsRangeChanger cannot be null");
            var module = particleSystem.lights;
            module.sizeAffectsRange = sizeAffectsRangeChanger(module.sizeAffectsRange);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LightsModule.sizeAffectsRange"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetSizeAffectsRange(this LightsModule module, bool sizeAffectsRange)
        {
            module.sizeAffectsRange = sizeAffectsRange;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.sizeAffectsRange"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetSizeAffectsRange(this LightsModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> sizeAffectsRangeChanger)
        {
            Debug.Assert(sizeAffectsRangeChanger != null, "sizeAffectsRangeChanger cannot be null");
            module.sizeAffectsRange = sizeAffectsRangeChanger(module.sizeAffectsRange);
            return module;
        }
        #endregion

        #region UseParticleColor
        /// <summary>
        /// Assign a value to <see cref="LightsModule.useParticleColor"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsUseParticleColor(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool useParticleColor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lights;
            module.useParticleColor = useParticleColor;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.useParticleColor"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsUseParticleColor(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> useParticleColorChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(useParticleColorChanger != null, "useParticleColorChanger cannot be null");
            var module = particleSystem.lights;
            module.useParticleColor = useParticleColorChanger(module.useParticleColor);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LightsModule.useParticleColor"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetUseParticleColor(this LightsModule module, bool useParticleColor)
        {
            module.useParticleColor = useParticleColor;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.useParticleColor"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetUseParticleColor(this LightsModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> useParticleColorChanger)
        {
            Debug.Assert(useParticleColorChanger != null, "useParticleColorChanger cannot be null");
            module.useParticleColor = useParticleColorChanger(module.useParticleColor);
            return module;
        }
        #endregion

        #region UseRandomDistribution
        /// <summary>
        /// Assign a value to <see cref="LightsModule.useRandomDistribution"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsUseRandomDistribution(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool useRandomDistribution)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.lights;
            module.useRandomDistribution = useRandomDistribution;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.useRandomDistribution"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetLightsUseRandomDistribution(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> useRandomDistributionChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(useRandomDistributionChanger != null, "useRandomDistributionChanger cannot be null");
            var module = particleSystem.lights;
            module.useRandomDistribution = useRandomDistributionChanger(module.useRandomDistribution);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="LightsModule.useRandomDistribution"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetUseRandomDistribution(this LightsModule module, bool useRandomDistribution)
        {
            module.useRandomDistribution = useRandomDistribution;
            return module;
        }

        /// <summary>
        /// Edit <see cref="LightsModule.useRandomDistribution"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LightsModule SetUseRandomDistribution(this LightsModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> useRandomDistributionChanger)
        {
            Debug.Assert(useRandomDistributionChanger != null, "useRandomDistributionChanger cannot be null");
            module.useRandomDistribution = useRandomDistributionChanger(module.useRandomDistribution);
            return module;
        }
        #endregion
#endif
    }
}
