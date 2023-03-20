using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class VelocityOverLifetimeModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.velocityOverLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditVelocityOverLifetime(this ParticleSystem particleSystem, Action<VelocityOverLifetimeModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.velocityOverLifetime);
            return particleSystem;
        }

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetEnabled(this VelocityOverLifetimeModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetEnabled(this VelocityOverLifetimeModule module, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region OrbitalOffsetX
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalOffsetX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetX(this ParticleSystem particleSystem, MinMaxCurve orbitalOffsetX)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetX = orbitalOffsetX;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalOffsetX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> orbitalOffsetXChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(orbitalOffsetXChanger != null, "orbitalOffsetXChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetX = orbitalOffsetXChanger(module.orbitalOffsetX);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalOffsetX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetX(this VelocityOverLifetimeModule module, MinMaxCurve orbitalOffsetX)
        {
            module.orbitalOffsetX = orbitalOffsetX;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalOffsetX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetX(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> orbitalOffsetXChanger)
        {
            Debug.Assert(orbitalOffsetXChanger != null, "orbitalOffsetXChanger cannot be null");
            module.orbitalOffsetX = orbitalOffsetXChanger(module.orbitalOffsetX);
            return module;
        }
        #endregion

        #region OrbitalOffsetXMultiplier
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalOffsetXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetXMultiplier(this ParticleSystem particleSystem, float orbitalOffsetXMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetXMultiplier = orbitalOffsetXMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalOffsetXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetXMultiplier(this ParticleSystem particleSystem, Func<float, float> orbitalOffsetXMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(orbitalOffsetXMultiplierChanger != null, "orbitalOffsetXMultiplierChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetXMultiplier = orbitalOffsetXMultiplierChanger(module.orbitalOffsetXMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalOffsetXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetXMultiplier(this VelocityOverLifetimeModule module, float orbitalOffsetXMultiplier)
        {
            module.orbitalOffsetXMultiplier = orbitalOffsetXMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalOffsetXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetXMultiplier(this VelocityOverLifetimeModule module, Func<float, float> orbitalOffsetXMultiplierChanger)
        {
            Debug.Assert(orbitalOffsetXMultiplierChanger != null, "orbitalOffsetXMultiplierChanger cannot be null");
            module.orbitalOffsetXMultiplier = orbitalOffsetXMultiplierChanger(module.orbitalOffsetXMultiplier);
            return module;
        }
        #endregion

        #region OrbitalOffsetY
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalOffsetY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetY(this ParticleSystem particleSystem, MinMaxCurve orbitalOffsetY)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetY = orbitalOffsetY;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalOffsetY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> orbitalOffsetYChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(orbitalOffsetYChanger != null, "orbitalOffsetYChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetY = orbitalOffsetYChanger(module.orbitalOffsetY);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalOffsetY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetY(this VelocityOverLifetimeModule module, MinMaxCurve orbitalOffsetY)
        {
            module.orbitalOffsetY = orbitalOffsetY;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalOffsetY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetY(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> orbitalOffsetYChanger)
        {
            Debug.Assert(orbitalOffsetYChanger != null, "orbitalOffsetYChanger cannot be null");
            module.orbitalOffsetY = orbitalOffsetYChanger(module.orbitalOffsetY);
            return module;
        }
        #endregion

        #region OrbitalOffsetYMultiplier
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalOffsetYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetYMultiplier(this ParticleSystem particleSystem, float orbitalOffsetYMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetYMultiplier = orbitalOffsetYMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalOffsetYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetYMultiplier(this ParticleSystem particleSystem, Func<float, float> orbitalOffsetYMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(orbitalOffsetYMultiplierChanger != null, "orbitalOffsetYMultiplierChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetYMultiplier = orbitalOffsetYMultiplierChanger(module.orbitalOffsetYMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalOffsetYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetYMultiplier(this VelocityOverLifetimeModule module, float orbitalOffsetYMultiplier)
        {
            module.orbitalOffsetYMultiplier = orbitalOffsetYMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalOffsetYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetYMultiplier(this VelocityOverLifetimeModule module, Func<float, float> orbitalOffsetYMultiplierChanger)
        {
            Debug.Assert(orbitalOffsetYMultiplierChanger != null, "orbitalOffsetYMultiplierChanger cannot be null");
            module.orbitalOffsetYMultiplier = orbitalOffsetYMultiplierChanger(module.orbitalOffsetYMultiplier);
            return module;
        }
        #endregion

        #region OrbitalOffsetZ
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalOffsetZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetZ(this ParticleSystem particleSystem, MinMaxCurve orbitalOffsetZ)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetZ = orbitalOffsetZ;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalOffsetZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> orbitalOffsetZChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(orbitalOffsetZChanger != null, "orbitalOffsetZChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetZ = orbitalOffsetZChanger(module.orbitalOffsetZ);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalOffsetZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetZ(this VelocityOverLifetimeModule module, MinMaxCurve orbitalOffsetZ)
        {
            module.orbitalOffsetZ = orbitalOffsetZ;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalOffsetZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetZ(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> orbitalOffsetZChanger)
        {
            Debug.Assert(orbitalOffsetZChanger != null, "orbitalOffsetZChanger cannot be null");
            module.orbitalOffsetZ = orbitalOffsetZChanger(module.orbitalOffsetZ);
            return module;
        }
        #endregion

        #region OrbitalOffsetZMultiplier
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalOffsetZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetZMultiplier(this ParticleSystem particleSystem, float orbitalOffsetZMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetZMultiplier = orbitalOffsetZMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalOffsetZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalOffsetZMultiplier(this ParticleSystem particleSystem, Func<float, float> orbitalOffsetZMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(orbitalOffsetZMultiplierChanger != null, "orbitalOffsetZMultiplierChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalOffsetZMultiplier = orbitalOffsetZMultiplierChanger(module.orbitalOffsetZMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalOffsetZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetZMultiplier(this VelocityOverLifetimeModule module, float orbitalOffsetZMultiplier)
        {
            module.orbitalOffsetZMultiplier = orbitalOffsetZMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalOffsetZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalOffsetZMultiplier(this VelocityOverLifetimeModule module, Func<float, float> orbitalOffsetZMultiplierChanger)
        {
            Debug.Assert(orbitalOffsetZMultiplierChanger != null, "orbitalOffsetZMultiplierChanger cannot be null");
            module.orbitalOffsetZMultiplier = orbitalOffsetZMultiplierChanger(module.orbitalOffsetZMultiplier);
            return module;
        }
        #endregion

        #region OrbitalX
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalX(this ParticleSystem particleSystem, MinMaxCurve orbitalX)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalX = orbitalX;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> orbitalXChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(orbitalXChanger != null, "orbitalXChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalX = orbitalXChanger(module.orbitalX);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalX(this VelocityOverLifetimeModule module, MinMaxCurve orbitalX)
        {
            module.orbitalX = orbitalX;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalX(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> orbitalXChanger)
        {
            Debug.Assert(orbitalXChanger != null, "orbitalXChanger cannot be null");
            module.orbitalX = orbitalXChanger(module.orbitalX);
            return module;
        }
        #endregion

        #region OrbitalXMultiplier
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalXMultiplier(this ParticleSystem particleSystem, float orbitalXMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalXMultiplier = orbitalXMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalXMultiplier(this ParticleSystem particleSystem, Func<float, float> orbitalXMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(orbitalXMultiplierChanger != null, "orbitalXMultiplierChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalXMultiplier = orbitalXMultiplierChanger(module.orbitalXMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalXMultiplier(this VelocityOverLifetimeModule module, float orbitalXMultiplier)
        {
            module.orbitalXMultiplier = orbitalXMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalXMultiplier(this VelocityOverLifetimeModule module, Func<float, float> orbitalXMultiplierChanger)
        {
            Debug.Assert(orbitalXMultiplierChanger != null, "orbitalXMultiplierChanger cannot be null");
            module.orbitalXMultiplier = orbitalXMultiplierChanger(module.orbitalXMultiplier);
            return module;
        }
        #endregion

        #region OrbitalY
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalY(this ParticleSystem particleSystem, MinMaxCurve orbitalY)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalY = orbitalY;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> orbitalYChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(orbitalYChanger != null, "orbitalYChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalY = orbitalYChanger(module.orbitalY);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalY(this VelocityOverLifetimeModule module, MinMaxCurve orbitalY)
        {
            module.orbitalY = orbitalY;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalY(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> orbitalYChanger)
        {
            Debug.Assert(orbitalYChanger != null, "orbitalYChanger cannot be null");
            module.orbitalY = orbitalYChanger(module.orbitalY);
            return module;
        }
        #endregion

        #region OrbitalYMultiplier
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalYMultiplier(this ParticleSystem particleSystem, float orbitalYMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalYMultiplier = orbitalYMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalYMultiplier(this ParticleSystem particleSystem, Func<float, float> orbitalYMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(orbitalYMultiplierChanger != null, "orbitalYMultiplierChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalYMultiplier = orbitalYMultiplierChanger(module.orbitalYMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalYMultiplier(this VelocityOverLifetimeModule module, float orbitalYMultiplier)
        {
            module.orbitalYMultiplier = orbitalYMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalYMultiplier(this VelocityOverLifetimeModule module, Func<float, float> orbitalYMultiplierChanger)
        {
            Debug.Assert(orbitalYMultiplierChanger != null, "orbitalYMultiplierChanger cannot be null");
            module.orbitalYMultiplier = orbitalYMultiplierChanger(module.orbitalYMultiplier);
            return module;
        }
        #endregion

        #region OrbitalZ
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalZ(this ParticleSystem particleSystem, MinMaxCurve orbitalZ)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalZ = orbitalZ;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> orbitalZChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(orbitalZChanger != null, "orbitalZChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalZ = orbitalZChanger(module.orbitalZ);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalZ(this VelocityOverLifetimeModule module, MinMaxCurve orbitalZ)
        {
            module.orbitalZ = orbitalZ;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalZ(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> orbitalZChanger)
        {
            Debug.Assert(orbitalZChanger != null, "orbitalZChanger cannot be null");
            module.orbitalZ = orbitalZChanger(module.orbitalZ);
            return module;
        }
        #endregion

        #region OrbitalZMultiplier
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalZMultiplier(this ParticleSystem particleSystem, float orbitalZMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalZMultiplier = orbitalZMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeOrbitalZMultiplier(this ParticleSystem particleSystem, Func<float, float> orbitalZMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(orbitalZMultiplierChanger != null, "orbitalZMultiplierChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.orbitalZMultiplier = orbitalZMultiplierChanger(module.orbitalZMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.orbitalZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalZMultiplier(this VelocityOverLifetimeModule module, float orbitalZMultiplier)
        {
            module.orbitalZMultiplier = orbitalZMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.orbitalZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetOrbitalZMultiplier(this VelocityOverLifetimeModule module, Func<float, float> orbitalZMultiplierChanger)
        {
            Debug.Assert(orbitalZMultiplierChanger != null, "orbitalZMultiplierChanger cannot be null");
            module.orbitalZMultiplier = orbitalZMultiplierChanger(module.orbitalZMultiplier);
            return module;
        }
        #endregion

        #region Radial
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.radial"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeRadial(this ParticleSystem particleSystem, MinMaxCurve radial)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.radial = radial;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.radial"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeRadial(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> radialChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(radialChanger != null, "radialChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.radial = radialChanger(module.radial);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.radial"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetRadial(this VelocityOverLifetimeModule module, MinMaxCurve radial)
        {
            module.radial = radial;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.radial"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetRadial(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> radialChanger)
        {
            Debug.Assert(radialChanger != null, "radialChanger cannot be null");
            module.radial = radialChanger(module.radial);
            return module;
        }
        #endregion

        #region RadialMultiplier
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.radialMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeRadialMultiplier(this ParticleSystem particleSystem, float radialMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.radialMultiplier = radialMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.radialMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeRadialMultiplier(this ParticleSystem particleSystem, Func<float, float> radialMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(radialMultiplierChanger != null, "radialMultiplierChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.radialMultiplier = radialMultiplierChanger(module.radialMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.radialMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetRadialMultiplier(this VelocityOverLifetimeModule module, float radialMultiplier)
        {
            module.radialMultiplier = radialMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.radialMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetRadialMultiplier(this VelocityOverLifetimeModule module, Func<float, float> radialMultiplierChanger)
        {
            Debug.Assert(radialMultiplierChanger != null, "radialMultiplierChanger cannot be null");
            module.radialMultiplier = radialMultiplierChanger(module.radialMultiplier);
            return module;
        }
        #endregion

        #region Space
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.space"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeSpace(this ParticleSystem particleSystem, ParticleSystemSimulationSpace space)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.space = space;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.space"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeSpace(this ParticleSystem particleSystem, Func<ParticleSystemSimulationSpace, ParticleSystemSimulationSpace> spaceChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(spaceChanger != null, "spaceChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.space = spaceChanger(module.space);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.space"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetSpace(this VelocityOverLifetimeModule module, ParticleSystemSimulationSpace space)
        {
            module.space = space;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.space"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetSpace(this VelocityOverLifetimeModule module, Func<ParticleSystemSimulationSpace, ParticleSystemSimulationSpace> spaceChanger)
        {
            Debug.Assert(spaceChanger != null, "spaceChanger cannot be null");
            module.space = spaceChanger(module.space);
            return module;
        }
        #endregion

        #region SpeedModifier
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.speedModifier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeSpeedModifier(this ParticleSystem particleSystem, MinMaxCurve speedModifier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.speedModifier = speedModifier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.speedModifier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeSpeedModifier(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> speedModifierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(speedModifierChanger != null, "speedModifierChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.speedModifier = speedModifierChanger(module.speedModifier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.speedModifier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetSpeedModifier(this VelocityOverLifetimeModule module, MinMaxCurve speedModifier)
        {
            module.speedModifier = speedModifier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.speedModifier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetSpeedModifier(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> speedModifierChanger)
        {
            Debug.Assert(speedModifierChanger != null, "speedModifierChanger cannot be null");
            module.speedModifier = speedModifierChanger(module.speedModifier);
            return module;
        }
        #endregion

        #region SpeedModifierMultiplier
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.speedModifierMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeSpeedModifierMultiplier(this ParticleSystem particleSystem, float speedModifierMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.speedModifierMultiplier = speedModifierMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.speedModifierMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeSpeedModifierMultiplier(this ParticleSystem particleSystem, Func<float, float> speedModifierMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(speedModifierMultiplierChanger != null, "speedModifierMultiplierChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.speedModifierMultiplier = speedModifierMultiplierChanger(module.speedModifierMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.speedModifierMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetSpeedModifierMultiplier(this VelocityOverLifetimeModule module, float speedModifierMultiplier)
        {
            module.speedModifierMultiplier = speedModifierMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.speedModifierMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetSpeedModifierMultiplier(this VelocityOverLifetimeModule module, Func<float, float> speedModifierMultiplierChanger)
        {
            Debug.Assert(speedModifierMultiplierChanger != null, "speedModifierMultiplierChanger cannot be null");
            module.speedModifierMultiplier = speedModifierMultiplierChanger(module.speedModifierMultiplier);
            return module;
        }
        #endregion

        #region X
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeX(this ParticleSystem particleSystem, MinMaxCurve x)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.x = x;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(xChanger != null, "xChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.x = xChanger(module.x);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetX(this VelocityOverLifetimeModule module, MinMaxCurve x)
        {
            module.x = x;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetX(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            Debug.Assert(xChanger != null, "xChanger cannot be null");
            module.x = xChanger(module.x);
            return module;
        }
        #endregion

        #region XMultiplier
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeXMultiplier(this ParticleSystem particleSystem, float xMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.xMultiplier = xMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeXMultiplier(this ParticleSystem particleSystem, Func<float, float> xMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(xMultiplierChanger != null, "xMultiplierChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetXMultiplier(this VelocityOverLifetimeModule module, float xMultiplier)
        {
            module.xMultiplier = xMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetXMultiplier(this VelocityOverLifetimeModule module, Func<float, float> xMultiplierChanger)
        {
            Debug.Assert(xMultiplierChanger != null, "xMultiplierChanger cannot be null");
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return module;
        }
        #endregion

        #region Y
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeY(this ParticleSystem particleSystem, MinMaxCurve y)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.y = y;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(yChanger != null, "yChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.y = yChanger(module.y);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetY(this VelocityOverLifetimeModule module, MinMaxCurve y)
        {
            module.y = y;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetY(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            Debug.Assert(yChanger != null, "yChanger cannot be null");
            module.y = yChanger(module.y);
            return module;
        }
        #endregion

        #region YMultiplier
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeYMultiplier(this ParticleSystem particleSystem, float yMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.yMultiplier = yMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeYMultiplier(this ParticleSystem particleSystem, Func<float, float> yMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(yMultiplierChanger != null, "yMultiplierChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetYMultiplier(this VelocityOverLifetimeModule module, float yMultiplier)
        {
            module.yMultiplier = yMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetYMultiplier(this VelocityOverLifetimeModule module, Func<float, float> yMultiplierChanger)
        {
            Debug.Assert(yMultiplierChanger != null, "yMultiplierChanger cannot be null");
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return module;
        }
        #endregion

        #region Z
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeZ(this ParticleSystem particleSystem, MinMaxCurve z)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.z = z;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(zChanger != null, "zChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.z = zChanger(module.z);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetZ(this VelocityOverLifetimeModule module, MinMaxCurve z)
        {
            module.z = z;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetZ(this VelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            Debug.Assert(zChanger != null, "zChanger cannot be null");
            module.z = zChanger(module.z);
            return module;
        }
        #endregion

        #region ZMultiplier
        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeZMultiplier(this ParticleSystem particleSystem, float zMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.zMultiplier = zMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetVelocityOverLifetimeZMultiplier(this ParticleSystem particleSystem, Func<float, float> zMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(zMultiplierChanger != null, "zMultiplierChanger cannot be null");
            var module = particleSystem.velocityOverLifetime;
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="VelocityOverLifetimeModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetZMultiplier(this VelocityOverLifetimeModule module, float zMultiplier)
        {
            module.zMultiplier = zMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="VelocityOverLifetimeModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VelocityOverLifetimeModule SetZMultiplier(this VelocityOverLifetimeModule module, Func<float, float> zMultiplierChanger)
        {
            Debug.Assert(zMultiplierChanger != null, "zMultiplierChanger cannot be null");
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return module;
        }
        #endregion
#endif
    }
}
