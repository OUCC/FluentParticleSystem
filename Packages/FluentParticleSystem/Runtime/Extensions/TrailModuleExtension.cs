using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class TrailModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.trails"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditTrails(this ParticleSystem particleSystem, Action<TrailModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.trails);
            return particleSystem;
        }

        #region AttachRibbonsToTransform
        /// <summary>
        /// Assign a value to <see cref="TrailModule.attachRibbonsToTransform"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsAttachRibbonsToTransform(this ParticleSystem particleSystem, bool attachRibbonsToTransform)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.attachRibbonsToTransform = attachRibbonsToTransform;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.attachRibbonsToTransform"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsAttachRibbonsToTransform(this ParticleSystem particleSystem, Func<bool, bool> attachRibbonsToTransformChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.attachRibbonsToTransform = attachRibbonsToTransformChanger(module.attachRibbonsToTransform);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.attachRibbonsToTransform"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetAttachRibbonsToTransform(this TrailModule module, bool attachRibbonsToTransform)
        {
            module.attachRibbonsToTransform = attachRibbonsToTransform;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.attachRibbonsToTransform"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetAttachRibbonsToTransform(this TrailModule module, Func<bool, bool> attachRibbonsToTransformChanger)
        {
            module.attachRibbonsToTransform = attachRibbonsToTransformChanger(module.attachRibbonsToTransform);
            return module;
        }
        #endregion

        #region ColorOverLifetime
        /// <summary>
        /// Assign a value to <see cref="TrailModule.colorOverLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsColorOverLifetime(this ParticleSystem particleSystem, MinMaxGradient colorOverLifetime)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.colorOverLifetime = colorOverLifetime;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.colorOverLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsColorOverLifetime(this ParticleSystem particleSystem, Func<MinMaxGradient, MinMaxGradient> colorOverLifetimeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.colorOverLifetime = colorOverLifetimeChanger(module.colorOverLifetime);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.colorOverLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetColorOverLifetime(this TrailModule module, MinMaxGradient colorOverLifetime)
        {
            module.colorOverLifetime = colorOverLifetime;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.colorOverLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetColorOverLifetime(this TrailModule module, Func<MinMaxGradient, MinMaxGradient> colorOverLifetimeChanger)
        {
            module.colorOverLifetime = colorOverLifetimeChanger(module.colorOverLifetime);
            return module;
        }
        #endregion

        #region ColorOverTrail
        /// <summary>
        /// Assign a value to <see cref="TrailModule.colorOverTrail"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsColorOverTrail(this ParticleSystem particleSystem, MinMaxGradient colorOverTrail)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.colorOverTrail = colorOverTrail;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.colorOverTrail"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsColorOverTrail(this ParticleSystem particleSystem, Func<MinMaxGradient, MinMaxGradient> colorOverTrailChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.colorOverTrail = colorOverTrailChanger(module.colorOverTrail);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.colorOverTrail"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetColorOverTrail(this TrailModule module, MinMaxGradient colorOverTrail)
        {
            module.colorOverTrail = colorOverTrail;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.colorOverTrail"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetColorOverTrail(this TrailModule module, Func<MinMaxGradient, MinMaxGradient> colorOverTrailChanger)
        {
            module.colorOverTrail = colorOverTrailChanger(module.colorOverTrail);
            return module;
        }
        #endregion

        #region DieWithParticles
        /// <summary>
        /// Assign a value to <see cref="TrailModule.dieWithParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsDieWithParticles(this ParticleSystem particleSystem, bool dieWithParticles)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.dieWithParticles = dieWithParticles;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.dieWithParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsDieWithParticles(this ParticleSystem particleSystem, Func<bool, bool> dieWithParticlesChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.dieWithParticles = dieWithParticlesChanger(module.dieWithParticles);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.dieWithParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetDieWithParticles(this TrailModule module, bool dieWithParticles)
        {
            module.dieWithParticles = dieWithParticles;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.dieWithParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetDieWithParticles(this TrailModule module, Func<bool, bool> dieWithParticlesChanger)
        {
            module.dieWithParticles = dieWithParticlesChanger(module.dieWithParticles);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="TrailModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetEnabled(this TrailModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetEnabled(this TrailModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region GenerateLightingData
        /// <summary>
        /// Assign a value to <see cref="TrailModule.generateLightingData"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsGenerateLightingData(this ParticleSystem particleSystem, bool generateLightingData)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.generateLightingData = generateLightingData;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.generateLightingData"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsGenerateLightingData(this ParticleSystem particleSystem, Func<bool, bool> generateLightingDataChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.generateLightingData = generateLightingDataChanger(module.generateLightingData);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.generateLightingData"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetGenerateLightingData(this TrailModule module, bool generateLightingData)
        {
            module.generateLightingData = generateLightingData;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.generateLightingData"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetGenerateLightingData(this TrailModule module, Func<bool, bool> generateLightingDataChanger)
        {
            module.generateLightingData = generateLightingDataChanger(module.generateLightingData);
            return module;
        }
        #endregion

        #region InheritParticleColor
        /// <summary>
        /// Assign a value to <see cref="TrailModule.inheritParticleColor"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsInheritParticleColor(this ParticleSystem particleSystem, bool inheritParticleColor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.inheritParticleColor = inheritParticleColor;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.inheritParticleColor"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsInheritParticleColor(this ParticleSystem particleSystem, Func<bool, bool> inheritParticleColorChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.inheritParticleColor = inheritParticleColorChanger(module.inheritParticleColor);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.inheritParticleColor"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetInheritParticleColor(this TrailModule module, bool inheritParticleColor)
        {
            module.inheritParticleColor = inheritParticleColor;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.inheritParticleColor"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetInheritParticleColor(this TrailModule module, Func<bool, bool> inheritParticleColorChanger)
        {
            module.inheritParticleColor = inheritParticleColorChanger(module.inheritParticleColor);
            return module;
        }
        #endregion

        #region Lifetime
        /// <summary>
        /// Assign a value to <see cref="TrailModule.lifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsLifetime(this ParticleSystem particleSystem, MinMaxCurve lifetime)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.lifetime = lifetime;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.lifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsLifetime(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> lifetimeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.lifetime = lifetimeChanger(module.lifetime);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.lifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetLifetime(this TrailModule module, MinMaxCurve lifetime)
        {
            module.lifetime = lifetime;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.lifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetLifetime(this TrailModule module, Func<MinMaxCurve, MinMaxCurve> lifetimeChanger)
        {
            module.lifetime = lifetimeChanger(module.lifetime);
            return module;
        }
        #endregion

        #region LifetimeMultiplier
        /// <summary>
        /// Assign a value to <see cref="TrailModule.lifetimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsLifetimeMultiplier(this ParticleSystem particleSystem, float lifetimeMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.lifetimeMultiplier = lifetimeMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.lifetimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsLifetimeMultiplier(this ParticleSystem particleSystem, Func<float, float> lifetimeMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.lifetimeMultiplier = lifetimeMultiplierChanger(module.lifetimeMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.lifetimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetLifetimeMultiplier(this TrailModule module, float lifetimeMultiplier)
        {
            module.lifetimeMultiplier = lifetimeMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.lifetimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetLifetimeMultiplier(this TrailModule module, Func<float, float> lifetimeMultiplierChanger)
        {
            module.lifetimeMultiplier = lifetimeMultiplierChanger(module.lifetimeMultiplier);
            return module;
        }
        #endregion

        #region MinVertexDistance
        /// <summary>
        /// Assign a value to <see cref="TrailModule.minVertexDistance"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsMinVertexDistance(this ParticleSystem particleSystem, float minVertexDistance)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.minVertexDistance = minVertexDistance;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.minVertexDistance"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsMinVertexDistance(this ParticleSystem particleSystem, Func<float, float> minVertexDistanceChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.minVertexDistance = minVertexDistanceChanger(module.minVertexDistance);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.minVertexDistance"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetMinVertexDistance(this TrailModule module, float minVertexDistance)
        {
            module.minVertexDistance = minVertexDistance;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.minVertexDistance"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetMinVertexDistance(this TrailModule module, Func<float, float> minVertexDistanceChanger)
        {
            module.minVertexDistance = minVertexDistanceChanger(module.minVertexDistance);
            return module;
        }
        #endregion

        #region Mode
        /// <summary>
        /// Assign a value to <see cref="TrailModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsMode(this ParticleSystem particleSystem, ParticleSystemTrailMode mode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.mode = mode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsMode(this ParticleSystem particleSystem, Func<ParticleSystemTrailMode, ParticleSystemTrailMode> modeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.mode = modeChanger(module.mode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetMode(this TrailModule module, ParticleSystemTrailMode mode)
        {
            module.mode = mode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetMode(this TrailModule module, Func<ParticleSystemTrailMode, ParticleSystemTrailMode> modeChanger)
        {
            module.mode = modeChanger(module.mode);
            return module;
        }
        #endregion

        #region Ratio
        /// <summary>
        /// Assign a value to <see cref="TrailModule.ratio"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsRatio(this ParticleSystem particleSystem, float ratio)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.ratio = ratio;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.ratio"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsRatio(this ParticleSystem particleSystem, Func<float, float> ratioChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.ratio = ratioChanger(module.ratio);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.ratio"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetRatio(this TrailModule module, float ratio)
        {
            module.ratio = ratio;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.ratio"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetRatio(this TrailModule module, Func<float, float> ratioChanger)
        {
            module.ratio = ratioChanger(module.ratio);
            return module;
        }
        #endregion

        #region RibbonCount
        /// <summary>
        /// Assign a value to <see cref="TrailModule.ribbonCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsRibbonCount(this ParticleSystem particleSystem, int ribbonCount)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.ribbonCount = ribbonCount;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.ribbonCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsRibbonCount(this ParticleSystem particleSystem, Func<int, int> ribbonCountChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.ribbonCount = ribbonCountChanger(module.ribbonCount);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.ribbonCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetRibbonCount(this TrailModule module, int ribbonCount)
        {
            module.ribbonCount = ribbonCount;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.ribbonCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetRibbonCount(this TrailModule module, Func<int, int> ribbonCountChanger)
        {
            module.ribbonCount = ribbonCountChanger(module.ribbonCount);
            return module;
        }
        #endregion

        #region ShadowBias
        /// <summary>
        /// Assign a value to <see cref="TrailModule.shadowBias"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsShadowBias(this ParticleSystem particleSystem, float shadowBias)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.shadowBias = shadowBias;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.shadowBias"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsShadowBias(this ParticleSystem particleSystem, Func<float, float> shadowBiasChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.shadowBias = shadowBiasChanger(module.shadowBias);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.shadowBias"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetShadowBias(this TrailModule module, float shadowBias)
        {
            module.shadowBias = shadowBias;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.shadowBias"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetShadowBias(this TrailModule module, Func<float, float> shadowBiasChanger)
        {
            module.shadowBias = shadowBiasChanger(module.shadowBias);
            return module;
        }
        #endregion

        #region SizeAffectsLifetime
        /// <summary>
        /// Assign a value to <see cref="TrailModule.sizeAffectsLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsSizeAffectsLifetime(this ParticleSystem particleSystem, bool sizeAffectsLifetime)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.sizeAffectsLifetime = sizeAffectsLifetime;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.sizeAffectsLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsSizeAffectsLifetime(this ParticleSystem particleSystem, Func<bool, bool> sizeAffectsLifetimeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.sizeAffectsLifetime = sizeAffectsLifetimeChanger(module.sizeAffectsLifetime);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.sizeAffectsLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetSizeAffectsLifetime(this TrailModule module, bool sizeAffectsLifetime)
        {
            module.sizeAffectsLifetime = sizeAffectsLifetime;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.sizeAffectsLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetSizeAffectsLifetime(this TrailModule module, Func<bool, bool> sizeAffectsLifetimeChanger)
        {
            module.sizeAffectsLifetime = sizeAffectsLifetimeChanger(module.sizeAffectsLifetime);
            return module;
        }
        #endregion

        #region SizeAffectsWidth
        /// <summary>
        /// Assign a value to <see cref="TrailModule.sizeAffectsWidth"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsSizeAffectsWidth(this ParticleSystem particleSystem, bool sizeAffectsWidth)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.sizeAffectsWidth = sizeAffectsWidth;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.sizeAffectsWidth"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsSizeAffectsWidth(this ParticleSystem particleSystem, Func<bool, bool> sizeAffectsWidthChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.sizeAffectsWidth = sizeAffectsWidthChanger(module.sizeAffectsWidth);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.sizeAffectsWidth"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetSizeAffectsWidth(this TrailModule module, bool sizeAffectsWidth)
        {
            module.sizeAffectsWidth = sizeAffectsWidth;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.sizeAffectsWidth"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetSizeAffectsWidth(this TrailModule module, Func<bool, bool> sizeAffectsWidthChanger)
        {
            module.sizeAffectsWidth = sizeAffectsWidthChanger(module.sizeAffectsWidth);
            return module;
        }
        #endregion

        #region SplitSubEmitterRibbons
        /// <summary>
        /// Assign a value to <see cref="TrailModule.splitSubEmitterRibbons"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsSplitSubEmitterRibbons(this ParticleSystem particleSystem, bool splitSubEmitterRibbons)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.splitSubEmitterRibbons = splitSubEmitterRibbons;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.splitSubEmitterRibbons"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsSplitSubEmitterRibbons(this ParticleSystem particleSystem, Func<bool, bool> splitSubEmitterRibbonsChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.splitSubEmitterRibbons = splitSubEmitterRibbonsChanger(module.splitSubEmitterRibbons);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.splitSubEmitterRibbons"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetSplitSubEmitterRibbons(this TrailModule module, bool splitSubEmitterRibbons)
        {
            module.splitSubEmitterRibbons = splitSubEmitterRibbons;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.splitSubEmitterRibbons"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetSplitSubEmitterRibbons(this TrailModule module, Func<bool, bool> splitSubEmitterRibbonsChanger)
        {
            module.splitSubEmitterRibbons = splitSubEmitterRibbonsChanger(module.splitSubEmitterRibbons);
            return module;
        }
        #endregion

        #region TextureMode
        /// <summary>
        /// Assign a value to <see cref="TrailModule.textureMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsTextureMode(this ParticleSystem particleSystem, ParticleSystemTrailTextureMode textureMode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.textureMode = textureMode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.textureMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsTextureMode(this ParticleSystem particleSystem, Func<ParticleSystemTrailTextureMode, ParticleSystemTrailTextureMode> textureModeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.textureMode = textureModeChanger(module.textureMode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.textureMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetTextureMode(this TrailModule module, ParticleSystemTrailTextureMode textureMode)
        {
            module.textureMode = textureMode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.textureMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetTextureMode(this TrailModule module, Func<ParticleSystemTrailTextureMode, ParticleSystemTrailTextureMode> textureModeChanger)
        {
            module.textureMode = textureModeChanger(module.textureMode);
            return module;
        }
        #endregion
#endif

#if UNITY_2022_2_OR_NEWER
        #region TextureScale
        /// <summary>
        /// Assign a value to <see cref="TrailModule.textureScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsTextureScale(this ParticleSystem particleSystem, Vector2 textureScale)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.textureScale = textureScale;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.textureScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsTextureScale(this ParticleSystem particleSystem, Func<Vector2, Vector2> textureScaleChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.textureScale = textureScaleChanger(module.textureScale);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.textureScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetTextureScale(this TrailModule module, Vector2 textureScale)
        {
            module.textureScale = textureScale;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.textureScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetTextureScale(this TrailModule module, Func<Vector2, Vector2> textureScaleChanger)
        {
            module.textureScale = textureScaleChanger(module.textureScale);
            return module;
        }
        #endregion
#endif

#if UNITY_2018_4_OR_NEWER
        #region WidthOverTrail
        /// <summary>
        /// Assign a value to <see cref="TrailModule.widthOverTrail"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsWidthOverTrail(this ParticleSystem particleSystem, MinMaxCurve widthOverTrail)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.widthOverTrail = widthOverTrail;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.widthOverTrail"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsWidthOverTrail(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> widthOverTrailChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.widthOverTrail = widthOverTrailChanger(module.widthOverTrail);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.widthOverTrail"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetWidthOverTrail(this TrailModule module, MinMaxCurve widthOverTrail)
        {
            module.widthOverTrail = widthOverTrail;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.widthOverTrail"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetWidthOverTrail(this TrailModule module, Func<MinMaxCurve, MinMaxCurve> widthOverTrailChanger)
        {
            module.widthOverTrail = widthOverTrailChanger(module.widthOverTrail);
            return module;
        }
        #endregion

        #region WidthOverTrailMultiplier
        /// <summary>
        /// Assign a value to <see cref="TrailModule.widthOverTrailMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsWidthOverTrailMultiplier(this ParticleSystem particleSystem, float widthOverTrailMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.widthOverTrailMultiplier = widthOverTrailMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.widthOverTrailMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsWidthOverTrailMultiplier(this ParticleSystem particleSystem, Func<float, float> widthOverTrailMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.widthOverTrailMultiplier = widthOverTrailMultiplierChanger(module.widthOverTrailMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.widthOverTrailMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetWidthOverTrailMultiplier(this TrailModule module, float widthOverTrailMultiplier)
        {
            module.widthOverTrailMultiplier = widthOverTrailMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.widthOverTrailMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetWidthOverTrailMultiplier(this TrailModule module, Func<float, float> widthOverTrailMultiplierChanger)
        {
            module.widthOverTrailMultiplier = widthOverTrailMultiplierChanger(module.widthOverTrailMultiplier);
            return module;
        }
        #endregion

        #region WorldSpace
        /// <summary>
        /// Assign a value to <see cref="TrailModule.worldSpace"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsWorldSpace(this ParticleSystem particleSystem, bool worldSpace)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.worldSpace = worldSpace;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.worldSpace"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTrailsWorldSpace(this ParticleSystem particleSystem, Func<bool, bool> worldSpaceChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trails;
            module.worldSpace = worldSpaceChanger(module.worldSpace);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TrailModule.worldSpace"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetWorldSpace(this TrailModule module, bool worldSpace)
        {
            module.worldSpace = worldSpace;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TrailModule.worldSpace"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TrailModule SetWorldSpace(this TrailModule module, Func<bool, bool> worldSpaceChanger)
        {
            module.worldSpace = worldSpaceChanger(module.worldSpace);
            return module;
        }
        #endregion
#endif
    }
}
