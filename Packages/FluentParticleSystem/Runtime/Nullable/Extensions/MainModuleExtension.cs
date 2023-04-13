#nullable enable
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class MainModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.main"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditMain(this ParticleSystem particleSystem, Action<MainModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.main);
            return particleSystem;
        }

        #region CullingMode
        /// <summary>
        /// Assign a value to <see cref="MainModule.cullingMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainCullingMode(this ParticleSystem particleSystem, ParticleSystemCullingMode cullingMode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.cullingMode = cullingMode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.cullingMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainCullingMode(this ParticleSystem particleSystem, Func<ParticleSystemCullingMode, ParticleSystemCullingMode> cullingModeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(cullingModeChanger != null, "cullingModeChanger cannot be null");
            var module = particleSystem.main;
            module.cullingMode = cullingModeChanger(module.cullingMode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.cullingMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetCullingMode(this MainModule module, ParticleSystemCullingMode cullingMode)
        {
            module.cullingMode = cullingMode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.cullingMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetCullingMode(this MainModule module, Func<ParticleSystemCullingMode, ParticleSystemCullingMode> cullingModeChanger)
        {
            Debug.Assert(cullingModeChanger != null, "cullingModeChanger cannot be null");
            module.cullingMode = cullingModeChanger(module.cullingMode);
            return module;
        }
        #endregion

        #region CustomSimulationSpace
        /// <summary>
        /// Assign a value to <see cref="MainModule.customSimulationSpace"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainCustomSimulationSpace(this ParticleSystem particleSystem, Transform customSimulationSpace)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.customSimulationSpace = customSimulationSpace;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.customSimulationSpace"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainCustomSimulationSpace(this ParticleSystem particleSystem, Func<Transform, Transform> customSimulationSpaceChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(customSimulationSpaceChanger != null, "customSimulationSpaceChanger cannot be null");
            var module = particleSystem.main;
            module.customSimulationSpace = customSimulationSpaceChanger(module.customSimulationSpace);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.customSimulationSpace"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetCustomSimulationSpace(this MainModule module, Transform customSimulationSpace)
        {
            module.customSimulationSpace = customSimulationSpace;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.customSimulationSpace"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetCustomSimulationSpace(this MainModule module, Func<Transform, Transform> customSimulationSpaceChanger)
        {
            Debug.Assert(customSimulationSpaceChanger != null, "customSimulationSpaceChanger cannot be null");
            module.customSimulationSpace = customSimulationSpaceChanger(module.customSimulationSpace);
            return module;
        }
        #endregion

        #region Duration
        /// <summary>
        /// Assign a value to <see cref="MainModule.duration"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainDuration(this ParticleSystem particleSystem, float duration)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.duration = duration;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.duration"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainDuration(this ParticleSystem particleSystem, Func<float, float> durationChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(durationChanger != null, "durationChanger cannot be null");
            var module = particleSystem.main;
            module.duration = durationChanger(module.duration);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.duration"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetDuration(this MainModule module, float duration)
        {
            module.duration = duration;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.duration"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetDuration(this MainModule module, Func<float, float> durationChanger)
        {
            Debug.Assert(durationChanger != null, "durationChanger cannot be null");
            module.duration = durationChanger(module.duration);
            return module;
        }
        #endregion
#endif

#if UNITY_2021_3_OR_NEWER
        #region EmitterVelocity
        /// <summary>
        /// Assign a value to <see cref="MainModule.emitterVelocity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainEmitterVelocity(this ParticleSystem particleSystem, Vector3 emitterVelocity)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.emitterVelocity = emitterVelocity;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.emitterVelocity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainEmitterVelocity(this ParticleSystem particleSystem, Func<Vector3, Vector3> emitterVelocityChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(emitterVelocityChanger != null, "emitterVelocityChanger cannot be null");
            var module = particleSystem.main;
            module.emitterVelocity = emitterVelocityChanger(module.emitterVelocity);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.emitterVelocity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetEmitterVelocity(this MainModule module, Vector3 emitterVelocity)
        {
            module.emitterVelocity = emitterVelocity;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.emitterVelocity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetEmitterVelocity(this MainModule module, Func<Vector3, Vector3> emitterVelocityChanger)
        {
            Debug.Assert(emitterVelocityChanger != null, "emitterVelocityChanger cannot be null");
            module.emitterVelocity = emitterVelocityChanger(module.emitterVelocity);
            return module;
        }
        #endregion
#endif

#if UNITY_2018_4_OR_NEWER
        #region EmitterVelocityMode
        /// <summary>
        /// Assign a value to <see cref="MainModule.emitterVelocityMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainEmitterVelocityMode(this ParticleSystem particleSystem, ParticleSystemEmitterVelocityMode emitterVelocityMode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.emitterVelocityMode = emitterVelocityMode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.emitterVelocityMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainEmitterVelocityMode(this ParticleSystem particleSystem, Func<ParticleSystemEmitterVelocityMode, ParticleSystemEmitterVelocityMode> emitterVelocityModeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(emitterVelocityModeChanger != null, "emitterVelocityModeChanger cannot be null");
            var module = particleSystem.main;
            module.emitterVelocityMode = emitterVelocityModeChanger(module.emitterVelocityMode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.emitterVelocityMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetEmitterVelocityMode(this MainModule module, ParticleSystemEmitterVelocityMode emitterVelocityMode)
        {
            module.emitterVelocityMode = emitterVelocityMode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.emitterVelocityMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetEmitterVelocityMode(this MainModule module, Func<ParticleSystemEmitterVelocityMode, ParticleSystemEmitterVelocityMode> emitterVelocityModeChanger)
        {
            Debug.Assert(emitterVelocityModeChanger != null, "emitterVelocityModeChanger cannot be null");
            module.emitterVelocityMode = emitterVelocityModeChanger(module.emitterVelocityMode);
            return module;
        }
        #endregion

        #region FlipRotation
        /// <summary>
        /// Assign a value to <see cref="MainModule.flipRotation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainFlipRotation(this ParticleSystem particleSystem, float flipRotation)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.flipRotation = flipRotation;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.flipRotation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainFlipRotation(this ParticleSystem particleSystem, Func<float, float> flipRotationChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(flipRotationChanger != null, "flipRotationChanger cannot be null");
            var module = particleSystem.main;
            module.flipRotation = flipRotationChanger(module.flipRotation);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.flipRotation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetFlipRotation(this MainModule module, float flipRotation)
        {
            module.flipRotation = flipRotation;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.flipRotation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetFlipRotation(this MainModule module, Func<float, float> flipRotationChanger)
        {
            Debug.Assert(flipRotationChanger != null, "flipRotationChanger cannot be null");
            module.flipRotation = flipRotationChanger(module.flipRotation);
            return module;
        }
        #endregion

        #region GravityModifier
        /// <summary>
        /// Assign a value to <see cref="MainModule.gravityModifier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainGravityModifier(this ParticleSystem particleSystem, MinMaxCurve gravityModifier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.gravityModifier = gravityModifier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.gravityModifier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainGravityModifier(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> gravityModifierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(gravityModifierChanger != null, "gravityModifierChanger cannot be null");
            var module = particleSystem.main;
            module.gravityModifier = gravityModifierChanger(module.gravityModifier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.gravityModifier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetGravityModifier(this MainModule module, MinMaxCurve gravityModifier)
        {
            module.gravityModifier = gravityModifier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.gravityModifier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetGravityModifier(this MainModule module, Func<MinMaxCurve, MinMaxCurve> gravityModifierChanger)
        {
            Debug.Assert(gravityModifierChanger != null, "gravityModifierChanger cannot be null");
            module.gravityModifier = gravityModifierChanger(module.gravityModifier);
            return module;
        }
        #endregion

        #region GravityModifierMultiplier
        /// <summary>
        /// Assign a value to <see cref="MainModule.gravityModifierMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainGravityModifierMultiplier(this ParticleSystem particleSystem, float gravityModifierMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.gravityModifierMultiplier = gravityModifierMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.gravityModifierMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainGravityModifierMultiplier(this ParticleSystem particleSystem, Func<float, float> gravityModifierMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(gravityModifierMultiplierChanger != null, "gravityModifierMultiplierChanger cannot be null");
            var module = particleSystem.main;
            module.gravityModifierMultiplier = gravityModifierMultiplierChanger(module.gravityModifierMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.gravityModifierMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetGravityModifierMultiplier(this MainModule module, float gravityModifierMultiplier)
        {
            module.gravityModifierMultiplier = gravityModifierMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.gravityModifierMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetGravityModifierMultiplier(this MainModule module, Func<float, float> gravityModifierMultiplierChanger)
        {
            Debug.Assert(gravityModifierMultiplierChanger != null, "gravityModifierMultiplierChanger cannot be null");
            module.gravityModifierMultiplier = gravityModifierMultiplierChanger(module.gravityModifierMultiplier);
            return module;
        }
        #endregion
#endif

#if UNITY_2022_2_OR_NEWER
        #region GravitySource
        /// <summary>
        /// Assign a value to <see cref="MainModule.gravitySource"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainGravitySource(this ParticleSystem particleSystem, ParticleSystemGravitySource gravitySource)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.gravitySource = gravitySource;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.gravitySource"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainGravitySource(this ParticleSystem particleSystem, Func<ParticleSystemGravitySource, ParticleSystemGravitySource> gravitySourceChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(gravitySourceChanger != null, "gravitySourceChanger cannot be null");
            var module = particleSystem.main;
            module.gravitySource = gravitySourceChanger(module.gravitySource);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.gravitySource"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetGravitySource(this MainModule module, ParticleSystemGravitySource gravitySource)
        {
            module.gravitySource = gravitySource;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.gravitySource"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetGravitySource(this MainModule module, Func<ParticleSystemGravitySource, ParticleSystemGravitySource> gravitySourceChanger)
        {
            Debug.Assert(gravitySourceChanger != null, "gravitySourceChanger cannot be null");
            module.gravitySource = gravitySourceChanger(module.gravitySource);
            return module;
        }
        #endregion
#endif

#if UNITY_2018_4_OR_NEWER
        #region Loop
        /// <summary>
        /// Assign a value to <see cref="MainModule.loop"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainLoop(this ParticleSystem particleSystem, bool loop)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.loop = loop;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.loop"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainLoop(this ParticleSystem particleSystem, Func<bool, bool> loopChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(loopChanger != null, "loopChanger cannot be null");
            var module = particleSystem.main;
            module.loop = loopChanger(module.loop);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.loop"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetLoop(this MainModule module, bool loop)
        {
            module.loop = loop;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.loop"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetLoop(this MainModule module, Func<bool, bool> loopChanger)
        {
            Debug.Assert(loopChanger != null, "loopChanger cannot be null");
            module.loop = loopChanger(module.loop);
            return module;
        }
        #endregion

        #region MaxParticles
        /// <summary>
        /// Assign a value to <see cref="MainModule.maxParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainMaxParticles(this ParticleSystem particleSystem, int maxParticles)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.maxParticles = maxParticles;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.maxParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainMaxParticles(this ParticleSystem particleSystem, Func<int, int> maxParticlesChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(maxParticlesChanger != null, "maxParticlesChanger cannot be null");
            var module = particleSystem.main;
            module.maxParticles = maxParticlesChanger(module.maxParticles);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.maxParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetMaxParticles(this MainModule module, int maxParticles)
        {
            module.maxParticles = maxParticles;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.maxParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetMaxParticles(this MainModule module, Func<int, int> maxParticlesChanger)
        {
            Debug.Assert(maxParticlesChanger != null, "maxParticlesChanger cannot be null");
            module.maxParticles = maxParticlesChanger(module.maxParticles);
            return module;
        }
        #endregion

        #region PlayOnAwake
        /// <summary>
        /// Assign a value to <see cref="MainModule.playOnAwake"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainPlayOnAwake(this ParticleSystem particleSystem, bool playOnAwake)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.playOnAwake = playOnAwake;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.playOnAwake"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainPlayOnAwake(this ParticleSystem particleSystem, Func<bool, bool> playOnAwakeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(playOnAwakeChanger != null, "playOnAwakeChanger cannot be null");
            var module = particleSystem.main;
            module.playOnAwake = playOnAwakeChanger(module.playOnAwake);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.playOnAwake"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetPlayOnAwake(this MainModule module, bool playOnAwake)
        {
            module.playOnAwake = playOnAwake;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.playOnAwake"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetPlayOnAwake(this MainModule module, Func<bool, bool> playOnAwakeChanger)
        {
            Debug.Assert(playOnAwakeChanger != null, "playOnAwakeChanger cannot be null");
            module.playOnAwake = playOnAwakeChanger(module.playOnAwake);
            return module;
        }
        #endregion

        #region Prewarm
        /// <summary>
        /// Assign a value to <see cref="MainModule.prewarm"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainPrewarm(this ParticleSystem particleSystem, bool prewarm)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.prewarm = prewarm;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.prewarm"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainPrewarm(this ParticleSystem particleSystem, Func<bool, bool> prewarmChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(prewarmChanger != null, "prewarmChanger cannot be null");
            var module = particleSystem.main;
            module.prewarm = prewarmChanger(module.prewarm);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.prewarm"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetPrewarm(this MainModule module, bool prewarm)
        {
            module.prewarm = prewarm;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.prewarm"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetPrewarm(this MainModule module, Func<bool, bool> prewarmChanger)
        {
            Debug.Assert(prewarmChanger != null, "prewarmChanger cannot be null");
            module.prewarm = prewarmChanger(module.prewarm);
            return module;
        }
        #endregion

        #region RandomizeRotationDirection
        /// <summary>
        /// Assign a value to <see cref="MainModule.randomizeRotationDirection"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("Please use flipRotation instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/MainModule.flipRotation", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainRandomizeRotationDirection(this ParticleSystem particleSystem, float randomizeRotationDirection)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.randomizeRotationDirection = randomizeRotationDirection;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.randomizeRotationDirection"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("Please use flipRotation instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/MainModule.flipRotation", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainRandomizeRotationDirection(this ParticleSystem particleSystem, Func<float, float> randomizeRotationDirectionChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(randomizeRotationDirectionChanger != null, "randomizeRotationDirectionChanger cannot be null");
            var module = particleSystem.main;
            module.randomizeRotationDirection = randomizeRotationDirectionChanger(module.randomizeRotationDirection);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.randomizeRotationDirection"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("Please use flipRotation instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/MainModule.flipRotation", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetRandomizeRotationDirection(this MainModule module, float randomizeRotationDirection)
        {
            module.randomizeRotationDirection = randomizeRotationDirection;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.randomizeRotationDirection"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("Please use flipRotation instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/MainModule.flipRotation", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetRandomizeRotationDirection(this MainModule module, Func<float, float> randomizeRotationDirectionChanger)
        {
            Debug.Assert(randomizeRotationDirectionChanger != null, "randomizeRotationDirectionChanger cannot be null");
            module.randomizeRotationDirection = randomizeRotationDirectionChanger(module.randomizeRotationDirection);
            return module;
        }
        #endregion

        #region RingBufferLoopRange
        /// <summary>
        /// Assign a value to <see cref="MainModule.ringBufferLoopRange"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainRingBufferLoopRange(this ParticleSystem particleSystem, Vector2 ringBufferLoopRange)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.ringBufferLoopRange = ringBufferLoopRange;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.ringBufferLoopRange"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainRingBufferLoopRange(this ParticleSystem particleSystem, Func<Vector2, Vector2> ringBufferLoopRangeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(ringBufferLoopRangeChanger != null, "ringBufferLoopRangeChanger cannot be null");
            var module = particleSystem.main;
            module.ringBufferLoopRange = ringBufferLoopRangeChanger(module.ringBufferLoopRange);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.ringBufferLoopRange"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetRingBufferLoopRange(this MainModule module, Vector2 ringBufferLoopRange)
        {
            module.ringBufferLoopRange = ringBufferLoopRange;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.ringBufferLoopRange"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetRingBufferLoopRange(this MainModule module, Func<Vector2, Vector2> ringBufferLoopRangeChanger)
        {
            Debug.Assert(ringBufferLoopRangeChanger != null, "ringBufferLoopRangeChanger cannot be null");
            module.ringBufferLoopRange = ringBufferLoopRangeChanger(module.ringBufferLoopRange);
            return module;
        }
        #endregion

        #region RingBufferMode
        /// <summary>
        /// Assign a value to <see cref="MainModule.ringBufferMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainRingBufferMode(this ParticleSystem particleSystem, ParticleSystemRingBufferMode ringBufferMode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.ringBufferMode = ringBufferMode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.ringBufferMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainRingBufferMode(this ParticleSystem particleSystem, Func<ParticleSystemRingBufferMode, ParticleSystemRingBufferMode> ringBufferModeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(ringBufferModeChanger != null, "ringBufferModeChanger cannot be null");
            var module = particleSystem.main;
            module.ringBufferMode = ringBufferModeChanger(module.ringBufferMode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.ringBufferMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetRingBufferMode(this MainModule module, ParticleSystemRingBufferMode ringBufferMode)
        {
            module.ringBufferMode = ringBufferMode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.ringBufferMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetRingBufferMode(this MainModule module, Func<ParticleSystemRingBufferMode, ParticleSystemRingBufferMode> ringBufferModeChanger)
        {
            Debug.Assert(ringBufferModeChanger != null, "ringBufferModeChanger cannot be null");
            module.ringBufferMode = ringBufferModeChanger(module.ringBufferMode);
            return module;
        }
        #endregion

        #region ScalingMode
        /// <summary>
        /// Assign a value to <see cref="MainModule.scalingMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainScalingMode(this ParticleSystem particleSystem, ParticleSystemScalingMode scalingMode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.scalingMode = scalingMode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.scalingMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainScalingMode(this ParticleSystem particleSystem, Func<ParticleSystemScalingMode, ParticleSystemScalingMode> scalingModeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(scalingModeChanger != null, "scalingModeChanger cannot be null");
            var module = particleSystem.main;
            module.scalingMode = scalingModeChanger(module.scalingMode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.scalingMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetScalingMode(this MainModule module, ParticleSystemScalingMode scalingMode)
        {
            module.scalingMode = scalingMode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.scalingMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetScalingMode(this MainModule module, Func<ParticleSystemScalingMode, ParticleSystemScalingMode> scalingModeChanger)
        {
            Debug.Assert(scalingModeChanger != null, "scalingModeChanger cannot be null");
            module.scalingMode = scalingModeChanger(module.scalingMode);
            return module;
        }
        #endregion

        #region SimulationSpace
        /// <summary>
        /// Assign a value to <see cref="MainModule.simulationSpace"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainSimulationSpace(this ParticleSystem particleSystem, ParticleSystemSimulationSpace simulationSpace)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.simulationSpace = simulationSpace;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.simulationSpace"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainSimulationSpace(this ParticleSystem particleSystem, Func<ParticleSystemSimulationSpace, ParticleSystemSimulationSpace> simulationSpaceChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(simulationSpaceChanger != null, "simulationSpaceChanger cannot be null");
            var module = particleSystem.main;
            module.simulationSpace = simulationSpaceChanger(module.simulationSpace);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.simulationSpace"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetSimulationSpace(this MainModule module, ParticleSystemSimulationSpace simulationSpace)
        {
            module.simulationSpace = simulationSpace;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.simulationSpace"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetSimulationSpace(this MainModule module, Func<ParticleSystemSimulationSpace, ParticleSystemSimulationSpace> simulationSpaceChanger)
        {
            Debug.Assert(simulationSpaceChanger != null, "simulationSpaceChanger cannot be null");
            module.simulationSpace = simulationSpaceChanger(module.simulationSpace);
            return module;
        }
        #endregion

        #region SimulationSpeed
        /// <summary>
        /// Assign a value to <see cref="MainModule.simulationSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainSimulationSpeed(this ParticleSystem particleSystem, float simulationSpeed)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.simulationSpeed = simulationSpeed;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.simulationSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainSimulationSpeed(this ParticleSystem particleSystem, Func<float, float> simulationSpeedChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(simulationSpeedChanger != null, "simulationSpeedChanger cannot be null");
            var module = particleSystem.main;
            module.simulationSpeed = simulationSpeedChanger(module.simulationSpeed);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.simulationSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetSimulationSpeed(this MainModule module, float simulationSpeed)
        {
            module.simulationSpeed = simulationSpeed;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.simulationSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetSimulationSpeed(this MainModule module, Func<float, float> simulationSpeedChanger)
        {
            Debug.Assert(simulationSpeedChanger != null, "simulationSpeedChanger cannot be null");
            module.simulationSpeed = simulationSpeedChanger(module.simulationSpeed);
            return module;
        }
        #endregion

        #region StartColor
        /// <summary>
        /// Assign a value to <see cref="MainModule.startColor"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartColor(this ParticleSystem particleSystem, MinMaxGradient startColor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startColor = startColor;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startColor"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartColor(this ParticleSystem particleSystem, Func<MinMaxGradient, MinMaxGradient> startColorChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startColorChanger != null, "startColorChanger cannot be null");
            var module = particleSystem.main;
            module.startColor = startColorChanger(module.startColor);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startColor"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartColor(this MainModule module, MinMaxGradient startColor)
        {
            module.startColor = startColor;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startColor"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartColor(this MainModule module, Func<MinMaxGradient, MinMaxGradient> startColorChanger)
        {
            Debug.Assert(startColorChanger != null, "startColorChanger cannot be null");
            module.startColor = startColorChanger(module.startColor);
            return module;
        }
        #endregion

        #region StartDelay
        /// <summary>
        /// Assign a value to <see cref="MainModule.startDelay"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartDelay(this ParticleSystem particleSystem, MinMaxCurve startDelay)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startDelay = startDelay;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startDelay"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartDelay(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startDelayChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startDelayChanger != null, "startDelayChanger cannot be null");
            var module = particleSystem.main;
            module.startDelay = startDelayChanger(module.startDelay);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startDelay"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartDelay(this MainModule module, MinMaxCurve startDelay)
        {
            module.startDelay = startDelay;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startDelay"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartDelay(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startDelayChanger)
        {
            Debug.Assert(startDelayChanger != null, "startDelayChanger cannot be null");
            module.startDelay = startDelayChanger(module.startDelay);
            return module;
        }
        #endregion

        #region StartDelayMultiplier
        /// <summary>
        /// Assign a value to <see cref="MainModule.startDelayMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartDelayMultiplier(this ParticleSystem particleSystem, float startDelayMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startDelayMultiplier = startDelayMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startDelayMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartDelayMultiplier(this ParticleSystem particleSystem, Func<float, float> startDelayMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startDelayMultiplierChanger != null, "startDelayMultiplierChanger cannot be null");
            var module = particleSystem.main;
            module.startDelayMultiplier = startDelayMultiplierChanger(module.startDelayMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startDelayMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartDelayMultiplier(this MainModule module, float startDelayMultiplier)
        {
            module.startDelayMultiplier = startDelayMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startDelayMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartDelayMultiplier(this MainModule module, Func<float, float> startDelayMultiplierChanger)
        {
            Debug.Assert(startDelayMultiplierChanger != null, "startDelayMultiplierChanger cannot be null");
            module.startDelayMultiplier = startDelayMultiplierChanger(module.startDelayMultiplier);
            return module;
        }
        #endregion

        #region StartLifetime
        /// <summary>
        /// Assign a value to <see cref="MainModule.startLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartLifetime(this ParticleSystem particleSystem, MinMaxCurve startLifetime)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startLifetime = startLifetime;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartLifetime(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startLifetimeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startLifetimeChanger != null, "startLifetimeChanger cannot be null");
            var module = particleSystem.main;
            module.startLifetime = startLifetimeChanger(module.startLifetime);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartLifetime(this MainModule module, MinMaxCurve startLifetime)
        {
            module.startLifetime = startLifetime;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartLifetime(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startLifetimeChanger)
        {
            Debug.Assert(startLifetimeChanger != null, "startLifetimeChanger cannot be null");
            module.startLifetime = startLifetimeChanger(module.startLifetime);
            return module;
        }
        #endregion

        #region StartLifetimeMultiplier
        /// <summary>
        /// Assign a value to <see cref="MainModule.startLifetimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartLifetimeMultiplier(this ParticleSystem particleSystem, float startLifetimeMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startLifetimeMultiplier = startLifetimeMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startLifetimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartLifetimeMultiplier(this ParticleSystem particleSystem, Func<float, float> startLifetimeMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startLifetimeMultiplierChanger != null, "startLifetimeMultiplierChanger cannot be null");
            var module = particleSystem.main;
            module.startLifetimeMultiplier = startLifetimeMultiplierChanger(module.startLifetimeMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startLifetimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartLifetimeMultiplier(this MainModule module, float startLifetimeMultiplier)
        {
            module.startLifetimeMultiplier = startLifetimeMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startLifetimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartLifetimeMultiplier(this MainModule module, Func<float, float> startLifetimeMultiplierChanger)
        {
            Debug.Assert(startLifetimeMultiplierChanger != null, "startLifetimeMultiplierChanger cannot be null");
            module.startLifetimeMultiplier = startLifetimeMultiplierChanger(module.startLifetimeMultiplier);
            return module;
        }
        #endregion

        #region StartRotation
        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotation(this ParticleSystem particleSystem, MinMaxCurve startRotation)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startRotation = startRotation;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotation(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startRotationChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startRotationChanger != null, "startRotationChanger cannot be null");
            var module = particleSystem.main;
            module.startRotation = startRotationChanger(module.startRotation);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotation(this MainModule module, MinMaxCurve startRotation)
        {
            module.startRotation = startRotation;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotation(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startRotationChanger)
        {
            Debug.Assert(startRotationChanger != null, "startRotationChanger cannot be null");
            module.startRotation = startRotationChanger(module.startRotation);
            return module;
        }
        #endregion

        #region StartRotation3D
        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotation3D"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotation3D(this ParticleSystem particleSystem, bool startRotation3D)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startRotation3D = startRotation3D;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotation3D"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotation3D(this ParticleSystem particleSystem, Func<bool, bool> startRotation3DChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startRotation3DChanger != null, "startRotation3DChanger cannot be null");
            var module = particleSystem.main;
            module.startRotation3D = startRotation3DChanger(module.startRotation3D);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotation3D"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotation3D(this MainModule module, bool startRotation3D)
        {
            module.startRotation3D = startRotation3D;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotation3D"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotation3D(this MainModule module, Func<bool, bool> startRotation3DChanger)
        {
            Debug.Assert(startRotation3DChanger != null, "startRotation3DChanger cannot be null");
            module.startRotation3D = startRotation3DChanger(module.startRotation3D);
            return module;
        }
        #endregion

        #region StartRotationMultiplier
        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationMultiplier(this ParticleSystem particleSystem, float startRotationMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startRotationMultiplier = startRotationMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationMultiplier(this ParticleSystem particleSystem, Func<float, float> startRotationMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startRotationMultiplierChanger != null, "startRotationMultiplierChanger cannot be null");
            var module = particleSystem.main;
            module.startRotationMultiplier = startRotationMultiplierChanger(module.startRotationMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationMultiplier(this MainModule module, float startRotationMultiplier)
        {
            module.startRotationMultiplier = startRotationMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationMultiplier(this MainModule module, Func<float, float> startRotationMultiplierChanger)
        {
            Debug.Assert(startRotationMultiplierChanger != null, "startRotationMultiplierChanger cannot be null");
            module.startRotationMultiplier = startRotationMultiplierChanger(module.startRotationMultiplier);
            return module;
        }
        #endregion

        #region StartRotationX
        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationX(this ParticleSystem particleSystem, MinMaxCurve startRotationX)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startRotationX = startRotationX;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startRotationXChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startRotationXChanger != null, "startRotationXChanger cannot be null");
            var module = particleSystem.main;
            module.startRotationX = startRotationXChanger(module.startRotationX);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationX(this MainModule module, MinMaxCurve startRotationX)
        {
            module.startRotationX = startRotationX;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationX(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startRotationXChanger)
        {
            Debug.Assert(startRotationXChanger != null, "startRotationXChanger cannot be null");
            module.startRotationX = startRotationXChanger(module.startRotationX);
            return module;
        }
        #endregion

        #region StartRotationXMultiplier
        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationXMultiplier(this ParticleSystem particleSystem, float startRotationXMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startRotationXMultiplier = startRotationXMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationXMultiplier(this ParticleSystem particleSystem, Func<float, float> startRotationXMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startRotationXMultiplierChanger != null, "startRotationXMultiplierChanger cannot be null");
            var module = particleSystem.main;
            module.startRotationXMultiplier = startRotationXMultiplierChanger(module.startRotationXMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationXMultiplier(this MainModule module, float startRotationXMultiplier)
        {
            module.startRotationXMultiplier = startRotationXMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationXMultiplier(this MainModule module, Func<float, float> startRotationXMultiplierChanger)
        {
            Debug.Assert(startRotationXMultiplierChanger != null, "startRotationXMultiplierChanger cannot be null");
            module.startRotationXMultiplier = startRotationXMultiplierChanger(module.startRotationXMultiplier);
            return module;
        }
        #endregion

        #region StartRotationY
        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationY(this ParticleSystem particleSystem, MinMaxCurve startRotationY)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startRotationY = startRotationY;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startRotationYChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startRotationYChanger != null, "startRotationYChanger cannot be null");
            var module = particleSystem.main;
            module.startRotationY = startRotationYChanger(module.startRotationY);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationY(this MainModule module, MinMaxCurve startRotationY)
        {
            module.startRotationY = startRotationY;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationY(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startRotationYChanger)
        {
            Debug.Assert(startRotationYChanger != null, "startRotationYChanger cannot be null");
            module.startRotationY = startRotationYChanger(module.startRotationY);
            return module;
        }
        #endregion

        #region StartRotationYMultiplier
        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationYMultiplier(this ParticleSystem particleSystem, float startRotationYMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startRotationYMultiplier = startRotationYMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationYMultiplier(this ParticleSystem particleSystem, Func<float, float> startRotationYMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startRotationYMultiplierChanger != null, "startRotationYMultiplierChanger cannot be null");
            var module = particleSystem.main;
            module.startRotationYMultiplier = startRotationYMultiplierChanger(module.startRotationYMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationYMultiplier(this MainModule module, float startRotationYMultiplier)
        {
            module.startRotationYMultiplier = startRotationYMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationYMultiplier(this MainModule module, Func<float, float> startRotationYMultiplierChanger)
        {
            Debug.Assert(startRotationYMultiplierChanger != null, "startRotationYMultiplierChanger cannot be null");
            module.startRotationYMultiplier = startRotationYMultiplierChanger(module.startRotationYMultiplier);
            return module;
        }
        #endregion

        #region StartRotationZ
        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationZ(this ParticleSystem particleSystem, MinMaxCurve startRotationZ)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startRotationZ = startRotationZ;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startRotationZChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startRotationZChanger != null, "startRotationZChanger cannot be null");
            var module = particleSystem.main;
            module.startRotationZ = startRotationZChanger(module.startRotationZ);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationZ(this MainModule module, MinMaxCurve startRotationZ)
        {
            module.startRotationZ = startRotationZ;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationZ(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startRotationZChanger)
        {
            Debug.Assert(startRotationZChanger != null, "startRotationZChanger cannot be null");
            module.startRotationZ = startRotationZChanger(module.startRotationZ);
            return module;
        }
        #endregion

        #region StartRotationZMultiplier
        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationZMultiplier(this ParticleSystem particleSystem, float startRotationZMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startRotationZMultiplier = startRotationZMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationZMultiplier(this ParticleSystem particleSystem, Func<float, float> startRotationZMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startRotationZMultiplierChanger != null, "startRotationZMultiplierChanger cannot be null");
            var module = particleSystem.main;
            module.startRotationZMultiplier = startRotationZMultiplierChanger(module.startRotationZMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startRotationZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationZMultiplier(this MainModule module, float startRotationZMultiplier)
        {
            module.startRotationZMultiplier = startRotationZMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startRotationZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationZMultiplier(this MainModule module, Func<float, float> startRotationZMultiplierChanger)
        {
            Debug.Assert(startRotationZMultiplierChanger != null, "startRotationZMultiplierChanger cannot be null");
            module.startRotationZMultiplier = startRotationZMultiplierChanger(module.startRotationZMultiplier);
            return module;
        }
        #endregion

        #region StartSize
        /// <summary>
        /// Assign a value to <see cref="MainModule.startSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSize(this ParticleSystem particleSystem, MinMaxCurve startSize)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startSize = startSize;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSize(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startSizeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startSizeChanger != null, "startSizeChanger cannot be null");
            var module = particleSystem.main;
            module.startSize = startSizeChanger(module.startSize);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSize(this MainModule module, MinMaxCurve startSize)
        {
            module.startSize = startSize;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSize(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startSizeChanger)
        {
            Debug.Assert(startSizeChanger != null, "startSizeChanger cannot be null");
            module.startSize = startSizeChanger(module.startSize);
            return module;
        }
        #endregion

        #region StartSize3D
        /// <summary>
        /// Assign a value to <see cref="MainModule.startSize3D"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSize3D(this ParticleSystem particleSystem, bool startSize3D)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startSize3D = startSize3D;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSize3D"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSize3D(this ParticleSystem particleSystem, Func<bool, bool> startSize3DChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startSize3DChanger != null, "startSize3DChanger cannot be null");
            var module = particleSystem.main;
            module.startSize3D = startSize3DChanger(module.startSize3D);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startSize3D"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSize3D(this MainModule module, bool startSize3D)
        {
            module.startSize3D = startSize3D;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSize3D"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSize3D(this MainModule module, Func<bool, bool> startSize3DChanger)
        {
            Debug.Assert(startSize3DChanger != null, "startSize3DChanger cannot be null");
            module.startSize3D = startSize3DChanger(module.startSize3D);
            return module;
        }
        #endregion

        #region StartSizeMultiplier
        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeMultiplier(this ParticleSystem particleSystem, float startSizeMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startSizeMultiplier = startSizeMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeMultiplier(this ParticleSystem particleSystem, Func<float, float> startSizeMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startSizeMultiplierChanger != null, "startSizeMultiplierChanger cannot be null");
            var module = particleSystem.main;
            module.startSizeMultiplier = startSizeMultiplierChanger(module.startSizeMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeMultiplier(this MainModule module, float startSizeMultiplier)
        {
            module.startSizeMultiplier = startSizeMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeMultiplier(this MainModule module, Func<float, float> startSizeMultiplierChanger)
        {
            Debug.Assert(startSizeMultiplierChanger != null, "startSizeMultiplierChanger cannot be null");
            module.startSizeMultiplier = startSizeMultiplierChanger(module.startSizeMultiplier);
            return module;
        }
        #endregion

        #region StartSizeX
        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeX(this ParticleSystem particleSystem, MinMaxCurve startSizeX)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startSizeX = startSizeX;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startSizeXChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startSizeXChanger != null, "startSizeXChanger cannot be null");
            var module = particleSystem.main;
            module.startSizeX = startSizeXChanger(module.startSizeX);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeX(this MainModule module, MinMaxCurve startSizeX)
        {
            module.startSizeX = startSizeX;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeX(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startSizeXChanger)
        {
            Debug.Assert(startSizeXChanger != null, "startSizeXChanger cannot be null");
            module.startSizeX = startSizeXChanger(module.startSizeX);
            return module;
        }
        #endregion

        #region StartSizeXMultiplier
        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeXMultiplier(this ParticleSystem particleSystem, float startSizeXMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startSizeXMultiplier = startSizeXMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeXMultiplier(this ParticleSystem particleSystem, Func<float, float> startSizeXMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startSizeXMultiplierChanger != null, "startSizeXMultiplierChanger cannot be null");
            var module = particleSystem.main;
            module.startSizeXMultiplier = startSizeXMultiplierChanger(module.startSizeXMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeXMultiplier(this MainModule module, float startSizeXMultiplier)
        {
            module.startSizeXMultiplier = startSizeXMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeXMultiplier(this MainModule module, Func<float, float> startSizeXMultiplierChanger)
        {
            Debug.Assert(startSizeXMultiplierChanger != null, "startSizeXMultiplierChanger cannot be null");
            module.startSizeXMultiplier = startSizeXMultiplierChanger(module.startSizeXMultiplier);
            return module;
        }
        #endregion

        #region StartSizeY
        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeY(this ParticleSystem particleSystem, MinMaxCurve startSizeY)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startSizeY = startSizeY;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startSizeYChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startSizeYChanger != null, "startSizeYChanger cannot be null");
            var module = particleSystem.main;
            module.startSizeY = startSizeYChanger(module.startSizeY);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeY(this MainModule module, MinMaxCurve startSizeY)
        {
            module.startSizeY = startSizeY;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeY(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startSizeYChanger)
        {
            Debug.Assert(startSizeYChanger != null, "startSizeYChanger cannot be null");
            module.startSizeY = startSizeYChanger(module.startSizeY);
            return module;
        }
        #endregion

        #region StartSizeYMultiplier
        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeYMultiplier(this ParticleSystem particleSystem, float startSizeYMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startSizeYMultiplier = startSizeYMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeYMultiplier(this ParticleSystem particleSystem, Func<float, float> startSizeYMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startSizeYMultiplierChanger != null, "startSizeYMultiplierChanger cannot be null");
            var module = particleSystem.main;
            module.startSizeYMultiplier = startSizeYMultiplierChanger(module.startSizeYMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeYMultiplier(this MainModule module, float startSizeYMultiplier)
        {
            module.startSizeYMultiplier = startSizeYMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeYMultiplier(this MainModule module, Func<float, float> startSizeYMultiplierChanger)
        {
            Debug.Assert(startSizeYMultiplierChanger != null, "startSizeYMultiplierChanger cannot be null");
            module.startSizeYMultiplier = startSizeYMultiplierChanger(module.startSizeYMultiplier);
            return module;
        }
        #endregion

        #region StartSizeZ
        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeZ(this ParticleSystem particleSystem, MinMaxCurve startSizeZ)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startSizeZ = startSizeZ;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startSizeZChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startSizeZChanger != null, "startSizeZChanger cannot be null");
            var module = particleSystem.main;
            module.startSizeZ = startSizeZChanger(module.startSizeZ);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeZ(this MainModule module, MinMaxCurve startSizeZ)
        {
            module.startSizeZ = startSizeZ;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeZ(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startSizeZChanger)
        {
            Debug.Assert(startSizeZChanger != null, "startSizeZChanger cannot be null");
            module.startSizeZ = startSizeZChanger(module.startSizeZ);
            return module;
        }
        #endregion

        #region StartSizeZMultiplier
        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeZMultiplier(this ParticleSystem particleSystem, float startSizeZMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startSizeZMultiplier = startSizeZMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeZMultiplier(this ParticleSystem particleSystem, Func<float, float> startSizeZMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startSizeZMultiplierChanger != null, "startSizeZMultiplierChanger cannot be null");
            var module = particleSystem.main;
            module.startSizeZMultiplier = startSizeZMultiplierChanger(module.startSizeZMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startSizeZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeZMultiplier(this MainModule module, float startSizeZMultiplier)
        {
            module.startSizeZMultiplier = startSizeZMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSizeZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeZMultiplier(this MainModule module, Func<float, float> startSizeZMultiplierChanger)
        {
            Debug.Assert(startSizeZMultiplierChanger != null, "startSizeZMultiplierChanger cannot be null");
            module.startSizeZMultiplier = startSizeZMultiplierChanger(module.startSizeZMultiplier);
            return module;
        }
        #endregion

        #region StartSpeed
        /// <summary>
        /// Assign a value to <see cref="MainModule.startSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSpeed(this ParticleSystem particleSystem, MinMaxCurve startSpeed)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startSpeed = startSpeed;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSpeed(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startSpeedChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startSpeedChanger != null, "startSpeedChanger cannot be null");
            var module = particleSystem.main;
            module.startSpeed = startSpeedChanger(module.startSpeed);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSpeed(this MainModule module, MinMaxCurve startSpeed)
        {
            module.startSpeed = startSpeed;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSpeed(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startSpeedChanger)
        {
            Debug.Assert(startSpeedChanger != null, "startSpeedChanger cannot be null");
            module.startSpeed = startSpeedChanger(module.startSpeed);
            return module;
        }
        #endregion

        #region StartSpeedMultiplier
        /// <summary>
        /// Assign a value to <see cref="MainModule.startSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSpeedMultiplier(this ParticleSystem particleSystem, float startSpeedMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.startSpeedMultiplier = startSpeedMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSpeedMultiplier(this ParticleSystem particleSystem, Func<float, float> startSpeedMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startSpeedMultiplierChanger != null, "startSpeedMultiplierChanger cannot be null");
            var module = particleSystem.main;
            module.startSpeedMultiplier = startSpeedMultiplierChanger(module.startSpeedMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.startSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSpeedMultiplier(this MainModule module, float startSpeedMultiplier)
        {
            module.startSpeedMultiplier = startSpeedMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.startSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSpeedMultiplier(this MainModule module, Func<float, float> startSpeedMultiplierChanger)
        {
            Debug.Assert(startSpeedMultiplierChanger != null, "startSpeedMultiplierChanger cannot be null");
            module.startSpeedMultiplier = startSpeedMultiplierChanger(module.startSpeedMultiplier);
            return module;
        }
        #endregion

        #region StopAction
        /// <summary>
        /// Assign a value to <see cref="MainModule.stopAction"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStopAction(this ParticleSystem particleSystem, ParticleSystemStopAction stopAction)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.stopAction = stopAction;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.stopAction"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStopAction(this ParticleSystem particleSystem, Func<ParticleSystemStopAction, ParticleSystemStopAction> stopActionChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(stopActionChanger != null, "stopActionChanger cannot be null");
            var module = particleSystem.main;
            module.stopAction = stopActionChanger(module.stopAction);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.stopAction"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStopAction(this MainModule module, ParticleSystemStopAction stopAction)
        {
            module.stopAction = stopAction;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.stopAction"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStopAction(this MainModule module, Func<ParticleSystemStopAction, ParticleSystemStopAction> stopActionChanger)
        {
            Debug.Assert(stopActionChanger != null, "stopActionChanger cannot be null");
            module.stopAction = stopActionChanger(module.stopAction);
            return module;
        }
        #endregion

        #region UseUnscaledTime
        /// <summary>
        /// Assign a value to <see cref="MainModule.useUnscaledTime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainUseUnscaledTime(this ParticleSystem particleSystem, bool useUnscaledTime)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.main;
            module.useUnscaledTime = useUnscaledTime;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="MainModule.useUnscaledTime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainUseUnscaledTime(this ParticleSystem particleSystem, Func<bool, bool> useUnscaledTimeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(useUnscaledTimeChanger != null, "useUnscaledTimeChanger cannot be null");
            var module = particleSystem.main;
            module.useUnscaledTime = useUnscaledTimeChanger(module.useUnscaledTime);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="MainModule.useUnscaledTime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetUseUnscaledTime(this MainModule module, bool useUnscaledTime)
        {
            module.useUnscaledTime = useUnscaledTime;
            return module;
        }

        /// <summary>
        /// Edit <see cref="MainModule.useUnscaledTime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetUseUnscaledTime(this MainModule module, Func<bool, bool> useUnscaledTimeChanger)
        {
            Debug.Assert(useUnscaledTimeChanger != null, "useUnscaledTimeChanger cannot be null");
            module.useUnscaledTime = useUnscaledTimeChanger(module.useUnscaledTime);
            return module;
        }
        #endregion
#endif
    }
}
