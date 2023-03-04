using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace OUCC.FluentParticleSystem
{
    public static class EmissionModuleExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditEmission(this ParticleSystem particleSystem, Action<ParticleSystem.EmissionModule> moduleEditor) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.emission);
            return particleSystem;
        }

        #region BurstCount
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionBurstCount(this ParticleSystem particleSystem, int burstCount) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.burstCount = burstCount;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetEmissionBurstCount(this ParticleSystem particleSystem, Func<int, int> burstCountChanger) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.emission;
            module.burstCount = burstCountChanger(module.burstCount);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem.EmissionModule SetBurstCount(this ParticleSystem.EmissionModule module, int burstCount) {
            module.burstCount = burstCount;    
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem.EmissionModule SetBurstCount(this ParticleSystem.EmissionModule module, Func<int, int> burstCountChanger) {
            module.burstCount = burstCountChanger(module.burstCount);
            return module;
        }
        #endregion
    }
}
