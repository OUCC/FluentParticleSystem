using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class SizeBySpeedModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.sizeBySpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditSizeBySpeed(this ParticleSystem particleSystem, Action<SizeBySpeedModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.sizeBySpeed);
            return particleSystem;
        }

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetEnabled(this SizeBySpeedModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit see cref="SizeBySpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetEnabled(this SizeBySpeedModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Range
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedRange(this ParticleSystem particleSystem, Vector2 range)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.range = range;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedRange(this ParticleSystem particleSystem, Func<Vector2, Vector2> rangeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.range = rangeChanger(module.range);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetRange(this SizeBySpeedModule module, Vector2 range)
        {
            module.range = range;
            return module;
        }

        /// <summary>
        /// Edit see cref="SizeBySpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetRange(this SizeBySpeedModule module, Func<Vector2, Vector2> rangeChanger)
        {
            module.range = rangeChanger(module.range);
            return module;
        }
        #endregion

        #region SeparateAxes
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedSeparateAxes(this ParticleSystem particleSystem, bool separateAxes)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.separateAxes = separateAxes;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedSeparateAxes(this ParticleSystem particleSystem, Func<bool, bool> separateAxesChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetSeparateAxes(this SizeBySpeedModule module, bool separateAxes)
        {
            module.separateAxes = separateAxes;
            return module;
        }

        /// <summary>
        /// Edit see cref="SizeBySpeedModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetSeparateAxes(this SizeBySpeedModule module, Func<bool, bool> separateAxesChanger)
        {
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return module;
        }
        #endregion

        #region Size
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.size"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedSize(this ParticleSystem particleSystem, MinMaxCurve size)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.size = size;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.size"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedSize(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> sizeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.size = sizeChanger(module.size);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.size"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetSize(this SizeBySpeedModule module, MinMaxCurve size)
        {
            module.size = size;
            return module;
        }

        /// <summary>
        /// Edit see cref="SizeBySpeedModule.size"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetSize(this SizeBySpeedModule module, Func<MinMaxCurve, MinMaxCurve> sizeChanger)
        {
            module.size = sizeChanger(module.size);
            return module;
        }
        #endregion

        #region SizeMultiplier
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.sizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedSizeMultiplier(this ParticleSystem particleSystem, float sizeMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.sizeMultiplier = sizeMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.sizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedSizeMultiplier(this ParticleSystem particleSystem, Func<float, float> sizeMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.sizeMultiplier = sizeMultiplierChanger(module.sizeMultiplier);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.sizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetSizeMultiplier(this SizeBySpeedModule module, float sizeMultiplier)
        {
            module.sizeMultiplier = sizeMultiplier;
            return module;
        }

        /// <summary>
        /// Edit see cref="SizeBySpeedModule.sizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetSizeMultiplier(this SizeBySpeedModule module, Func<float, float> sizeMultiplierChanger)
        {
            module.sizeMultiplier = sizeMultiplierChanger(module.sizeMultiplier);
            return module;
        }
        #endregion

        #region X
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedX(this ParticleSystem particleSystem, MinMaxCurve x)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.x = x;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.x = xChanger(module.x);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetX(this SizeBySpeedModule module, MinMaxCurve x)
        {
            module.x = x;
            return module;
        }

        /// <summary>
        /// Edit see cref="SizeBySpeedModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetX(this SizeBySpeedModule module, Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            module.x = xChanger(module.x);
            return module;
        }
        #endregion

        #region XMultiplier
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedXMultiplier(this ParticleSystem particleSystem, float xMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.xMultiplier = xMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedXMultiplier(this ParticleSystem particleSystem, Func<float, float> xMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetXMultiplier(this SizeBySpeedModule module, float xMultiplier)
        {
            module.xMultiplier = xMultiplier;
            return module;
        }

        /// <summary>
        /// Edit see cref="SizeBySpeedModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetXMultiplier(this SizeBySpeedModule module, Func<float, float> xMultiplierChanger)
        {
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return module;
        }
        #endregion

        #region Y
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedY(this ParticleSystem particleSystem, MinMaxCurve y)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.y = y;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.y = yChanger(module.y);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetY(this SizeBySpeedModule module, MinMaxCurve y)
        {
            module.y = y;
            return module;
        }

        /// <summary>
        /// Edit see cref="SizeBySpeedModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetY(this SizeBySpeedModule module, Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            module.y = yChanger(module.y);
            return module;
        }
        #endregion

        #region YMultiplier
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedYMultiplier(this ParticleSystem particleSystem, float yMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.yMultiplier = yMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedYMultiplier(this ParticleSystem particleSystem, Func<float, float> yMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetYMultiplier(this SizeBySpeedModule module, float yMultiplier)
        {
            module.yMultiplier = yMultiplier;
            return module;
        }

        /// <summary>
        /// Edit see cref="SizeBySpeedModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetYMultiplier(this SizeBySpeedModule module, Func<float, float> yMultiplierChanger)
        {
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return module;
        }
        #endregion

        #region Z
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedZ(this ParticleSystem particleSystem, MinMaxCurve z)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.z = z;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.z = zChanger(module.z);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetZ(this SizeBySpeedModule module, MinMaxCurve z)
        {
            module.z = z;
            return module;
        }

        /// <summary>
        /// Edit see cref="SizeBySpeedModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetZ(this SizeBySpeedModule module, Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            module.z = zChanger(module.z);
            return module;
        }
        #endregion

        #region ZMultiplier
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedZMultiplier(this ParticleSystem particleSystem, float zMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.zMultiplier = zMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeBySpeedZMultiplier(this ParticleSystem particleSystem, Func<float, float> zMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeBySpeed;
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return particleSystem;
        }

        
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetZMultiplier(this SizeBySpeedModule module, float zMultiplier)
        {
            module.zMultiplier = zMultiplier;
            return module;
        }

        /// <summary>
        /// Edit see cref="SizeBySpeedModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetZMultiplier(this SizeBySpeedModule module, Func<float, float> zMultiplierChanger)
        {
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return module;
        }
        #endregion
#endif
    }
}
