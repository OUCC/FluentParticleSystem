using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class CollisionModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.collision"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditCollision(this ParticleSystem particleSystem, Action<CollisionModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.collision);
            return particleSystem;
        }

        #region Bounce
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.bounce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionBounce(this ParticleSystem particleSystem, MinMaxCurve bounce)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.bounce = bounce;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.bounce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionBounce(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> bounceChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.bounce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetBounce(this CollisionModule module, Func<MinMaxCurve, MinMaxCurve> bounceChanger)
        {
            module.bounce = bounceChanger(module.bounce);
            return module;
        }
        #endregion

        #region BounceMultiplier
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.bounceMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionBounceMultiplier(this ParticleSystem particleSystem, float bounceMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.bounceMultiplier = bounceMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.bounceMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionBounceMultiplier(this ParticleSystem particleSystem, Func<float, float> bounceMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.bounceMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetBounceMultiplier(this CollisionModule module, Func<float, float> bounceMultiplierChanger)
        {
            module.bounceMultiplier = bounceMultiplierChanger(module.bounceMultiplier);
            return module;
        }
        #endregion

        #region ColliderForce
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.colliderForce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionColliderForce(this ParticleSystem particleSystem, float colliderForce)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.colliderForce = colliderForce;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.colliderForce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionColliderForce(this ParticleSystem particleSystem, Func<float, float> colliderForceChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.colliderForce"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetColliderForce(this CollisionModule module, Func<float, float> colliderForceChanger)
        {
            module.colliderForce = colliderForceChanger(module.colliderForce);
            return module;
        }
        #endregion

        #region CollidesWith
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.collidesWith"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionCollidesWith(this ParticleSystem particleSystem, LayerMask collidesWith)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.collidesWith = collidesWith;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.collidesWith"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionCollidesWith(this ParticleSystem particleSystem, Func<LayerMask, LayerMask> collidesWithChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.collidesWith"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetCollidesWith(this CollisionModule module, Func<LayerMask, LayerMask> collidesWithChanger)
        {
            module.collidesWith = collidesWithChanger(module.collidesWith);
            return module;
        }
        #endregion

        #region Dampen
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.dampen"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionDampen(this ParticleSystem particleSystem, MinMaxCurve dampen)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.dampen = dampen;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.dampen"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionDampen(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> dampenChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.dampen"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetDampen(this CollisionModule module, Func<MinMaxCurve, MinMaxCurve> dampenChanger)
        {
            module.dampen = dampenChanger(module.dampen);
            return module;
        }
        #endregion

        #region DampenMultiplier
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.dampenMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionDampenMultiplier(this ParticleSystem particleSystem, float dampenMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.dampenMultiplier = dampenMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.dampenMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionDampenMultiplier(this ParticleSystem particleSystem, Func<float, float> dampenMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.dampenMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetDampenMultiplier(this CollisionModule module, Func<float, float> dampenMultiplierChanger)
        {
            module.dampenMultiplier = dampenMultiplierChanger(module.dampenMultiplier);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetEnabled(this CollisionModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region EnableDynamicColliders
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.enableDynamicColliders"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionEnableDynamicColliders(this ParticleSystem particleSystem, bool enableDynamicColliders)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.enableDynamicColliders = enableDynamicColliders;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.enableDynamicColliders"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionEnableDynamicColliders(this ParticleSystem particleSystem, Func<bool, bool> enableDynamicCollidersChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.enableDynamicColliders"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetEnableDynamicColliders(this CollisionModule module, Func<bool, bool> enableDynamicCollidersChanger)
        {
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
        public static ParticleSystem SetCollisionEnableInteriorCollisions(this ParticleSystem particleSystem, bool enableInteriorCollisions)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        public static ParticleSystem SetCollisionEnableInteriorCollisions(this ParticleSystem particleSystem, Func<bool, bool> enableInteriorCollisionsChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.enableInteriorCollisions"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("enableInteriorCollisions property is deprecated and is no longer required and has no effect on the particle system.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetEnableInteriorCollisions(this CollisionModule module, Func<bool, bool> enableInteriorCollisionsChanger)
        {
            module.enableInteriorCollisions = enableInteriorCollisionsChanger(module.enableInteriorCollisions);
            return module;
        }
        #endregion

        #region LifetimeLoss
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.lifetimeLoss"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionLifetimeLoss(this ParticleSystem particleSystem, MinMaxCurve lifetimeLoss)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.lifetimeLoss = lifetimeLoss;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.lifetimeLoss"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionLifetimeLoss(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> lifetimeLossChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.lifetimeLoss"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetLifetimeLoss(this CollisionModule module, Func<MinMaxCurve, MinMaxCurve> lifetimeLossChanger)
        {
            module.lifetimeLoss = lifetimeLossChanger(module.lifetimeLoss);
            return module;
        }
        #endregion

        #region LifetimeLossMultiplier
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.lifetimeLossMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionLifetimeLossMultiplier(this ParticleSystem particleSystem, float lifetimeLossMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.lifetimeLossMultiplier = lifetimeLossMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.lifetimeLossMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionLifetimeLossMultiplier(this ParticleSystem particleSystem, Func<float, float> lifetimeLossMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.lifetimeLossMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetLifetimeLossMultiplier(this CollisionModule module, Func<float, float> lifetimeLossMultiplierChanger)
        {
            module.lifetimeLossMultiplier = lifetimeLossMultiplierChanger(module.lifetimeLossMultiplier);
            return module;
        }
        #endregion

        #region MaxCollisionShapes
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.maxCollisionShapes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMaxCollisionShapes(this ParticleSystem particleSystem, int maxCollisionShapes)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.maxCollisionShapes = maxCollisionShapes;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.maxCollisionShapes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMaxCollisionShapes(this ParticleSystem particleSystem, Func<int, int> maxCollisionShapesChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.maxCollisionShapes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMaxCollisionShapes(this CollisionModule module, Func<int, int> maxCollisionShapesChanger)
        {
            module.maxCollisionShapes = maxCollisionShapesChanger(module.maxCollisionShapes);
            return module;
        }
        #endregion

        #region MaxKillSpeed
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.maxKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMaxKillSpeed(this ParticleSystem particleSystem, float maxKillSpeed)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.maxKillSpeed = maxKillSpeed;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.maxKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMaxKillSpeed(this ParticleSystem particleSystem, Func<float, float> maxKillSpeedChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.maxKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMaxKillSpeed(this CollisionModule module, Func<float, float> maxKillSpeedChanger)
        {
            module.maxKillSpeed = maxKillSpeedChanger(module.maxKillSpeed);
            return module;
        }
        #endregion

        #region MinKillSpeed
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.minKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMinKillSpeed(this ParticleSystem particleSystem, float minKillSpeed)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.minKillSpeed = minKillSpeed;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.minKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMinKillSpeed(this ParticleSystem particleSystem, Func<float, float> minKillSpeedChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.minKillSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMinKillSpeed(this CollisionModule module, Func<float, float> minKillSpeedChanger)
        {
            module.minKillSpeed = minKillSpeedChanger(module.minKillSpeed);
            return module;
        }
        #endregion

        #region Mode
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMode(this ParticleSystem particleSystem, ParticleSystemCollisionMode mode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.mode = mode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMode(this ParticleSystem particleSystem, Func<ParticleSystemCollisionMode, ParticleSystemCollisionMode> modeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMode(this CollisionModule module, Func<ParticleSystemCollisionMode, ParticleSystemCollisionMode> modeChanger)
        {
            module.mode = modeChanger(module.mode);
            return module;
        }
        #endregion

        #region MultiplyColliderForceByCollisionAngle
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.multiplyColliderForceByCollisionAngle"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMultiplyColliderForceByCollisionAngle(this ParticleSystem particleSystem, bool multiplyColliderForceByCollisionAngle)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.multiplyColliderForceByCollisionAngle = multiplyColliderForceByCollisionAngle;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.multiplyColliderForceByCollisionAngle"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMultiplyColliderForceByCollisionAngle(this ParticleSystem particleSystem, Func<bool, bool> multiplyColliderForceByCollisionAngleChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.multiplyColliderForceByCollisionAngle"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMultiplyColliderForceByCollisionAngle(this CollisionModule module, Func<bool, bool> multiplyColliderForceByCollisionAngleChanger)
        {
            module.multiplyColliderForceByCollisionAngle = multiplyColliderForceByCollisionAngleChanger(module.multiplyColliderForceByCollisionAngle);
            return module;
        }
        #endregion

        #region MultiplyColliderForceByParticleSize
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.multiplyColliderForceByParticleSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMultiplyColliderForceByParticleSize(this ParticleSystem particleSystem, bool multiplyColliderForceByParticleSize)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.multiplyColliderForceByParticleSize = multiplyColliderForceByParticleSize;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.multiplyColliderForceByParticleSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMultiplyColliderForceByParticleSize(this ParticleSystem particleSystem, Func<bool, bool> multiplyColliderForceByParticleSizeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.multiplyColliderForceByParticleSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMultiplyColliderForceByParticleSize(this CollisionModule module, Func<bool, bool> multiplyColliderForceByParticleSizeChanger)
        {
            module.multiplyColliderForceByParticleSize = multiplyColliderForceByParticleSizeChanger(module.multiplyColliderForceByParticleSize);
            return module;
        }
        #endregion

        #region MultiplyColliderForceByParticleSpeed
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.multiplyColliderForceByParticleSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMultiplyColliderForceByParticleSpeed(this ParticleSystem particleSystem, bool multiplyColliderForceByParticleSpeed)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.multiplyColliderForceByParticleSpeed = multiplyColliderForceByParticleSpeed;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.multiplyColliderForceByParticleSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionMultiplyColliderForceByParticleSpeed(this ParticleSystem particleSystem, Func<bool, bool> multiplyColliderForceByParticleSpeedChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.multiplyColliderForceByParticleSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetMultiplyColliderForceByParticleSpeed(this CollisionModule module, Func<bool, bool> multiplyColliderForceByParticleSpeedChanger)
        {
            module.multiplyColliderForceByParticleSpeed = multiplyColliderForceByParticleSpeedChanger(module.multiplyColliderForceByParticleSpeed);
            return module;
        }
        #endregion

        #region Quality
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.quality"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionQuality(this ParticleSystem particleSystem, ParticleSystemCollisionQuality quality)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.quality = quality;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.quality"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionQuality(this ParticleSystem particleSystem, Func<ParticleSystemCollisionQuality, ParticleSystemCollisionQuality> qualityChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.quality"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetQuality(this CollisionModule module, Func<ParticleSystemCollisionQuality, ParticleSystemCollisionQuality> qualityChanger)
        {
            module.quality = qualityChanger(module.quality);
            return module;
        }
        #endregion

        #region RadiusScale
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.radiusScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionRadiusScale(this ParticleSystem particleSystem, float radiusScale)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.radiusScale = radiusScale;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.radiusScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionRadiusScale(this ParticleSystem particleSystem, Func<float, float> radiusScaleChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.radiusScale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetRadiusScale(this CollisionModule module, Func<float, float> radiusScaleChanger)
        {
            module.radiusScale = radiusScaleChanger(module.radiusScale);
            return module;
        }
        #endregion

        #region SendCollisionMessages
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.sendCollisionMessages"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionSendCollisionMessages(this ParticleSystem particleSystem, bool sendCollisionMessages)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.sendCollisionMessages = sendCollisionMessages;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.sendCollisionMessages"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionSendCollisionMessages(this ParticleSystem particleSystem, Func<bool, bool> sendCollisionMessagesChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.sendCollisionMessages"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetSendCollisionMessages(this CollisionModule module, Func<bool, bool> sendCollisionMessagesChanger)
        {
            module.sendCollisionMessages = sendCollisionMessagesChanger(module.sendCollisionMessages);
            return module;
        }
        #endregion

        #region Type
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.type"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionType(this ParticleSystem particleSystem, ParticleSystemCollisionType type)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.type = type;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.type"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionType(this ParticleSystem particleSystem, Func<ParticleSystemCollisionType, ParticleSystemCollisionType> typeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.type"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetType(this CollisionModule module, Func<ParticleSystemCollisionType, ParticleSystemCollisionType> typeChanger)
        {
            module.type = typeChanger(module.type);
            return module;
        }
        #endregion

        #region VoxelSize
        /// <summary>
        /// Assign a value to <see cref="CollisionModule.voxelSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionVoxelSize(this ParticleSystem particleSystem, float voxelSize)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.collision;
            module.voxelSize = voxelSize;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="CollisionModule.voxelSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetCollisionVoxelSize(this ParticleSystem particleSystem, Func<float, float> voxelSizeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
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
        /// Edit see cref="CollisionModule.voxelSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static CollisionModule SetVoxelSize(this CollisionModule module, Func<float, float> voxelSizeChanger)
        {
            module.voxelSize = voxelSizeChanger(module.voxelSize);
            return module;
        }
        #endregion
#endif
    }
}
