using System;
using System.Runtime.CompilerServices;
using UnityEngine;

using static UnityEngine.ParticleSystem;

#if UNITY_2020_2_OR_NEWER
using System.Diagnostics.CodeAnalysis;
#endif

namespace OUCC.FluentParticleSystem
{
    public static class CollisionModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.collision"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem EditCollision(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Action<CollisionModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.collision);
            return particleSystem;
        }

        #region Bounce
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.bounce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionBounce(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve bounce)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.bounce = bounce;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.bounce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionBounce(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<MinMaxCurve, MinMaxCurve> bounceChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(bounceChanger != null, "bounceChanger cannot be null");
            var module = particleSystem.collision;
            module.bounce = bounceChanger(module.bounce);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.bounce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetBounce(this CollisionModule module, MinMaxCurve bounce)
        {
            module.bounce = bounce;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.bounce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetBounce(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<MinMaxCurve, MinMaxCurve> bounceChanger)
        {
            Debug.Assert(bounceChanger != null, "bounceChanger cannot be null");
            module.bounce = bounceChanger(module.bounce);
            return module;
        }
        #endregion

        #region BounceMultiplier
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.bounceMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionBounceMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float bounceMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.bounceMultiplier = bounceMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.bounceMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionBounceMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> bounceMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(bounceMultiplierChanger != null, "bounceMultiplierChanger cannot be null");
            var module = particleSystem.collision;
            module.bounceMultiplier = bounceMultiplierChanger(module.bounceMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.bounceMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetBounceMultiplier(this CollisionModule module, float bounceMultiplier)
        {
            module.bounceMultiplier = bounceMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.bounceMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetBounceMultiplier(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> bounceMultiplierChanger)
        {
            Debug.Assert(bounceMultiplierChanger != null, "bounceMultiplierChanger cannot be null");
            module.bounceMultiplier = bounceMultiplierChanger(module.bounceMultiplier);
            return module;
        }
        #endregion

        #region ColliderForce
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.colliderForce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionColliderForce(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float colliderForce)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.colliderForce = colliderForce;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.colliderForce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionColliderForce(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> colliderForceChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(colliderForceChanger != null, "colliderForceChanger cannot be null");
            var module = particleSystem.collision;
            module.colliderForce = colliderForceChanger(module.colliderForce);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.colliderForce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetColliderForce(this CollisionModule module, float colliderForce)
        {
            module.colliderForce = colliderForce;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.colliderForce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetColliderForce(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> colliderForceChanger)
        {
            Debug.Assert(colliderForceChanger != null, "colliderForceChanger cannot be null");
            module.colliderForce = colliderForceChanger(module.colliderForce);
            return module;
        }
        #endregion

        #region CollidesWith
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.collidesWith"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionCollidesWith(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, LayerMask collidesWith)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.collidesWith = collidesWith;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.collidesWith"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionCollidesWith(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<LayerMask, LayerMask> collidesWithChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(collidesWithChanger != null, "collidesWithChanger cannot be null");
            var module = particleSystem.collision;
            module.collidesWith = collidesWithChanger(module.collidesWith);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.collidesWith"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetCollidesWith(this CollisionModule module, LayerMask collidesWith)
        {
            module.collidesWith = collidesWith;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.collidesWith"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetCollidesWith(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<LayerMask, LayerMask> collidesWithChanger)
        {
            Debug.Assert(collidesWithChanger != null, "collidesWithChanger cannot be null");
            module.collidesWith = collidesWithChanger(module.collidesWith);
            return module;
        }
        #endregion

        #region Dampen
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.dampen"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionDampen(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve dampen)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.dampen = dampen;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.dampen"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionDampen(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<MinMaxCurve, MinMaxCurve> dampenChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(dampenChanger != null, "dampenChanger cannot be null");
            var module = particleSystem.collision;
            module.dampen = dampenChanger(module.dampen);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.dampen"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetDampen(this CollisionModule module, MinMaxCurve dampen)
        {
            module.dampen = dampen;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.dampen"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetDampen(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<MinMaxCurve, MinMaxCurve> dampenChanger)
        {
            Debug.Assert(dampenChanger != null, "dampenChanger cannot be null");
            module.dampen = dampenChanger(module.dampen);
            return module;
        }
        #endregion

        #region DampenMultiplier
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.dampenMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionDampenMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float dampenMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.dampenMultiplier = dampenMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.dampenMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionDampenMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> dampenMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(dampenMultiplierChanger != null, "dampenMultiplierChanger cannot be null");
            var module = particleSystem.collision;
            module.dampenMultiplier = dampenMultiplierChanger(module.dampenMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.dampenMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetDampenMultiplier(this CollisionModule module, float dampenMultiplier)
        {
            module.dampenMultiplier = dampenMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.dampenMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetDampenMultiplier(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> dampenMultiplierChanger)
        {
            Debug.Assert(dampenMultiplierChanger != null, "dampenMultiplierChanger cannot be null");
            module.dampenMultiplier = dampenMultiplierChanger(module.dampenMultiplier);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionEnabled(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionEnabled(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.collision;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetEnabled(this CollisionModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetEnabled(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region EnableDynamicColliders
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.enableDynamicColliders"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionEnableDynamicColliders(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool enableDynamicColliders)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.enableDynamicColliders = enableDynamicColliders;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.enableDynamicColliders"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionEnableDynamicColliders(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> enableDynamicCollidersChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enableDynamicCollidersChanger != null, "enableDynamicCollidersChanger cannot be null");
            var module = particleSystem.collision;
            module.enableDynamicColliders = enableDynamicCollidersChanger(module.enableDynamicColliders);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.enableDynamicColliders"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetEnableDynamicColliders(this CollisionModule module, bool enableDynamicColliders)
        {
            module.enableDynamicColliders = enableDynamicColliders;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.enableDynamicColliders"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetEnableDynamicColliders(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> enableDynamicCollidersChanger)
        {
            Debug.Assert(enableDynamicCollidersChanger != null, "enableDynamicCollidersChanger cannot be null");
            module.enableDynamicColliders = enableDynamicCollidersChanger(module.enableDynamicColliders);
            return module;
        }
        #endregion

        #region EnableInteriorCollisions
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.enableInteriorCollisions"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("enableInteriorCollisions property is deprecated and is no longer required and has no effect on the particle system.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionEnableInteriorCollisions(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool enableInteriorCollisions)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.enableInteriorCollisions = enableInteriorCollisions;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.enableInteriorCollisions"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("enableInteriorCollisions property is deprecated and is no longer required and has no effect on the particle system.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionEnableInteriorCollisions(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> enableInteriorCollisionsChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enableInteriorCollisionsChanger != null, "enableInteriorCollisionsChanger cannot be null");
            var module = particleSystem.collision;
            module.enableInteriorCollisions = enableInteriorCollisionsChanger(module.enableInteriorCollisions);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.enableInteriorCollisions"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("enableInteriorCollisions property is deprecated and is no longer required and has no effect on the particle system.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetEnableInteriorCollisions(this CollisionModule module, bool enableInteriorCollisions)
        {
            module.enableInteriorCollisions = enableInteriorCollisions;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.enableInteriorCollisions"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("enableInteriorCollisions property is deprecated and is no longer required and has no effect on the particle system.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetEnableInteriorCollisions(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> enableInteriorCollisionsChanger)
        {
            Debug.Assert(enableInteriorCollisionsChanger != null, "enableInteriorCollisionsChanger cannot be null");
            module.enableInteriorCollisions = enableInteriorCollisionsChanger(module.enableInteriorCollisions);
            return module;
        }
        #endregion

        #region LifetimeLoss
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.lifetimeLoss"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionLifetimeLoss(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve lifetimeLoss)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.lifetimeLoss = lifetimeLoss;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.lifetimeLoss"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionLifetimeLoss(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<MinMaxCurve, MinMaxCurve> lifetimeLossChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(lifetimeLossChanger != null, "lifetimeLossChanger cannot be null");
            var module = particleSystem.collision;
            module.lifetimeLoss = lifetimeLossChanger(module.lifetimeLoss);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.lifetimeLoss"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetLifetimeLoss(this CollisionModule module, MinMaxCurve lifetimeLoss)
        {
            module.lifetimeLoss = lifetimeLoss;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.lifetimeLoss"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetLifetimeLoss(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<MinMaxCurve, MinMaxCurve> lifetimeLossChanger)
        {
            Debug.Assert(lifetimeLossChanger != null, "lifetimeLossChanger cannot be null");
            module.lifetimeLoss = lifetimeLossChanger(module.lifetimeLoss);
            return module;
        }
        #endregion

        #region LifetimeLossMultiplier
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.lifetimeLossMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionLifetimeLossMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float lifetimeLossMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.lifetimeLossMultiplier = lifetimeLossMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.lifetimeLossMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionLifetimeLossMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> lifetimeLossMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(lifetimeLossMultiplierChanger != null, "lifetimeLossMultiplierChanger cannot be null");
            var module = particleSystem.collision;
            module.lifetimeLossMultiplier = lifetimeLossMultiplierChanger(module.lifetimeLossMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.lifetimeLossMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetLifetimeLossMultiplier(this CollisionModule module, float lifetimeLossMultiplier)
        {
            module.lifetimeLossMultiplier = lifetimeLossMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.lifetimeLossMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetLifetimeLossMultiplier(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> lifetimeLossMultiplierChanger)
        {
            Debug.Assert(lifetimeLossMultiplierChanger != null, "lifetimeLossMultiplierChanger cannot be null");
            module.lifetimeLossMultiplier = lifetimeLossMultiplierChanger(module.lifetimeLossMultiplier);
            return module;
        }
        #endregion

        #region MaxCollisionShapes
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.maxCollisionShapes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMaxCollisionShapes(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, int maxCollisionShapes)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.maxCollisionShapes = maxCollisionShapes;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.maxCollisionShapes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMaxCollisionShapes(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<int, int> maxCollisionShapesChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(maxCollisionShapesChanger != null, "maxCollisionShapesChanger cannot be null");
            var module = particleSystem.collision;
            module.maxCollisionShapes = maxCollisionShapesChanger(module.maxCollisionShapes);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.maxCollisionShapes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMaxCollisionShapes(this CollisionModule module, int maxCollisionShapes)
        {
            module.maxCollisionShapes = maxCollisionShapes;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.maxCollisionShapes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMaxCollisionShapes(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<int, int> maxCollisionShapesChanger)
        {
            Debug.Assert(maxCollisionShapesChanger != null, "maxCollisionShapesChanger cannot be null");
            module.maxCollisionShapes = maxCollisionShapesChanger(module.maxCollisionShapes);
            return module;
        }
        #endregion

        #region MaxKillSpeed
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.maxKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMaxKillSpeed(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float maxKillSpeed)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.maxKillSpeed = maxKillSpeed;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.maxKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMaxKillSpeed(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> maxKillSpeedChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(maxKillSpeedChanger != null, "maxKillSpeedChanger cannot be null");
            var module = particleSystem.collision;
            module.maxKillSpeed = maxKillSpeedChanger(module.maxKillSpeed);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.maxKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMaxKillSpeed(this CollisionModule module, float maxKillSpeed)
        {
            module.maxKillSpeed = maxKillSpeed;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.maxKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMaxKillSpeed(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> maxKillSpeedChanger)
        {
            Debug.Assert(maxKillSpeedChanger != null, "maxKillSpeedChanger cannot be null");
            module.maxKillSpeed = maxKillSpeedChanger(module.maxKillSpeed);
            return module;
        }
        #endregion

        #region MinKillSpeed
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.minKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMinKillSpeed(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float minKillSpeed)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.minKillSpeed = minKillSpeed;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.minKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMinKillSpeed(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> minKillSpeedChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(minKillSpeedChanger != null, "minKillSpeedChanger cannot be null");
            var module = particleSystem.collision;
            module.minKillSpeed = minKillSpeedChanger(module.minKillSpeed);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.minKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMinKillSpeed(this CollisionModule module, float minKillSpeed)
        {
            module.minKillSpeed = minKillSpeed;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.minKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMinKillSpeed(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> minKillSpeedChanger)
        {
            Debug.Assert(minKillSpeedChanger != null, "minKillSpeedChanger cannot be null");
            module.minKillSpeed = minKillSpeedChanger(module.minKillSpeed);
            return module;
        }
        #endregion

        #region Mode
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMode(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, ParticleSystemCollisionMode mode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.mode = mode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMode(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<ParticleSystemCollisionMode, ParticleSystemCollisionMode> modeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(modeChanger != null, "modeChanger cannot be null");
            var module = particleSystem.collision;
            module.mode = modeChanger(module.mode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMode(this CollisionModule module, ParticleSystemCollisionMode mode)
        {
            module.mode = mode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMode(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<ParticleSystemCollisionMode, ParticleSystemCollisionMode> modeChanger)
        {
            Debug.Assert(modeChanger != null, "modeChanger cannot be null");
            module.mode = modeChanger(module.mode);
            return module;
        }
        #endregion

        #region MultiplyColliderForceByCollisionAngle
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.multiplyColliderForceByCollisionAngle"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMultiplyColliderForceByCollisionAngle(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool multiplyColliderForceByCollisionAngle)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.multiplyColliderForceByCollisionAngle = multiplyColliderForceByCollisionAngle;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.multiplyColliderForceByCollisionAngle"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMultiplyColliderForceByCollisionAngle(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> multiplyColliderForceByCollisionAngleChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(multiplyColliderForceByCollisionAngleChanger != null, "multiplyColliderForceByCollisionAngleChanger cannot be null");
            var module = particleSystem.collision;
            module.multiplyColliderForceByCollisionAngle = multiplyColliderForceByCollisionAngleChanger(module.multiplyColliderForceByCollisionAngle);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.multiplyColliderForceByCollisionAngle"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMultiplyColliderForceByCollisionAngle(this CollisionModule module, bool multiplyColliderForceByCollisionAngle)
        {
            module.multiplyColliderForceByCollisionAngle = multiplyColliderForceByCollisionAngle;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.multiplyColliderForceByCollisionAngle"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMultiplyColliderForceByCollisionAngle(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> multiplyColliderForceByCollisionAngleChanger)
        {
            Debug.Assert(multiplyColliderForceByCollisionAngleChanger != null, "multiplyColliderForceByCollisionAngleChanger cannot be null");
            module.multiplyColliderForceByCollisionAngle = multiplyColliderForceByCollisionAngleChanger(module.multiplyColliderForceByCollisionAngle);
            return module;
        }
        #endregion

        #region MultiplyColliderForceByParticleSize
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.multiplyColliderForceByParticleSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMultiplyColliderForceByParticleSize(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool multiplyColliderForceByParticleSize)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.multiplyColliderForceByParticleSize = multiplyColliderForceByParticleSize;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.multiplyColliderForceByParticleSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMultiplyColliderForceByParticleSize(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> multiplyColliderForceByParticleSizeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(multiplyColliderForceByParticleSizeChanger != null, "multiplyColliderForceByParticleSizeChanger cannot be null");
            var module = particleSystem.collision;
            module.multiplyColliderForceByParticleSize = multiplyColliderForceByParticleSizeChanger(module.multiplyColliderForceByParticleSize);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.multiplyColliderForceByParticleSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMultiplyColliderForceByParticleSize(this CollisionModule module, bool multiplyColliderForceByParticleSize)
        {
            module.multiplyColliderForceByParticleSize = multiplyColliderForceByParticleSize;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.multiplyColliderForceByParticleSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMultiplyColliderForceByParticleSize(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> multiplyColliderForceByParticleSizeChanger)
        {
            Debug.Assert(multiplyColliderForceByParticleSizeChanger != null, "multiplyColliderForceByParticleSizeChanger cannot be null");
            module.multiplyColliderForceByParticleSize = multiplyColliderForceByParticleSizeChanger(module.multiplyColliderForceByParticleSize);
            return module;
        }
        #endregion

        #region MultiplyColliderForceByParticleSpeed
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.multiplyColliderForceByParticleSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMultiplyColliderForceByParticleSpeed(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool multiplyColliderForceByParticleSpeed)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.multiplyColliderForceByParticleSpeed = multiplyColliderForceByParticleSpeed;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.multiplyColliderForceByParticleSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionMultiplyColliderForceByParticleSpeed(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> multiplyColliderForceByParticleSpeedChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(multiplyColliderForceByParticleSpeedChanger != null, "multiplyColliderForceByParticleSpeedChanger cannot be null");
            var module = particleSystem.collision;
            module.multiplyColliderForceByParticleSpeed = multiplyColliderForceByParticleSpeedChanger(module.multiplyColliderForceByParticleSpeed);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.multiplyColliderForceByParticleSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMultiplyColliderForceByParticleSpeed(this CollisionModule module, bool multiplyColliderForceByParticleSpeed)
        {
            module.multiplyColliderForceByParticleSpeed = multiplyColliderForceByParticleSpeed;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.multiplyColliderForceByParticleSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMultiplyColliderForceByParticleSpeed(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> multiplyColliderForceByParticleSpeedChanger)
        {
            Debug.Assert(multiplyColliderForceByParticleSpeedChanger != null, "multiplyColliderForceByParticleSpeedChanger cannot be null");
            module.multiplyColliderForceByParticleSpeed = multiplyColliderForceByParticleSpeedChanger(module.multiplyColliderForceByParticleSpeed);
            return module;
        }
        #endregion

        #region Quality
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.quality"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionQuality(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, ParticleSystemCollisionQuality quality)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.quality = quality;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.quality"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionQuality(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<ParticleSystemCollisionQuality, ParticleSystemCollisionQuality> qualityChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(qualityChanger != null, "qualityChanger cannot be null");
            var module = particleSystem.collision;
            module.quality = qualityChanger(module.quality);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.quality"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetQuality(this CollisionModule module, ParticleSystemCollisionQuality quality)
        {
            module.quality = quality;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.quality"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetQuality(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<ParticleSystemCollisionQuality, ParticleSystemCollisionQuality> qualityChanger)
        {
            Debug.Assert(qualityChanger != null, "qualityChanger cannot be null");
            module.quality = qualityChanger(module.quality);
            return module;
        }
        #endregion

        #region RadiusScale
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.radiusScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionRadiusScale(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float radiusScale)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.radiusScale = radiusScale;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.radiusScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionRadiusScale(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> radiusScaleChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(radiusScaleChanger != null, "radiusScaleChanger cannot be null");
            var module = particleSystem.collision;
            module.radiusScale = radiusScaleChanger(module.radiusScale);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.radiusScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetRadiusScale(this CollisionModule module, float radiusScale)
        {
            module.radiusScale = radiusScale;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.radiusScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetRadiusScale(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> radiusScaleChanger)
        {
            Debug.Assert(radiusScaleChanger != null, "radiusScaleChanger cannot be null");
            module.radiusScale = radiusScaleChanger(module.radiusScale);
            return module;
        }
        #endregion

        #region SendCollisionMessages
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.sendCollisionMessages"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionSendCollisionMessages(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool sendCollisionMessages)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.sendCollisionMessages = sendCollisionMessages;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.sendCollisionMessages"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionSendCollisionMessages(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> sendCollisionMessagesChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(sendCollisionMessagesChanger != null, "sendCollisionMessagesChanger cannot be null");
            var module = particleSystem.collision;
            module.sendCollisionMessages = sendCollisionMessagesChanger(module.sendCollisionMessages);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.sendCollisionMessages"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetSendCollisionMessages(this CollisionModule module, bool sendCollisionMessages)
        {
            module.sendCollisionMessages = sendCollisionMessages;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.sendCollisionMessages"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetSendCollisionMessages(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> sendCollisionMessagesChanger)
        {
            Debug.Assert(sendCollisionMessagesChanger != null, "sendCollisionMessagesChanger cannot be null");
            module.sendCollisionMessages = sendCollisionMessagesChanger(module.sendCollisionMessages);
            return module;
        }
        #endregion

        #region Type
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.type"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionType(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, ParticleSystemCollisionType type)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.type = type;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.type"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionType(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<ParticleSystemCollisionType, ParticleSystemCollisionType> typeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(typeChanger != null, "typeChanger cannot be null");
            var module = particleSystem.collision;
            module.type = typeChanger(module.type);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.type"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetType(this CollisionModule module, ParticleSystemCollisionType type)
        {
            module.type = type;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.type"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetType(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<ParticleSystemCollisionType, ParticleSystemCollisionType> typeChanger)
        {
            Debug.Assert(typeChanger != null, "typeChanger cannot be null");
            module.type = typeChanger(module.type);
            return module;
        }
        #endregion

        #region VoxelSize
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.voxelSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionVoxelSize(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float voxelSize)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.collision;
            module.voxelSize = voxelSize;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.voxelSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetCollisionVoxelSize(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> voxelSizeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(voxelSizeChanger != null, "voxelSizeChanger cannot be null");
            var module = particleSystem.collision;
            module.voxelSize = voxelSizeChanger(module.voxelSize);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="CollisionModule.voxelSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetVoxelSize(this CollisionModule module, float voxelSize)
        {
            module.voxelSize = voxelSize;
            return module;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.voxelSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetVoxelSize(this CollisionModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> voxelSizeChanger)
        {
            Debug.Assert(voxelSizeChanger != null, "voxelSizeChanger cannot be null");
            module.voxelSize = voxelSizeChanger(module.voxelSize);
            return module;
        }
        #endregion
#endif
    }
}
