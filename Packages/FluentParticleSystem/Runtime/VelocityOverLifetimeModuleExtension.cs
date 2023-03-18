using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class VelocityOverLifetimeModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditVelocityOverLifetime(this ParticleSystem particleSystem, Action<VelocityOverLifetimeModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.velocityOverLifetime);
            return particleSystem;
        }

        #region Enabled
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetEnabled(this VelocityOverLifetimeModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetEnabled(this VelocityOverLifetimeModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region OrbitalOffsetX
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetX(this ParticleSystem particleSystem, MinMaxCurve orbitalOffsetX)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetX = orbitalOffsetX;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> orbitalOffsetXChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetX = orbitalOffsetXChanger(module.orbitalOffsetX);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetX(this VelocityOverLifetimeModule module, MinMaxCurve orbitalOffsetX)
        {
            module.orbitalOffsetX = orbitalOffsetX;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetX(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> orbitalOffsetXChanger)
        {
            module.orbitalOffsetX = orbitalOffsetXChanger(module.orbitalOffsetX);
            return module;
        }
        #endregion

        #region OrbitalOffsetXMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetXMultiplier(this ParticleSystem particleSystem, float orbitalOffsetXMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetXMultiplier = orbitalOffsetXMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetXMultiplier(this ParticleSystem particleSystem, Func<float, float> orbitalOffsetXMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetXMultiplier = orbitalOffsetXMultiplierChanger(module.orbitalOffsetXMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetXMultiplier(this VelocityOverLifetimeModule module, float orbitalOffsetXMultiplier)
        {
            module.orbitalOffsetXMultiplier = orbitalOffsetXMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetXMultiplier(this VelocityOverLifetimeModule module, Func<float, float> orbitalOffsetXMultiplierChanger)
        {
            module.orbitalOffsetXMultiplier = orbitalOffsetXMultiplierChanger(module.orbitalOffsetXMultiplier);
            return module;
        }
        #endregion

        #region OrbitalOffsetY
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetY(this ParticleSystem particleSystem, MinMaxCurve orbitalOffsetY)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetY = orbitalOffsetY;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> orbitalOffsetYChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetY = orbitalOffsetYChanger(module.orbitalOffsetY);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetY(this VelocityOverLifetimeModule module, MinMaxCurve orbitalOffsetY)
        {
            module.orbitalOffsetY = orbitalOffsetY;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetY(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> orbitalOffsetYChanger)
        {
            module.orbitalOffsetY = orbitalOffsetYChanger(module.orbitalOffsetY);
            return module;
        }
        #endregion

        #region OrbitalOffsetYMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetYMultiplier(this ParticleSystem particleSystem, float orbitalOffsetYMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetYMultiplier = orbitalOffsetYMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetYMultiplier(this ParticleSystem particleSystem, Func<float, float> orbitalOffsetYMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetYMultiplier = orbitalOffsetYMultiplierChanger(module.orbitalOffsetYMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetYMultiplier(this VelocityOverLifetimeModule module, float orbitalOffsetYMultiplier)
        {
            module.orbitalOffsetYMultiplier = orbitalOffsetYMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetYMultiplier(this VelocityOverLifetimeModule module, Func<float, float> orbitalOffsetYMultiplierChanger)
        {
            module.orbitalOffsetYMultiplier = orbitalOffsetYMultiplierChanger(module.orbitalOffsetYMultiplier);
            return module;
        }
        #endregion

        #region OrbitalOffsetZ
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetZ(this ParticleSystem particleSystem, MinMaxCurve orbitalOffsetZ)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetZ = orbitalOffsetZ;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> orbitalOffsetZChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetZ = orbitalOffsetZChanger(module.orbitalOffsetZ);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetZ(this VelocityOverLifetimeModule module, MinMaxCurve orbitalOffsetZ)
        {
            module.orbitalOffsetZ = orbitalOffsetZ;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetZ(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> orbitalOffsetZChanger)
        {
            module.orbitalOffsetZ = orbitalOffsetZChanger(module.orbitalOffsetZ);
            return module;
        }
        #endregion

        #region OrbitalOffsetZMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetZMultiplier(this ParticleSystem particleSystem, float orbitalOffsetZMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetZMultiplier = orbitalOffsetZMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetZMultiplier(this ParticleSystem particleSystem, Func<float, float> orbitalOffsetZMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetZMultiplier = orbitalOffsetZMultiplierChanger(module.orbitalOffsetZMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetZMultiplier(this VelocityOverLifetimeModule module, float orbitalOffsetZMultiplier)
        {
            module.orbitalOffsetZMultiplier = orbitalOffsetZMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetZMultiplier(this VelocityOverLifetimeModule module, Func<float, float> orbitalOffsetZMultiplierChanger)
        {
            module.orbitalOffsetZMultiplier = orbitalOffsetZMultiplierChanger(module.orbitalOffsetZMultiplier);
            return module;
        }
        #endregion

        #region OrbitalX
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalX(this ParticleSystem particleSystem, MinMaxCurve orbitalX)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalX = orbitalX;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> orbitalXChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalX = orbitalXChanger(module.orbitalX);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalX(this VelocityOverLifetimeModule module, MinMaxCurve orbitalX)
        {
            module.orbitalX = orbitalX;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalX(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> orbitalXChanger)
        {
            module.orbitalX = orbitalXChanger(module.orbitalX);
            return module;
        }
        #endregion

        #region OrbitalXMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalXMultiplier(this ParticleSystem particleSystem, float orbitalXMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalXMultiplier = orbitalXMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalXMultiplier(this ParticleSystem particleSystem, Func<float, float> orbitalXMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalXMultiplier = orbitalXMultiplierChanger(module.orbitalXMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalXMultiplier(this VelocityOverLifetimeModule module, float orbitalXMultiplier)
        {
            module.orbitalXMultiplier = orbitalXMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalXMultiplier(this VelocityOverLifetimeModule module, Func<float, float> orbitalXMultiplierChanger)
        {
            module.orbitalXMultiplier = orbitalXMultiplierChanger(module.orbitalXMultiplier);
            return module;
        }
        #endregion

        #region OrbitalY
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalY(this ParticleSystem particleSystem, MinMaxCurve orbitalY)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalY = orbitalY;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> orbitalYChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalY = orbitalYChanger(module.orbitalY);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalY(this VelocityOverLifetimeModule module, MinMaxCurve orbitalY)
        {
            module.orbitalY = orbitalY;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalY(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> orbitalYChanger)
        {
            module.orbitalY = orbitalYChanger(module.orbitalY);
            return module;
        }
        #endregion

        #region OrbitalYMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalYMultiplier(this ParticleSystem particleSystem, float orbitalYMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalYMultiplier = orbitalYMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalYMultiplier(this ParticleSystem particleSystem, Func<float, float> orbitalYMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalYMultiplier = orbitalYMultiplierChanger(module.orbitalYMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalYMultiplier(this VelocityOverLifetimeModule module, float orbitalYMultiplier)
        {
            module.orbitalYMultiplier = orbitalYMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalYMultiplier(this VelocityOverLifetimeModule module, Func<float, float> orbitalYMultiplierChanger)
        {
            module.orbitalYMultiplier = orbitalYMultiplierChanger(module.orbitalYMultiplier);
            return module;
        }
        #endregion

        #region OrbitalZ
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalZ(this ParticleSystem particleSystem, MinMaxCurve orbitalZ)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalZ = orbitalZ;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> orbitalZChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalZ = orbitalZChanger(module.orbitalZ);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalZ(this VelocityOverLifetimeModule module, MinMaxCurve orbitalZ)
        {
            module.orbitalZ = orbitalZ;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalZ(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> orbitalZChanger)
        {
            module.orbitalZ = orbitalZChanger(module.orbitalZ);
            return module;
        }
        #endregion

        #region OrbitalZMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalZMultiplier(this ParticleSystem particleSystem, float orbitalZMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalZMultiplier = orbitalZMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalZMultiplier(this ParticleSystem particleSystem, Func<float, float> orbitalZMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.orbitalZMultiplier = orbitalZMultiplierChanger(module.orbitalZMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalZMultiplier(this VelocityOverLifetimeModule module, float orbitalZMultiplier)
        {
            module.orbitalZMultiplier = orbitalZMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalZMultiplier(this VelocityOverLifetimeModule module, Func<float, float> orbitalZMultiplierChanger)
        {
            module.orbitalZMultiplier = orbitalZMultiplierChanger(module.orbitalZMultiplier);
            return module;
        }
        #endregion

        #region Radial
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeRadial(this ParticleSystem particleSystem, MinMaxCurve radial)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.radial = radial;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeRadial(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> radialChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.radial = radialChanger(module.radial);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetRadial(this VelocityOverLifetimeModule module, MinMaxCurve radial)
        {
            module.radial = radial;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetRadial(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> radialChanger)
        {
            module.radial = radialChanger(module.radial);
            return module;
        }
        #endregion

        #region RadialMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeRadialMultiplier(this ParticleSystem particleSystem, float radialMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.radialMultiplier = radialMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeRadialMultiplier(this ParticleSystem particleSystem, Func<float, float> radialMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.radialMultiplier = radialMultiplierChanger(module.radialMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetRadialMultiplier(this VelocityOverLifetimeModule module, float radialMultiplier)
        {
            module.radialMultiplier = radialMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetRadialMultiplier(this VelocityOverLifetimeModule module, Func<float, float> radialMultiplierChanger)
        {
            module.radialMultiplier = radialMultiplierChanger(module.radialMultiplier);
            return module;
        }
        #endregion

        #region Space
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeSpace(this ParticleSystem particleSystem, ParticleSystemSimulationSpace space)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.space = space;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeSpace(this ParticleSystem particleSystem, Func<ParticleSystemSimulationSpace, ParticleSystemSimulationSpace> spaceChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.space = spaceChanger(module.space);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetSpace(this VelocityOverLifetimeModule module, ParticleSystemSimulationSpace space)
        {
            module.space = space;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetSpace(this VelocityOverLifetimeModule module, Func<ParticleSystemSimulationSpace, ParticleSystemSimulationSpace> spaceChanger)
        {
            module.space = spaceChanger(module.space);
            return module;
        }
        #endregion

        #region SpeedModifier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeSpeedModifier(this ParticleSystem particleSystem, MinMaxCurve speedModifier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.speedModifier = speedModifier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeSpeedModifier(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> speedModifierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.speedModifier = speedModifierChanger(module.speedModifier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetSpeedModifier(this VelocityOverLifetimeModule module, MinMaxCurve speedModifier)
        {
            module.speedModifier = speedModifier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetSpeedModifier(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> speedModifierChanger)
        {
            module.speedModifier = speedModifierChanger(module.speedModifier);
            return module;
        }
        #endregion

        #region SpeedModifierMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeSpeedModifierMultiplier(this ParticleSystem particleSystem, float speedModifierMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.speedModifierMultiplier = speedModifierMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeSpeedModifierMultiplier(this ParticleSystem particleSystem, Func<float, float> speedModifierMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.speedModifierMultiplier = speedModifierMultiplierChanger(module.speedModifierMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetSpeedModifierMultiplier(this VelocityOverLifetimeModule module, float speedModifierMultiplier)
        {
            module.speedModifierMultiplier = speedModifierMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetSpeedModifierMultiplier(this VelocityOverLifetimeModule module, Func<float, float> speedModifierMultiplierChanger)
        {
            module.speedModifierMultiplier = speedModifierMultiplierChanger(module.speedModifierMultiplier);
            return module;
        }
        #endregion

        #region X
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeX(this ParticleSystem particleSystem, MinMaxCurve x)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.x = x;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.x = xChanger(module.x);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetX(this VelocityOverLifetimeModule module, MinMaxCurve x)
        {
            module.x = x;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetX(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            module.x = xChanger(module.x);
            return module;
        }
        #endregion

        #region XMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeXMultiplier(this ParticleSystem particleSystem, float xMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.xMultiplier = xMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeXMultiplier(this ParticleSystem particleSystem, Func<float, float> xMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetXMultiplier(this VelocityOverLifetimeModule module, float xMultiplier)
        {
            module.xMultiplier = xMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetXMultiplier(this VelocityOverLifetimeModule module, Func<float, float> xMultiplierChanger)
        {
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return module;
        }
        #endregion

        #region Y
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeY(this ParticleSystem particleSystem, MinMaxCurve y)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.y = y;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.y = yChanger(module.y);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetY(this VelocityOverLifetimeModule module, MinMaxCurve y)
        {
            module.y = y;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetY(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            module.y = yChanger(module.y);
            return module;
        }
        #endregion

        #region YMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeYMultiplier(this ParticleSystem particleSystem, float yMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.yMultiplier = yMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeYMultiplier(this ParticleSystem particleSystem, Func<float, float> yMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetYMultiplier(this VelocityOverLifetimeModule module, float yMultiplier)
        {
            module.yMultiplier = yMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetYMultiplier(this VelocityOverLifetimeModule module, Func<float, float> yMultiplierChanger)
        {
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return module;
        }
        #endregion

        #region Z
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeZ(this ParticleSystem particleSystem, MinMaxCurve z)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.z = z;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.z = zChanger(module.z);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetZ(this VelocityOverLifetimeModule module, MinMaxCurve z)
        {
            module.z = z;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetZ(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            module.z = zChanger(module.z);
            return module;
        }
        #endregion

        #region ZMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeZMultiplier(this ParticleSystem particleSystem, float zMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.zMultiplier = zMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeZMultiplier(this ParticleSystem particleSystem, Func<float, float> zMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.velocityOverLifetime;
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetZMultiplier(this VelocityOverLifetimeModule module, float zMultiplier)
        {
            module.zMultiplier = zMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetZMultiplier(this VelocityOverLifetimeModule module, Func<float, float> zMultiplierChanger)
        {
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return module;
        }
        #endregion
#endif
    }
}
