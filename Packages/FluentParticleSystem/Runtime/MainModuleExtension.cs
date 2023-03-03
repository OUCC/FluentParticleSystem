using System;
using System.Runtime.CompilerServices;
using UnityEngine;

using MainModule = UnityEngine.ParticleSystem.MainModule;

namespace OUCC.FluentParticleSystem
{
    public static class MainModuleExtension
    {
        #region duration
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainDuration(this ParticleSystem particleSystem, float duration) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var main = particleSystem.main;
            main.duration = duration;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainDuration(this ParticleSystem particleSystem, Func<float, float> durationChanger) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var main = particleSystem.main;
            main.duration = durationChanger(main.duration);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetDuration(this ref MainModule main, float duration) {
            main.duration = duration;
            return main;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static MainModule SetDuration(this MainModule main, Func<float, float> durationChanger) {
            main.duration = durationChanger(main.duration);
            return main;
        }
        #endregion
    }
}
