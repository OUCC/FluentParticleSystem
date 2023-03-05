using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.ParticleSystem;


namespace OUCC.FluentParticleSystem
{
    public static class MainModuleExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditMain(this ParticleSystem particleSystem, Action<MainModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.main);
            return particleSystem;
        }

        #region CullingMode
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainCullingMode(this ParticleSystem particleSystem, ParticleSystemCullingMode cullingMode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.cullingMode = cullingMode;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainCullingMode(this ParticleSystem particleSystem, Func<ParticleSystemCullingMode, ParticleSystemCullingMode> cullingModeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.cullingMode = cullingModeChanger(module.cullingMode);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetCullingMode(this MainModule module, ParticleSystemCullingMode cullingMode)
        {
            module.cullingMode = cullingMode;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetCullingMode(this MainModule module, Func<ParticleSystemCullingMode, ParticleSystemCullingMode> cullingModeChanger)
        {
            module.cullingMode = cullingModeChanger(module.cullingMode);
            return module;
        }
        #endregion

        #region CustomSimulationSpace
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainCustomSimulationSpace(this ParticleSystem particleSystem, Transform customSimulationSpace)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.customSimulationSpace = customSimulationSpace;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainCustomSimulationSpace(this ParticleSystem particleSystem, Func<Transform, Transform> customSimulationSpaceChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.customSimulationSpace = customSimulationSpaceChanger(module.customSimulationSpace);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetCustomSimulationSpace(this MainModule module, Transform customSimulationSpace)
        {
            module.customSimulationSpace = customSimulationSpace;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetCustomSimulationSpace(this MainModule module, Func<Transform, Transform> customSimulationSpaceChanger)
        {
            module.customSimulationSpace = customSimulationSpaceChanger(module.customSimulationSpace);
            return module;
        }
        #endregion

        #region Duration
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainDuration(this ParticleSystem particleSystem, float duration)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.duration = duration;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainDuration(this ParticleSystem particleSystem, Func<float, float> durationChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.duration = durationChanger(module.duration);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetDuration(this MainModule module, float duration)
        {
            module.duration = duration;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetDuration(this MainModule module, Func<float, float> durationChanger)
        {
            module.duration = durationChanger(module.duration);
            return module;
        }
        #endregion

        #region EmitterVelocity
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainEmitterVelocity(this ParticleSystem particleSystem, Vector3 emitterVelocity)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.emitterVelocity = emitterVelocity;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainEmitterVelocity(this ParticleSystem particleSystem, Func<Vector3, Vector3> emitterVelocityChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.emitterVelocity = emitterVelocityChanger(module.emitterVelocity);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetEmitterVelocity(this MainModule module, Vector3 emitterVelocity)
        {
            module.emitterVelocity = emitterVelocity;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetEmitterVelocity(this MainModule module, Func<Vector3, Vector3> emitterVelocityChanger)
        {
            module.emitterVelocity = emitterVelocityChanger(module.emitterVelocity);
            return module;
        }
        #endregion

        #region EmitterVelocityMode
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainEmitterVelocityMode(this ParticleSystem particleSystem, ParticleSystemEmitterVelocityMode emitterVelocityMode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.emitterVelocityMode = emitterVelocityMode;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainEmitterVelocityMode(this ParticleSystem particleSystem, Func<ParticleSystemEmitterVelocityMode, ParticleSystemEmitterVelocityMode> emitterVelocityModeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.emitterVelocityMode = emitterVelocityModeChanger(module.emitterVelocityMode);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetEmitterVelocityMode(this MainModule module, ParticleSystemEmitterVelocityMode emitterVelocityMode)
        {
            module.emitterVelocityMode = emitterVelocityMode;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetEmitterVelocityMode(this MainModule module, Func<ParticleSystemEmitterVelocityMode, ParticleSystemEmitterVelocityMode> emitterVelocityModeChanger)
        {
            module.emitterVelocityMode = emitterVelocityModeChanger(module.emitterVelocityMode);
            return module;
        }
        #endregion

        #region FlipRotation
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainFlipRotation(this ParticleSystem particleSystem, float flipRotation)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.flipRotation = flipRotation;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainFlipRotation(this ParticleSystem particleSystem, Func<float, float> flipRotationChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.flipRotation = flipRotationChanger(module.flipRotation);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetFlipRotation(this MainModule module, float flipRotation)
        {
            module.flipRotation = flipRotation;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetFlipRotation(this MainModule module, Func<float, float> flipRotationChanger)
        {
            module.flipRotation = flipRotationChanger(module.flipRotation);
            return module;
        }
        #endregion

        #region GravityModifier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainGravityModifier(this ParticleSystem particleSystem, MinMaxCurve gravityModifier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.gravityModifier = gravityModifier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainGravityModifier(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> gravityModifierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.gravityModifier = gravityModifierChanger(module.gravityModifier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetGravityModifier(this MainModule module, MinMaxCurve gravityModifier)
        {
            module.gravityModifier = gravityModifier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetGravityModifier(this MainModule module, Func<MinMaxCurve, MinMaxCurve> gravityModifierChanger)
        {
            module.gravityModifier = gravityModifierChanger(module.gravityModifier);
            return module;
        }
        #endregion

        #region GravityModifierMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainGravityModifierMultiplier(this ParticleSystem particleSystem, float gravityModifierMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.gravityModifierMultiplier = gravityModifierMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainGravityModifierMultiplier(this ParticleSystem particleSystem, Func<float, float> gravityModifierMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.gravityModifierMultiplier = gravityModifierMultiplierChanger(module.gravityModifierMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetGravityModifierMultiplier(this MainModule module, float gravityModifierMultiplier)
        {
            module.gravityModifierMultiplier = gravityModifierMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetGravityModifierMultiplier(this MainModule module, Func<float, float> gravityModifierMultiplierChanger)
        {
            module.gravityModifierMultiplier = gravityModifierMultiplierChanger(module.gravityModifierMultiplier);
            return module;
        }
        #endregion

        #region Loop
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainLoop(this ParticleSystem particleSystem, bool loop)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.loop = loop;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainLoop(this ParticleSystem particleSystem, Func<bool, bool> loopChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.loop = loopChanger(module.loop);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetLoop(this MainModule module, bool loop)
        {
            module.loop = loop;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetLoop(this MainModule module, Func<bool, bool> loopChanger)
        {
            module.loop = loopChanger(module.loop);
            return module;
        }
        #endregion

        #region MaxParticles
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainMaxParticles(this ParticleSystem particleSystem, Int32 maxParticles)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.maxParticles = maxParticles;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainMaxParticles(this ParticleSystem particleSystem, Func<Int32, Int32> maxParticlesChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.maxParticles = maxParticlesChanger(module.maxParticles);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetMaxParticles(this MainModule module, Int32 maxParticles)
        {
            module.maxParticles = maxParticles;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetMaxParticles(this MainModule module, Func<Int32, Int32> maxParticlesChanger)
        {
            module.maxParticles = maxParticlesChanger(module.maxParticles);
            return module;
        }
        #endregion

        #region PlayOnAwake
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainPlayOnAwake(this ParticleSystem particleSystem, bool playOnAwake)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.playOnAwake = playOnAwake;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainPlayOnAwake(this ParticleSystem particleSystem, Func<bool, bool> playOnAwakeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.playOnAwake = playOnAwakeChanger(module.playOnAwake);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetPlayOnAwake(this MainModule module, bool playOnAwake)
        {
            module.playOnAwake = playOnAwake;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetPlayOnAwake(this MainModule module, Func<bool, bool> playOnAwakeChanger)
        {
            module.playOnAwake = playOnAwakeChanger(module.playOnAwake);
            return module;
        }
        #endregion

        #region Prewarm
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainPrewarm(this ParticleSystem particleSystem, bool prewarm)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.prewarm = prewarm;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainPrewarm(this ParticleSystem particleSystem, Func<bool, bool> prewarmChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.prewarm = prewarmChanger(module.prewarm);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetPrewarm(this MainModule module, bool prewarm)
        {
            module.prewarm = prewarm;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetPrewarm(this MainModule module, Func<bool, bool> prewarmChanger)
        {
            module.prewarm = prewarmChanger(module.prewarm);
            return module;
        }
        #endregion

        #region RingBufferLoopRange
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainRingBufferLoopRange(this ParticleSystem particleSystem, Vector2 ringBufferLoopRange)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.ringBufferLoopRange = ringBufferLoopRange;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainRingBufferLoopRange(this ParticleSystem particleSystem, Func<Vector2, Vector2> ringBufferLoopRangeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.ringBufferLoopRange = ringBufferLoopRangeChanger(module.ringBufferLoopRange);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetRingBufferLoopRange(this MainModule module, Vector2 ringBufferLoopRange)
        {
            module.ringBufferLoopRange = ringBufferLoopRange;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetRingBufferLoopRange(this MainModule module, Func<Vector2, Vector2> ringBufferLoopRangeChanger)
        {
            module.ringBufferLoopRange = ringBufferLoopRangeChanger(module.ringBufferLoopRange);
            return module;
        }
        #endregion

        #region RingBufferMode
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainRingBufferMode(this ParticleSystem particleSystem, ParticleSystemRingBufferMode ringBufferMode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.ringBufferMode = ringBufferMode;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainRingBufferMode(this ParticleSystem particleSystem, Func<ParticleSystemRingBufferMode, ParticleSystemRingBufferMode> ringBufferModeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.ringBufferMode = ringBufferModeChanger(module.ringBufferMode);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetRingBufferMode(this MainModule module, ParticleSystemRingBufferMode ringBufferMode)
        {
            module.ringBufferMode = ringBufferMode;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetRingBufferMode(this MainModule module, Func<ParticleSystemRingBufferMode, ParticleSystemRingBufferMode> ringBufferModeChanger)
        {
            module.ringBufferMode = ringBufferModeChanger(module.ringBufferMode);
            return module;
        }
        #endregion

        #region ScalingMode
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainScalingMode(this ParticleSystem particleSystem, ParticleSystemScalingMode scalingMode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.scalingMode = scalingMode;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainScalingMode(this ParticleSystem particleSystem, Func<ParticleSystemScalingMode, ParticleSystemScalingMode> scalingModeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.scalingMode = scalingModeChanger(module.scalingMode);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetScalingMode(this MainModule module, ParticleSystemScalingMode scalingMode)
        {
            module.scalingMode = scalingMode;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetScalingMode(this MainModule module, Func<ParticleSystemScalingMode, ParticleSystemScalingMode> scalingModeChanger)
        {
            module.scalingMode = scalingModeChanger(module.scalingMode);
            return module;
        }
        #endregion

        #region SimulationSpace
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainSimulationSpace(this ParticleSystem particleSystem, ParticleSystemSimulationSpace simulationSpace)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.simulationSpace = simulationSpace;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainSimulationSpace(this ParticleSystem particleSystem, Func<ParticleSystemSimulationSpace, ParticleSystemSimulationSpace> simulationSpaceChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.simulationSpace = simulationSpaceChanger(module.simulationSpace);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetSimulationSpace(this MainModule module, ParticleSystemSimulationSpace simulationSpace)
        {
            module.simulationSpace = simulationSpace;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetSimulationSpace(this MainModule module, Func<ParticleSystemSimulationSpace, ParticleSystemSimulationSpace> simulationSpaceChanger)
        {
            module.simulationSpace = simulationSpaceChanger(module.simulationSpace);
            return module;
        }
        #endregion

        #region SimulationSpeed
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainSimulationSpeed(this ParticleSystem particleSystem, float simulationSpeed)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.simulationSpeed = simulationSpeed;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainSimulationSpeed(this ParticleSystem particleSystem, Func<float, float> simulationSpeedChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.simulationSpeed = simulationSpeedChanger(module.simulationSpeed);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetSimulationSpeed(this MainModule module, float simulationSpeed)
        {
            module.simulationSpeed = simulationSpeed;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetSimulationSpeed(this MainModule module, Func<float, float> simulationSpeedChanger)
        {
            module.simulationSpeed = simulationSpeedChanger(module.simulationSpeed);
            return module;
        }
        #endregion

        #region StartColor
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartColor(this ParticleSystem particleSystem, MinMaxGradient startColor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startColor = startColor;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartColor(this ParticleSystem particleSystem, Func<MinMaxGradient, MinMaxGradient> startColorChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startColor = startColorChanger(module.startColor);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartColor(this MainModule module, MinMaxGradient startColor)
        {
            module.startColor = startColor;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartColor(this MainModule module, Func<MinMaxGradient, MinMaxGradient> startColorChanger)
        {
            module.startColor = startColorChanger(module.startColor);
            return module;
        }
        #endregion

        #region StartDelay
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartDelay(this ParticleSystem particleSystem, MinMaxCurve startDelay)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startDelay = startDelay;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartDelay(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startDelayChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startDelay = startDelayChanger(module.startDelay);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartDelay(this MainModule module, MinMaxCurve startDelay)
        {
            module.startDelay = startDelay;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartDelay(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startDelayChanger)
        {
            module.startDelay = startDelayChanger(module.startDelay);
            return module;
        }
        #endregion

        #region StartDelayMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartDelayMultiplier(this ParticleSystem particleSystem, float startDelayMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startDelayMultiplier = startDelayMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartDelayMultiplier(this ParticleSystem particleSystem, Func<float, float> startDelayMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startDelayMultiplier = startDelayMultiplierChanger(module.startDelayMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartDelayMultiplier(this MainModule module, float startDelayMultiplier)
        {
            module.startDelayMultiplier = startDelayMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartDelayMultiplier(this MainModule module, Func<float, float> startDelayMultiplierChanger)
        {
            module.startDelayMultiplier = startDelayMultiplierChanger(module.startDelayMultiplier);
            return module;
        }
        #endregion

        #region StartLifetime
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartLifetime(this ParticleSystem particleSystem, MinMaxCurve startLifetime)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startLifetime = startLifetime;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartLifetime(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startLifetimeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startLifetime = startLifetimeChanger(module.startLifetime);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartLifetime(this MainModule module, MinMaxCurve startLifetime)
        {
            module.startLifetime = startLifetime;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartLifetime(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startLifetimeChanger)
        {
            module.startLifetime = startLifetimeChanger(module.startLifetime);
            return module;
        }
        #endregion

        #region StartLifetimeMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartLifetimeMultiplier(this ParticleSystem particleSystem, float startLifetimeMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startLifetimeMultiplier = startLifetimeMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartLifetimeMultiplier(this ParticleSystem particleSystem, Func<float, float> startLifetimeMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startLifetimeMultiplier = startLifetimeMultiplierChanger(module.startLifetimeMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartLifetimeMultiplier(this MainModule module, float startLifetimeMultiplier)
        {
            module.startLifetimeMultiplier = startLifetimeMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartLifetimeMultiplier(this MainModule module, Func<float, float> startLifetimeMultiplierChanger)
        {
            module.startLifetimeMultiplier = startLifetimeMultiplierChanger(module.startLifetimeMultiplier);
            return module;
        }
        #endregion

        #region StartRotation
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotation(this ParticleSystem particleSystem, MinMaxCurve startRotation)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotation = startRotation;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotation(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startRotationChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotation = startRotationChanger(module.startRotation);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotation(this MainModule module, MinMaxCurve startRotation)
        {
            module.startRotation = startRotation;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotation(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startRotationChanger)
        {
            module.startRotation = startRotationChanger(module.startRotation);
            return module;
        }
        #endregion

        #region StartRotation3D
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotation3D(this ParticleSystem particleSystem, bool startRotation3D)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotation3D = startRotation3D;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotation3D(this ParticleSystem particleSystem, Func<bool, bool> startRotation3DChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotation3D = startRotation3DChanger(module.startRotation3D);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotation3D(this MainModule module, bool startRotation3D)
        {
            module.startRotation3D = startRotation3D;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotation3D(this MainModule module, Func<bool, bool> startRotation3DChanger)
        {
            module.startRotation3D = startRotation3DChanger(module.startRotation3D);
            return module;
        }
        #endregion

        #region StartRotationMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationMultiplier(this ParticleSystem particleSystem, float startRotationMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationMultiplier = startRotationMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationMultiplier(this ParticleSystem particleSystem, Func<float, float> startRotationMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationMultiplier = startRotationMultiplierChanger(module.startRotationMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationMultiplier(this MainModule module, float startRotationMultiplier)
        {
            module.startRotationMultiplier = startRotationMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationMultiplier(this MainModule module, Func<float, float> startRotationMultiplierChanger)
        {
            module.startRotationMultiplier = startRotationMultiplierChanger(module.startRotationMultiplier);
            return module;
        }
        #endregion

        #region StartRotationX
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationX(this ParticleSystem particleSystem, MinMaxCurve startRotationX)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationX = startRotationX;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startRotationXChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationX = startRotationXChanger(module.startRotationX);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationX(this MainModule module, MinMaxCurve startRotationX)
        {
            module.startRotationX = startRotationX;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationX(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startRotationXChanger)
        {
            module.startRotationX = startRotationXChanger(module.startRotationX);
            return module;
        }
        #endregion

        #region StartRotationXMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationXMultiplier(this ParticleSystem particleSystem, float startRotationXMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationXMultiplier = startRotationXMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationXMultiplier(this ParticleSystem particleSystem, Func<float, float> startRotationXMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationXMultiplier = startRotationXMultiplierChanger(module.startRotationXMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationXMultiplier(this MainModule module, float startRotationXMultiplier)
        {
            module.startRotationXMultiplier = startRotationXMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationXMultiplier(this MainModule module, Func<float, float> startRotationXMultiplierChanger)
        {
            module.startRotationXMultiplier = startRotationXMultiplierChanger(module.startRotationXMultiplier);
            return module;
        }
        #endregion

        #region StartRotationY
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationY(this ParticleSystem particleSystem, MinMaxCurve startRotationY)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationY = startRotationY;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startRotationYChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationY = startRotationYChanger(module.startRotationY);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationY(this MainModule module, MinMaxCurve startRotationY)
        {
            module.startRotationY = startRotationY;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationY(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startRotationYChanger)
        {
            module.startRotationY = startRotationYChanger(module.startRotationY);
            return module;
        }
        #endregion

        #region StartRotationYMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationYMultiplier(this ParticleSystem particleSystem, float startRotationYMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationYMultiplier = startRotationYMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationYMultiplier(this ParticleSystem particleSystem, Func<float, float> startRotationYMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationYMultiplier = startRotationYMultiplierChanger(module.startRotationYMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationYMultiplier(this MainModule module, float startRotationYMultiplier)
        {
            module.startRotationYMultiplier = startRotationYMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationYMultiplier(this MainModule module, Func<float, float> startRotationYMultiplierChanger)
        {
            module.startRotationYMultiplier = startRotationYMultiplierChanger(module.startRotationYMultiplier);
            return module;
        }
        #endregion

        #region StartRotationZ
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationZ(this ParticleSystem particleSystem, MinMaxCurve startRotationZ)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationZ = startRotationZ;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startRotationZChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationZ = startRotationZChanger(module.startRotationZ);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationZ(this MainModule module, MinMaxCurve startRotationZ)
        {
            module.startRotationZ = startRotationZ;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationZ(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startRotationZChanger)
        {
            module.startRotationZ = startRotationZChanger(module.startRotationZ);
            return module;
        }
        #endregion

        #region StartRotationZMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationZMultiplier(this ParticleSystem particleSystem, float startRotationZMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationZMultiplier = startRotationZMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartRotationZMultiplier(this ParticleSystem particleSystem, Func<float, float> startRotationZMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startRotationZMultiplier = startRotationZMultiplierChanger(module.startRotationZMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationZMultiplier(this MainModule module, float startRotationZMultiplier)
        {
            module.startRotationZMultiplier = startRotationZMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartRotationZMultiplier(this MainModule module, Func<float, float> startRotationZMultiplierChanger)
        {
            module.startRotationZMultiplier = startRotationZMultiplierChanger(module.startRotationZMultiplier);
            return module;
        }
        #endregion

        #region StartSize
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSize(this ParticleSystem particleSystem, MinMaxCurve startSize)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSize = startSize;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSize(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startSizeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSize = startSizeChanger(module.startSize);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSize(this MainModule module, MinMaxCurve startSize)
        {
            module.startSize = startSize;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSize(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startSizeChanger)
        {
            module.startSize = startSizeChanger(module.startSize);
            return module;
        }
        #endregion

        #region StartSize3D
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSize3D(this ParticleSystem particleSystem, bool startSize3D)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSize3D = startSize3D;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSize3D(this ParticleSystem particleSystem, Func<bool, bool> startSize3DChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSize3D = startSize3DChanger(module.startSize3D);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSize3D(this MainModule module, bool startSize3D)
        {
            module.startSize3D = startSize3D;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSize3D(this MainModule module, Func<bool, bool> startSize3DChanger)
        {
            module.startSize3D = startSize3DChanger(module.startSize3D);
            return module;
        }
        #endregion

        #region StartSizeMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeMultiplier(this ParticleSystem particleSystem, float startSizeMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeMultiplier = startSizeMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeMultiplier(this ParticleSystem particleSystem, Func<float, float> startSizeMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeMultiplier = startSizeMultiplierChanger(module.startSizeMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeMultiplier(this MainModule module, float startSizeMultiplier)
        {
            module.startSizeMultiplier = startSizeMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeMultiplier(this MainModule module, Func<float, float> startSizeMultiplierChanger)
        {
            module.startSizeMultiplier = startSizeMultiplierChanger(module.startSizeMultiplier);
            return module;
        }
        #endregion

        #region StartSizeX
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeX(this ParticleSystem particleSystem, MinMaxCurve startSizeX)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeX = startSizeX;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startSizeXChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeX = startSizeXChanger(module.startSizeX);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeX(this MainModule module, MinMaxCurve startSizeX)
        {
            module.startSizeX = startSizeX;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeX(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startSizeXChanger)
        {
            module.startSizeX = startSizeXChanger(module.startSizeX);
            return module;
        }
        #endregion

        #region StartSizeXMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeXMultiplier(this ParticleSystem particleSystem, float startSizeXMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeXMultiplier = startSizeXMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeXMultiplier(this ParticleSystem particleSystem, Func<float, float> startSizeXMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeXMultiplier = startSizeXMultiplierChanger(module.startSizeXMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeXMultiplier(this MainModule module, float startSizeXMultiplier)
        {
            module.startSizeXMultiplier = startSizeXMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeXMultiplier(this MainModule module, Func<float, float> startSizeXMultiplierChanger)
        {
            module.startSizeXMultiplier = startSizeXMultiplierChanger(module.startSizeXMultiplier);
            return module;
        }
        #endregion

        #region StartSizeY
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeY(this ParticleSystem particleSystem, MinMaxCurve startSizeY)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeY = startSizeY;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startSizeYChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeY = startSizeYChanger(module.startSizeY);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeY(this MainModule module, MinMaxCurve startSizeY)
        {
            module.startSizeY = startSizeY;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeY(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startSizeYChanger)
        {
            module.startSizeY = startSizeYChanger(module.startSizeY);
            return module;
        }
        #endregion

        #region StartSizeYMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeYMultiplier(this ParticleSystem particleSystem, float startSizeYMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeYMultiplier = startSizeYMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeYMultiplier(this ParticleSystem particleSystem, Func<float, float> startSizeYMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeYMultiplier = startSizeYMultiplierChanger(module.startSizeYMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeYMultiplier(this MainModule module, float startSizeYMultiplier)
        {
            module.startSizeYMultiplier = startSizeYMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeYMultiplier(this MainModule module, Func<float, float> startSizeYMultiplierChanger)
        {
            module.startSizeYMultiplier = startSizeYMultiplierChanger(module.startSizeYMultiplier);
            return module;
        }
        #endregion

        #region StartSizeZ
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeZ(this ParticleSystem particleSystem, MinMaxCurve startSizeZ)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeZ = startSizeZ;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startSizeZChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeZ = startSizeZChanger(module.startSizeZ);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeZ(this MainModule module, MinMaxCurve startSizeZ)
        {
            module.startSizeZ = startSizeZ;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeZ(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startSizeZChanger)
        {
            module.startSizeZ = startSizeZChanger(module.startSizeZ);
            return module;
        }
        #endregion

        #region StartSizeZMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeZMultiplier(this ParticleSystem particleSystem, float startSizeZMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeZMultiplier = startSizeZMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSizeZMultiplier(this ParticleSystem particleSystem, Func<float, float> startSizeZMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSizeZMultiplier = startSizeZMultiplierChanger(module.startSizeZMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeZMultiplier(this MainModule module, float startSizeZMultiplier)
        {
            module.startSizeZMultiplier = startSizeZMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSizeZMultiplier(this MainModule module, Func<float, float> startSizeZMultiplierChanger)
        {
            module.startSizeZMultiplier = startSizeZMultiplierChanger(module.startSizeZMultiplier);
            return module;
        }
        #endregion

        #region StartSpeed
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSpeed(this ParticleSystem particleSystem, MinMaxCurve startSpeed)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSpeed = startSpeed;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSpeed(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startSpeedChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSpeed = startSpeedChanger(module.startSpeed);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSpeed(this MainModule module, MinMaxCurve startSpeed)
        {
            module.startSpeed = startSpeed;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSpeed(this MainModule module, Func<MinMaxCurve, MinMaxCurve> startSpeedChanger)
        {
            module.startSpeed = startSpeedChanger(module.startSpeed);
            return module;
        }
        #endregion

        #region StartSpeedMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSpeedMultiplier(this ParticleSystem particleSystem, float startSpeedMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSpeedMultiplier = startSpeedMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStartSpeedMultiplier(this ParticleSystem particleSystem, Func<float, float> startSpeedMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.startSpeedMultiplier = startSpeedMultiplierChanger(module.startSpeedMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSpeedMultiplier(this MainModule module, float startSpeedMultiplier)
        {
            module.startSpeedMultiplier = startSpeedMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStartSpeedMultiplier(this MainModule module, Func<float, float> startSpeedMultiplierChanger)
        {
            module.startSpeedMultiplier = startSpeedMultiplierChanger(module.startSpeedMultiplier);
            return module;
        }
        #endregion

        #region StopAction
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStopAction(this ParticleSystem particleSystem, ParticleSystemStopAction stopAction)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.stopAction = stopAction;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainStopAction(this ParticleSystem particleSystem, Func<ParticleSystemStopAction, ParticleSystemStopAction> stopActionChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.stopAction = stopActionChanger(module.stopAction);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStopAction(this MainModule module, ParticleSystemStopAction stopAction)
        {
            module.stopAction = stopAction;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetStopAction(this MainModule module, Func<ParticleSystemStopAction, ParticleSystemStopAction> stopActionChanger)
        {
            module.stopAction = stopActionChanger(module.stopAction);
            return module;
        }
        #endregion

        #region UseUnscaledTime
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainUseUnscaledTime(this ParticleSystem particleSystem, bool useUnscaledTime)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.useUnscaledTime = useUnscaledTime;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainUseUnscaledTime(this ParticleSystem particleSystem, Func<bool, bool> useUnscaledTimeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.useUnscaledTime = useUnscaledTimeChanger(module.useUnscaledTime);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetUseUnscaledTime(this MainModule module, bool useUnscaledTime)
        {
            module.useUnscaledTime = useUnscaledTime;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetUseUnscaledTime(this MainModule module, Func<bool, bool> useUnscaledTimeChanger)
        {
            module.useUnscaledTime = useUnscaledTimeChanger(module.useUnscaledTime);
            return module;
        }
        #endregion

    }
}
