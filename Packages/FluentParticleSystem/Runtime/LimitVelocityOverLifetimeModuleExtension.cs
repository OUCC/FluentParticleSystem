using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class LimitVelocityOverLifetimeModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.limitVelocityOverLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditLimitVelocityOverLifetime(this ParticleSystem particleSystem, Action<LimitVelocityOverLifetimeModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.limitVelocityOverLifetime);
            return particleSystem;
        }

        #region Dampen
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.dampen"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeDampen(this ParticleSystem particleSystem, float dampen)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.dampen = dampen;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.dampen"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeDampen(this ParticleSystem particleSystem, Func<float, float> dampenChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.dampen = dampenChanger(module.dampen);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.dampen"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetDampen(this LimitVelocityOverLifetimeModule module, float dampen)
        {
            module.dampen = dampen;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.dampen"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetDampen(this LimitVelocityOverLifetimeModule module, Func<float, float> dampenChanger)
        {
            module.dampen = dampenChanger(module.dampen);
            return module;
        }
        #endregion

        #region Drag
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.drag"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeDrag(this ParticleSystem particleSystem, MinMaxCurve drag)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.drag = drag;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.drag"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeDrag(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> dragChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.drag = dragChanger(module.drag);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.drag"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetDrag(this LimitVelocityOverLifetimeModule module, MinMaxCurve drag)
        {
            module.drag = drag;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.drag"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetDrag(this LimitVelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> dragChanger)
        {
            module.drag = dragChanger(module.drag);
            return module;
        }
        #endregion

        #region DragMultiplier
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.dragMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeDragMultiplier(this ParticleSystem particleSystem, float dragMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.dragMultiplier = dragMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.dragMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeDragMultiplier(this ParticleSystem particleSystem, Func<float, float> dragMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.dragMultiplier = dragMultiplierChanger(module.dragMultiplier);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.dragMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetDragMultiplier(this LimitVelocityOverLifetimeModule module, float dragMultiplier)
        {
            module.dragMultiplier = dragMultiplier;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.dragMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetDragMultiplier(this LimitVelocityOverLifetimeModule module, Func<float, float> dragMultiplierChanger)
        {
            module.dragMultiplier = dragMultiplierChanger(module.dragMultiplier);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetEnabled(this LimitVelocityOverLifetimeModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetEnabled(this LimitVelocityOverLifetimeModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Limit
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limit"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimit(this ParticleSystem particleSystem, MinMaxCurve limit)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limit = limit;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.limit"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimit(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> limitChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limit = limitChanger(module.limit);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limit"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimit(this LimitVelocityOverLifetimeModule module, MinMaxCurve limit)
        {
            module.limit = limit;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.limit"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimit(this LimitVelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> limitChanger)
        {
            module.limit = limitChanger(module.limit);
            return module;
        }
        #endregion

        #region LimitMultiplier
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitMultiplier(this ParticleSystem particleSystem, float limitMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitMultiplier = limitMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.limitMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitMultiplier(this ParticleSystem particleSystem, Func<float, float> limitMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitMultiplier = limitMultiplierChanger(module.limitMultiplier);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitMultiplier(this LimitVelocityOverLifetimeModule module, float limitMultiplier)
        {
            module.limitMultiplier = limitMultiplier;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.limitMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitMultiplier(this LimitVelocityOverLifetimeModule module, Func<float, float> limitMultiplierChanger)
        {
            module.limitMultiplier = limitMultiplierChanger(module.limitMultiplier);
            return module;
        }
        #endregion

        #region LimitX
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitX(this ParticleSystem particleSystem, MinMaxCurve limitX)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitX = limitX;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.limitX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> limitXChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitX = limitXChanger(module.limitX);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitX(this LimitVelocityOverLifetimeModule module, MinMaxCurve limitX)
        {
            module.limitX = limitX;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.limitX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitX(this LimitVelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> limitXChanger)
        {
            module.limitX = limitXChanger(module.limitX);
            return module;
        }
        #endregion

        #region LimitXMultiplier
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitXMultiplier(this ParticleSystem particleSystem, float limitXMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitXMultiplier = limitXMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.limitXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitXMultiplier(this ParticleSystem particleSystem, Func<float, float> limitXMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitXMultiplier = limitXMultiplierChanger(module.limitXMultiplier);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitXMultiplier(this LimitVelocityOverLifetimeModule module, float limitXMultiplier)
        {
            module.limitXMultiplier = limitXMultiplier;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.limitXMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitXMultiplier(this LimitVelocityOverLifetimeModule module, Func<float, float> limitXMultiplierChanger)
        {
            module.limitXMultiplier = limitXMultiplierChanger(module.limitXMultiplier);
            return module;
        }
        #endregion

        #region LimitY
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitY(this ParticleSystem particleSystem, MinMaxCurve limitY)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitY = limitY;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.limitY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> limitYChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitY = limitYChanger(module.limitY);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitY(this LimitVelocityOverLifetimeModule module, MinMaxCurve limitY)
        {
            module.limitY = limitY;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.limitY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitY(this LimitVelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> limitYChanger)
        {
            module.limitY = limitYChanger(module.limitY);
            return module;
        }
        #endregion

        #region LimitYMultiplier
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitYMultiplier(this ParticleSystem particleSystem, float limitYMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitYMultiplier = limitYMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.limitYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitYMultiplier(this ParticleSystem particleSystem, Func<float, float> limitYMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitYMultiplier = limitYMultiplierChanger(module.limitYMultiplier);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitYMultiplier(this LimitVelocityOverLifetimeModule module, float limitYMultiplier)
        {
            module.limitYMultiplier = limitYMultiplier;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.limitYMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitYMultiplier(this LimitVelocityOverLifetimeModule module, Func<float, float> limitYMultiplierChanger)
        {
            module.limitYMultiplier = limitYMultiplierChanger(module.limitYMultiplier);
            return module;
        }
        #endregion

        #region LimitZ
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitZ(this ParticleSystem particleSystem, MinMaxCurve limitZ)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitZ = limitZ;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.limitZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> limitZChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitZ = limitZChanger(module.limitZ);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitZ(this LimitVelocityOverLifetimeModule module, MinMaxCurve limitZ)
        {
            module.limitZ = limitZ;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.limitZ"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitZ(this LimitVelocityOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> limitZChanger)
        {
            module.limitZ = limitZChanger(module.limitZ);
            return module;
        }
        #endregion

        #region LimitZMultiplier
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitZMultiplier(this ParticleSystem particleSystem, float limitZMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitZMultiplier = limitZMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.limitZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeLimitZMultiplier(this ParticleSystem particleSystem, Func<float, float> limitZMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.limitZMultiplier = limitZMultiplierChanger(module.limitZMultiplier);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.limitZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitZMultiplier(this LimitVelocityOverLifetimeModule module, float limitZMultiplier)
        {
            module.limitZMultiplier = limitZMultiplier;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.limitZMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetLimitZMultiplier(this LimitVelocityOverLifetimeModule module, Func<float, float> limitZMultiplierChanger)
        {
            module.limitZMultiplier = limitZMultiplierChanger(module.limitZMultiplier);
            return module;
        }
        #endregion

        #region MultiplyDragByParticleSize
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.multiplyDragByParticleSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeMultiplyDragByParticleSize(this ParticleSystem particleSystem, bool multiplyDragByParticleSize)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.multiplyDragByParticleSize = multiplyDragByParticleSize;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.multiplyDragByParticleSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeMultiplyDragByParticleSize(this ParticleSystem particleSystem, Func<bool, bool> multiplyDragByParticleSizeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.multiplyDragByParticleSize = multiplyDragByParticleSizeChanger(module.multiplyDragByParticleSize);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.multiplyDragByParticleSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetMultiplyDragByParticleSize(this LimitVelocityOverLifetimeModule module, bool multiplyDragByParticleSize)
        {
            module.multiplyDragByParticleSize = multiplyDragByParticleSize;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.multiplyDragByParticleSize"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetMultiplyDragByParticleSize(this LimitVelocityOverLifetimeModule module, Func<bool, bool> multiplyDragByParticleSizeChanger)
        {
            module.multiplyDragByParticleSize = multiplyDragByParticleSizeChanger(module.multiplyDragByParticleSize);
            return module;
        }
        #endregion

        #region MultiplyDragByParticleVelocity
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.multiplyDragByParticleVelocity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeMultiplyDragByParticleVelocity(this ParticleSystem particleSystem, bool multiplyDragByParticleVelocity)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.multiplyDragByParticleVelocity = multiplyDragByParticleVelocity;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.multiplyDragByParticleVelocity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeMultiplyDragByParticleVelocity(this ParticleSystem particleSystem, Func<bool, bool> multiplyDragByParticleVelocityChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.multiplyDragByParticleVelocity = multiplyDragByParticleVelocityChanger(module.multiplyDragByParticleVelocity);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.multiplyDragByParticleVelocity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetMultiplyDragByParticleVelocity(this LimitVelocityOverLifetimeModule module, bool multiplyDragByParticleVelocity)
        {
            module.multiplyDragByParticleVelocity = multiplyDragByParticleVelocity;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.multiplyDragByParticleVelocity"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetMultiplyDragByParticleVelocity(this LimitVelocityOverLifetimeModule module, Func<bool, bool> multiplyDragByParticleVelocityChanger)
        {
            module.multiplyDragByParticleVelocity = multiplyDragByParticleVelocityChanger(module.multiplyDragByParticleVelocity);
            return module;
        }
        #endregion

        #region SeparateAxes
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeSeparateAxes(this ParticleSystem particleSystem, bool separateAxes)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.separateAxes = separateAxes;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeSeparateAxes(this ParticleSystem particleSystem, Func<bool, bool> separateAxesChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetSeparateAxes(this LimitVelocityOverLifetimeModule module, bool separateAxes)
        {
            module.separateAxes = separateAxes;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetSeparateAxes(this LimitVelocityOverLifetimeModule module, Func<bool, bool> separateAxesChanger)
        {
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return module;
        }
        #endregion

        #region Space
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.space"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeSpace(this ParticleSystem particleSystem, ParticleSystemSimulationSpace space)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.space = space;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="LimitVelocityOverLifetimeModule.space"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetLimitVelocityOverLifetimeSpace(this ParticleSystem particleSystem, Func<ParticleSystemSimulationSpace, ParticleSystemSimulationSpace> spaceChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.limitVelocityOverLifetime;
            module.space = spaceChanger(module.space);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="LimitVelocityOverLifetimeModule.space"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetSpace(this LimitVelocityOverLifetimeModule module, ParticleSystemSimulationSpace space)
        {
            module.space = space;
            return module;
        }

        /// <summary>
        /// Edit see cref="LimitVelocityOverLifetimeModule.space"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static LimitVelocityOverLifetimeModule SetSpace(this LimitVelocityOverLifetimeModule module, Func<ParticleSystemSimulationSpace, ParticleSystemSimulationSpace> spaceChanger)
        {
            module.space = spaceChanger(module.space);
            return module;
        }
        #endregion
#endif
    }
}
