#if UNITY_2020_2_OR_NEWER
#nullable enable
#endif
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class TriggerModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.trigger"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditTrigger(this ParticleSystem particleSystem, Action<TriggerModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.trigger);
            return particleSystem;
        }
#endif

#if UNITY_2020_3_OR_NEWER
        #region ColliderQueryMode
        /// <summary>
        /// Assign a value to <see cref="TriggerModule.colliderQueryMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerColliderQueryMode(this ParticleSystem particleSystem, ParticleSystemColliderQueryMode colliderQueryMode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.trigger;
            module.colliderQueryMode = colliderQueryMode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.colliderQueryMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerColliderQueryMode(this ParticleSystem particleSystem, Func<ParticleSystemColliderQueryMode, ParticleSystemColliderQueryMode> colliderQueryModeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(colliderQueryModeChanger != null, "colliderQueryModeChanger cannot be null");
            var module = particleSystem.trigger;
            module.colliderQueryMode = colliderQueryModeChanger(module.colliderQueryMode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TriggerModule.colliderQueryMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetColliderQueryMode(this TriggerModule module, ParticleSystemColliderQueryMode colliderQueryMode)
        {
            module.colliderQueryMode = colliderQueryMode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.colliderQueryMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetColliderQueryMode(this TriggerModule module, Func<ParticleSystemColliderQueryMode, ParticleSystemColliderQueryMode> colliderQueryModeChanger)
        {
            Debug.Assert(colliderQueryModeChanger != null, "colliderQueryModeChanger cannot be null");
            module.colliderQueryMode = colliderQueryModeChanger(module.colliderQueryMode);
            return module;
        }
        #endregion
#endif

#if UNITY_2018_4_OR_NEWER
        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="TriggerModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.trigger;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.trigger;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TriggerModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetEnabled(this TriggerModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetEnabled(this TriggerModule module, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Enter
        /// <summary>
        /// Assign a value to <see cref="TriggerModule.enter"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerEnter(this ParticleSystem particleSystem, ParticleSystemOverlapAction enter)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.trigger;
            module.enter = enter;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.enter"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerEnter(this ParticleSystem particleSystem, Func<ParticleSystemOverlapAction, ParticleSystemOverlapAction> enterChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enterChanger != null, "enterChanger cannot be null");
            var module = particleSystem.trigger;
            module.enter = enterChanger(module.enter);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TriggerModule.enter"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetEnter(this TriggerModule module, ParticleSystemOverlapAction enter)
        {
            module.enter = enter;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.enter"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetEnter(this TriggerModule module, Func<ParticleSystemOverlapAction, ParticleSystemOverlapAction> enterChanger)
        {
            Debug.Assert(enterChanger != null, "enterChanger cannot be null");
            module.enter = enterChanger(module.enter);
            return module;
        }
        #endregion

        #region Exit
        /// <summary>
        /// Assign a value to <see cref="TriggerModule.exit"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerExit(this ParticleSystem particleSystem, ParticleSystemOverlapAction exit)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.trigger;
            module.exit = exit;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.exit"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerExit(this ParticleSystem particleSystem, Func<ParticleSystemOverlapAction, ParticleSystemOverlapAction> exitChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(exitChanger != null, "exitChanger cannot be null");
            var module = particleSystem.trigger;
            module.exit = exitChanger(module.exit);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TriggerModule.exit"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetExit(this TriggerModule module, ParticleSystemOverlapAction exit)
        {
            module.exit = exit;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.exit"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetExit(this TriggerModule module, Func<ParticleSystemOverlapAction, ParticleSystemOverlapAction> exitChanger)
        {
            Debug.Assert(exitChanger != null, "exitChanger cannot be null");
            module.exit = exitChanger(module.exit);
            return module;
        }
        #endregion

        #region Inside
        /// <summary>
        /// Assign a value to <see cref="TriggerModule.inside"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerInside(this ParticleSystem particleSystem, ParticleSystemOverlapAction inside)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.trigger;
            module.inside = inside;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.inside"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerInside(this ParticleSystem particleSystem, Func<ParticleSystemOverlapAction, ParticleSystemOverlapAction> insideChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(insideChanger != null, "insideChanger cannot be null");
            var module = particleSystem.trigger;
            module.inside = insideChanger(module.inside);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TriggerModule.inside"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetInside(this TriggerModule module, ParticleSystemOverlapAction inside)
        {
            module.inside = inside;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.inside"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetInside(this TriggerModule module, Func<ParticleSystemOverlapAction, ParticleSystemOverlapAction> insideChanger)
        {
            Debug.Assert(insideChanger != null, "insideChanger cannot be null");
            module.inside = insideChanger(module.inside);
            return module;
        }
        #endregion

        #region Outside
        /// <summary>
        /// Assign a value to <see cref="TriggerModule.outside"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerOutside(this ParticleSystem particleSystem, ParticleSystemOverlapAction outside)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.trigger;
            module.outside = outside;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.outside"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerOutside(this ParticleSystem particleSystem, Func<ParticleSystemOverlapAction, ParticleSystemOverlapAction> outsideChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(outsideChanger != null, "outsideChanger cannot be null");
            var module = particleSystem.trigger;
            module.outside = outsideChanger(module.outside);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TriggerModule.outside"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetOutside(this TriggerModule module, ParticleSystemOverlapAction outside)
        {
            module.outside = outside;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.outside"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetOutside(this TriggerModule module, Func<ParticleSystemOverlapAction, ParticleSystemOverlapAction> outsideChanger)
        {
            Debug.Assert(outsideChanger != null, "outsideChanger cannot be null");
            module.outside = outsideChanger(module.outside);
            return module;
        }
        #endregion

        #region RadiusScale
        /// <summary>
        /// Assign a value to <see cref="TriggerModule.radiusScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerRadiusScale(this ParticleSystem particleSystem, float radiusScale)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.trigger;
            module.radiusScale = radiusScale;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.radiusScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerRadiusScale(this ParticleSystem particleSystem, Func<float, float> radiusScaleChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(radiusScaleChanger != null, "radiusScaleChanger cannot be null");
            var module = particleSystem.trigger;
            module.radiusScale = radiusScaleChanger(module.radiusScale);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TriggerModule.radiusScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetRadiusScale(this TriggerModule module, float radiusScale)
        {
            module.radiusScale = radiusScale;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TriggerModule.radiusScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetRadiusScale(this TriggerModule module, Func<float, float> radiusScaleChanger)
        {
            Debug.Assert(radiusScaleChanger != null, "radiusScaleChanger cannot be null");
            module.radiusScale = radiusScaleChanger(module.radiusScale);
            return module;
        }
        #endregion
#endif
    }
}
