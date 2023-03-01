using System;
using UnityEngine;

namespace FluentParticleSystem
{
    public static class MainParticleSystemExtension
    {
        public static ParticleSystem SetMainDuration(this ParticleSystem particleSystem, float duration) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var main = particleSystem.main;
            main.duration = duration;
            return particleSystem;
        }

        public static ParticleSystem SetMainDuration(this ParticleSystem particleSystem, Func<float, float> durationChanger) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var main = particleSystem.main;
            main.duration = durationChanger(main.duration);
            return particleSystem;
        }

        public static ParticleSystem EditMain(this ParticleSystem particleSystem, Action<ParticleSystem.MainModule> mainModuleEditor) {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            mainModuleEditor(particleSystem.main);
            return particleSystem;
        }

        public static ParticleSystem.MainModule SetDuration(this ParticleSystem.MainModule mainModule, float duration) {
            mainModule.duration = duration;
            return mainModule;
        }
    }
}