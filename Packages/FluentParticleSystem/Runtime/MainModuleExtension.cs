using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace OUCC.FluentParticleSystem
{
    public static class MainModuleExtension
    {
        #region Duration
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainDuration(this ParticleSystem particleSystem, float duration) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.duration = duration;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainDuration(this ParticleSystem particleSystem, Func<float, float> durationChanger) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.duration = durationChanger(module.duration);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem.MainModule SetDuration(this ParticleSystem.MainModule module, float duration) {
            module.duration = duration;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem.MainModule SetDuration(this ParticleSystem.MainModule module, Func<float, float> durationChanger) {
            module.duration = durationChanger(module.duration);
            return module;
        }
        #endregion

        #region Looping
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainLooping(this ParticleSystem particleSystem, bool looping) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.loop = looping;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainLooping(this ParticleSystem particleSystem, Func<bool, bool> loopingChanger) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.loop = loopingChanger(module.loop);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem.MainModule SetLooping(this ParticleSystem.MainModule module, bool looping) {
            module.loop = looping;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem.MainModule SetLooping(this ParticleSystem.MainModule module, Func<bool, bool> loopingChanger) {
            module.loop = loopingChanger(module.loop);
            return module;
        }
        #endregion

        #region Prewarm
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainPrewarm(this ParticleSystem particleSystem, bool prewarm) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.prewarm = prewarm;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetMainPrewarm(this ParticleSystem particleSystem, Func<bool, bool> prewarmChanger) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.main;
            module.prewarm = prewarmChanger(module.prewarm);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem.MainModule SetPrewarm(this ParticleSystem.MainModule module, bool prewarm) {
            module.prewarm = prewarm;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem.MainModule SetPrewarm(this ParticleSystem.MainModule module, Func<bool, bool> prewarmChanger) {
            module.prewarm = prewarmChanger(module.prewarm);
            return module;
        }
        #endregion
    }
}
