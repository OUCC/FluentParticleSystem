using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class TriggerModuleExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditTrigger(this ParticleSystem particleSystem, Action<TriggerModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.trigger);
            return particleSystem;
        }

        #region ColliderQueryMode
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerColliderQueryMode(this ParticleSystem particleSystem, UnityEngine.ParticleSystemColliderQueryMode colliderQueryMode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.colliderQueryMode = colliderQueryMode;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerColliderQueryMode(this ParticleSystem particleSystem, Func<UnityEngine.ParticleSystemColliderQueryMode, UnityEngine.ParticleSystemColliderQueryMode> colliderQueryModeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.colliderQueryMode = colliderQueryModeChanger(module.colliderQueryMode);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetColliderQueryMode(this TriggerModule module, UnityEngine.ParticleSystemColliderQueryMode colliderQueryMode)
        {
            module.colliderQueryMode = colliderQueryMode;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetColliderQueryMode(this TriggerModule module, Func<UnityEngine.ParticleSystemColliderQueryMode, UnityEngine.ParticleSystemColliderQueryMode> colliderQueryModeChanger)
        {
            module.colliderQueryMode = colliderQueryModeChanger(module.colliderQueryMode);
            return module;
        }
        #endregion

        #region Enabled
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetEnabled(this TriggerModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetEnabled(this TriggerModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Enter
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerEnter(this ParticleSystem particleSystem, UnityEngine.ParticleSystemOverlapAction enter)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.enter = enter;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerEnter(this ParticleSystem particleSystem, Func<UnityEngine.ParticleSystemOverlapAction, UnityEngine.ParticleSystemOverlapAction> enterChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.enter = enterChanger(module.enter);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetEnter(this TriggerModule module, UnityEngine.ParticleSystemOverlapAction enter)
        {
            module.enter = enter;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetEnter(this TriggerModule module, Func<UnityEngine.ParticleSystemOverlapAction, UnityEngine.ParticleSystemOverlapAction> enterChanger)
        {
            module.enter = enterChanger(module.enter);
            return module;
        }
        #endregion

        #region Exit
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerExit(this ParticleSystem particleSystem, UnityEngine.ParticleSystemOverlapAction exit)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.exit = exit;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerExit(this ParticleSystem particleSystem, Func<UnityEngine.ParticleSystemOverlapAction, UnityEngine.ParticleSystemOverlapAction> exitChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.exit = exitChanger(module.exit);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetExit(this TriggerModule module, UnityEngine.ParticleSystemOverlapAction exit)
        {
            module.exit = exit;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetExit(this TriggerModule module, Func<UnityEngine.ParticleSystemOverlapAction, UnityEngine.ParticleSystemOverlapAction> exitChanger)
        {
            module.exit = exitChanger(module.exit);
            return module;
        }
        #endregion

        #region Inside
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerInside(this ParticleSystem particleSystem, UnityEngine.ParticleSystemOverlapAction inside)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.inside = inside;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerInside(this ParticleSystem particleSystem, Func<UnityEngine.ParticleSystemOverlapAction, UnityEngine.ParticleSystemOverlapAction> insideChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.inside = insideChanger(module.inside);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetInside(this TriggerModule module, UnityEngine.ParticleSystemOverlapAction inside)
        {
            module.inside = inside;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetInside(this TriggerModule module, Func<UnityEngine.ParticleSystemOverlapAction, UnityEngine.ParticleSystemOverlapAction> insideChanger)
        {
            module.inside = insideChanger(module.inside);
            return module;
        }
        #endregion

        #region Outside
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerOutside(this ParticleSystem particleSystem, UnityEngine.ParticleSystemOverlapAction outside)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.outside = outside;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerOutside(this ParticleSystem particleSystem, Func<UnityEngine.ParticleSystemOverlapAction, UnityEngine.ParticleSystemOverlapAction> outsideChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.outside = outsideChanger(module.outside);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetOutside(this TriggerModule module, UnityEngine.ParticleSystemOverlapAction outside)
        {
            module.outside = outside;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetOutside(this TriggerModule module, Func<UnityEngine.ParticleSystemOverlapAction, UnityEngine.ParticleSystemOverlapAction> outsideChanger)
        {
            module.outside = outsideChanger(module.outside);
            return module;
        }
        #endregion

        #region RadiusScale
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerRadiusScale(this ParticleSystem particleSystem, float radiusScale)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.radiusScale = radiusScale;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTriggerRadiusScale(this ParticleSystem particleSystem, Func<float, float> radiusScaleChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.trigger;
            module.radiusScale = radiusScaleChanger(module.radiusScale);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetRadiusScale(this TriggerModule module, float radiusScale)
        {
            module.radiusScale = radiusScale;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerModule SetRadiusScale(this TriggerModule module, Func<float, float> radiusScaleChanger)
        {
            module.radiusScale = radiusScaleChanger(module.radiusScale);
            return module;
        }
        #endregion
    }
}
