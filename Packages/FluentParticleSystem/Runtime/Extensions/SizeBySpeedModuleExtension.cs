using System;
using System.Runtime.CompilerServices;
using UnityEngine;

using static UnityEngine.ParticleSystem;

#if UNITY_2020_2_OR_NEWER
using System.Diagnostics.CodeAnalysis;
#endif

namespace OUCC.FluentParticleSystem
{
    public static class SizeBySpeedModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.sizeBySpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem EditSizeBySpeed(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Action<SizeBySpeedModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.sizeBySpeed);
            return particleSystem;
        }

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedEnabled(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeBySpeed;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedEnabled(
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
        /// Edit <see cref="SizeBySpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetEnabled(this SizeBySpeedModule module,
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

        #region Range
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedRange(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, Vector2 range)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeBySpeed;
            module.range = range;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedRange(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<Vector2, Vector2> rangeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rangeChanger != null, "rangeChanger cannot be null");
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
        /// Edit <see cref="SizeBySpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetRange(this SizeBySpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<Vector2, Vector2> rangeChanger)
        {
            Debug.Assert(rangeChanger != null, "rangeChanger cannot be null");
            module.range = rangeChanger(module.range);
            return module;
        }
        #endregion

        #region SeparateAxes
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedSeparateAxes(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool separateAxes)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeBySpeed;
            module.separateAxes = separateAxes;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedSeparateAxes(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<bool, bool> separateAxesChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(separateAxesChanger != null, "separateAxesChanger cannot be null");
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
        /// Edit <see cref="SizeBySpeedModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetSeparateAxes(this SizeBySpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<bool, bool> separateAxesChanger)
        {
            Debug.Assert(separateAxesChanger != null, "separateAxesChanger cannot be null");
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return module;
        }
        #endregion

        #region Size
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.size"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedSize(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve size)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeBySpeed;
            module.size = size;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.size"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedSize(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<MinMaxCurve, MinMaxCurve> sizeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(sizeChanger != null, "sizeChanger cannot be null");
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
        /// Edit <see cref="SizeBySpeedModule.size"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetSize(this SizeBySpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<MinMaxCurve, MinMaxCurve> sizeChanger)
        {
            Debug.Assert(sizeChanger != null, "sizeChanger cannot be null");
            module.size = sizeChanger(module.size);
            return module;
        }
        #endregion

        #region SizeMultiplier
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.sizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedSizeMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float sizeMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeBySpeed;
            module.sizeMultiplier = sizeMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.sizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedSizeMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> sizeMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(sizeMultiplierChanger != null, "sizeMultiplierChanger cannot be null");
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
        /// Edit <see cref="SizeBySpeedModule.sizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetSizeMultiplier(this SizeBySpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> sizeMultiplierChanger)
        {
            Debug.Assert(sizeMultiplierChanger != null, "sizeMultiplierChanger cannot be null");
            module.sizeMultiplier = sizeMultiplierChanger(module.sizeMultiplier);
            return module;
        }
        #endregion

        #region X
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedX(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve x)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeBySpeed;
            module.x = x;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedX(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(xChanger != null, "xChanger cannot be null");
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
        /// Edit <see cref="SizeBySpeedModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetX(this SizeBySpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            Debug.Assert(xChanger != null, "xChanger cannot be null");
            module.x = xChanger(module.x);
            return module;
        }
        #endregion

        #region XMultiplier
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedXMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float xMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeBySpeed;
            module.xMultiplier = xMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedXMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> xMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(xMultiplierChanger != null, "xMultiplierChanger cannot be null");
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
        /// Edit <see cref="SizeBySpeedModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetXMultiplier(this SizeBySpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> xMultiplierChanger)
        {
            Debug.Assert(xMultiplierChanger != null, "xMultiplierChanger cannot be null");
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return module;
        }
        #endregion

        #region Y
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedY(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve y)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeBySpeed;
            module.y = y;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedY(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(yChanger != null, "yChanger cannot be null");
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
        /// Edit <see cref="SizeBySpeedModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetY(this SizeBySpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            Debug.Assert(yChanger != null, "yChanger cannot be null");
            module.y = yChanger(module.y);
            return module;
        }
        #endregion

        #region YMultiplier
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedYMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float yMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeBySpeed;
            module.yMultiplier = yMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedYMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> yMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(yMultiplierChanger != null, "yMultiplierChanger cannot be null");
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
        /// Edit <see cref="SizeBySpeedModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetYMultiplier(this SizeBySpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> yMultiplierChanger)
        {
            Debug.Assert(yMultiplierChanger != null, "yMultiplierChanger cannot be null");
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return module;
        }
        #endregion

        #region Z
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedZ(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve z)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeBySpeed;
            module.z = z;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedZ(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(zChanger != null, "zChanger cannot be null");
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
        /// Edit <see cref="SizeBySpeedModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetZ(this SizeBySpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            Debug.Assert(zChanger != null, "zChanger cannot be null");
            module.z = zChanger(module.z);
            return module;
        }
        #endregion

        #region ZMultiplier
        /// <summary>
        /// Assign a value to <see cref="SizeBySpeedModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedZMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float zMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeBySpeed;
            module.zMultiplier = zMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeBySpeedModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetSizeBySpeedZMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
             Func<float, float> zMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(zMultiplierChanger != null, "zMultiplierChanger cannot be null");
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
        /// Edit <see cref="SizeBySpeedModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeBySpeedModule SetZMultiplier(this SizeBySpeedModule module,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Func<float, float> zMultiplierChanger)
        {
            Debug.Assert(zMultiplierChanger != null, "zMultiplierChanger cannot be null");
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return module;
        }
        #endregion
#endif
    }
}
