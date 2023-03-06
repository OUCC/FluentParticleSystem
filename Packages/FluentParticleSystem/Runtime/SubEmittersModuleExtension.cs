using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class SubEmittersModuleExtension
    {
#if (UNITY_2021_3)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditSubEmitters(this ParticleSystem particleSystem, Action<SubEmittersModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.subEmitters);
            return particleSystem;
        }

        #region Enabled
#if (UNITY_2021_3)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetEnabled(this SubEmittersModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetEnabled(this SubEmittersModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
#endif
        #endregion
#endif
    }
}
