using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class SubEmittersModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.subEmitters"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditSubEmitters(this ParticleSystem particleSystem, Action<SubEmittersModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.subEmitters);
            return particleSystem;
        }

        #region Birth0
        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.birth0"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("birth0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersBirth0(this ParticleSystem particleSystem, ParticleSystem birth0)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.birth0 = birth0;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.birth0"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("birth0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersBirth0(this ParticleSystem particleSystem, Func<ParticleSystem, ParticleSystem> birth0Changer)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.birth0 = birth0Changer(module.birth0);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.birth0"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("birth0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetBirth0(this SubEmittersModule module, ParticleSystem birth0)
        {
            module.birth0 = birth0;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.birth0"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("birth0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetBirth0(this SubEmittersModule module, Func<ParticleSystem, ParticleSystem> birth0Changer)
        {
            module.birth0 = birth0Changer(module.birth0);
            return module;
        }
        #endregion

        #region Birth1
        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.birth1"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("birth1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersBirth1(this ParticleSystem particleSystem, ParticleSystem birth1)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.birth1 = birth1;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.birth1"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("birth1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersBirth1(this ParticleSystem particleSystem, Func<ParticleSystem, ParticleSystem> birth1Changer)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.birth1 = birth1Changer(module.birth1);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.birth1"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("birth1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetBirth1(this SubEmittersModule module, ParticleSystem birth1)
        {
            module.birth1 = birth1;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.birth1"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("birth1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetBirth1(this SubEmittersModule module, Func<ParticleSystem, ParticleSystem> birth1Changer)
        {
            module.birth1 = birth1Changer(module.birth1);
            return module;
        }
        #endregion

        #region Collision0
        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.collision0"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("collision0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersCollision0(this ParticleSystem particleSystem, ParticleSystem collision0)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.collision0 = collision0;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.collision0"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("collision0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersCollision0(this ParticleSystem particleSystem, Func<ParticleSystem, ParticleSystem> collision0Changer)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.collision0 = collision0Changer(module.collision0);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.collision0"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("collision0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetCollision0(this SubEmittersModule module, ParticleSystem collision0)
        {
            module.collision0 = collision0;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.collision0"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("collision0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetCollision0(this SubEmittersModule module, Func<ParticleSystem, ParticleSystem> collision0Changer)
        {
            module.collision0 = collision0Changer(module.collision0);
            return module;
        }
        #endregion

        #region Collision1
        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.collision1"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("collision1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersCollision1(this ParticleSystem particleSystem, ParticleSystem collision1)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.collision1 = collision1;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.collision1"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("collision1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersCollision1(this ParticleSystem particleSystem, Func<ParticleSystem, ParticleSystem> collision1Changer)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.collision1 = collision1Changer(module.collision1);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.collision1"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("collision1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetCollision1(this SubEmittersModule module, ParticleSystem collision1)
        {
            module.collision1 = collision1;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.collision1"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("collision1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetCollision1(this SubEmittersModule module, Func<ParticleSystem, ParticleSystem> collision1Changer)
        {
            module.collision1 = collision1Changer(module.collision1);
            return module;
        }
        #endregion

        #region Death0
        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.death0"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("death0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersDeath0(this ParticleSystem particleSystem, ParticleSystem death0)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.death0 = death0;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.death0"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("death0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersDeath0(this ParticleSystem particleSystem, Func<ParticleSystem, ParticleSystem> death0Changer)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.death0 = death0Changer(module.death0);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.death0"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("death0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetDeath0(this SubEmittersModule module, ParticleSystem death0)
        {
            module.death0 = death0;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.death0"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("death0 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetDeath0(this SubEmittersModule module, Func<ParticleSystem, ParticleSystem> death0Changer)
        {
            module.death0 = death0Changer(module.death0);
            return module;
        }
        #endregion

        #region Death1
        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.death1"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("death1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersDeath1(this ParticleSystem particleSystem, ParticleSystem death1)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.death1 = death1;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.death1"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("death1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersDeath1(this ParticleSystem particleSystem, Func<ParticleSystem, ParticleSystem> death1Changer)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.death1 = death1Changer(module.death1);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.death1"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("death1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetDeath1(this SubEmittersModule module, ParticleSystem death1)
        {
            module.death1 = death1;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.death1"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("death1 property is deprecated. Use AddSubEmitter, RemoveSubEmitter, SetSubEmitterSystem and GetSubEmitterSystem instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetDeath1(this SubEmittersModule module, Func<ParticleSystem, ParticleSystem> death1Changer)
        {
            module.death1 = death1Changer(module.death1);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSubEmittersEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.subEmitters;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SubEmittersModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetEnabled(this SubEmittersModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SubEmittersModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SubEmittersModule SetEnabled(this SubEmittersModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion
#endif
    }
}
