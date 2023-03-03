using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace OUCC.FluentParticleSystem
{
    public static class ParticleSystemExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditMain(this ParticleSystem particleSystem, Action<ParticleSystem.MainModule> mainModuleEditor) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            mainModuleEditor(particleSystem.main);
            return particleSystem;
        }
    }
}