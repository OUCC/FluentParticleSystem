using System;
using System.Runtime.CompilerServices;
using UnityEngine;

using static UnityEngine.ParticleSystem;

#if UNITY_2020_2_OR_NEWER
using System.Diagnostics.CodeAnalysis;
#endif

namespace OUCC.FluentParticleSystem
{
    public static class RotationBySpeedModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.rotationBySpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem EditRotationBySpeed(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem,
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            Action<RotationBySpeedModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.rotationBySpeed);
            return particleSystem;
        }

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="RotationBySpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedEnabled(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.rotationBySpeed;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedEnabled(
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
            var module = particleSystem.rotationBySpeed;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="RotationBySpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetEnabled(this RotationBySpeedModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetEnabled(this RotationBySpeedModule module,
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
        /// Assign a value to <see cref="RotationBySpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedRange(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, Vector2 range)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.rotationBySpeed;
            module.range = range;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedRange(
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
            var module = particleSystem.rotationBySpeed;
            module.range = rangeChanger(module.range);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="RotationBySpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetRange(this RotationBySpeedModule module, Vector2 range)
        {
            module.range = range;
            return module;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.range"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetRange(this RotationBySpeedModule module,
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
        /// Assign a value to <see cref="RotationBySpeedModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedSeparateAxes(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, bool separateAxes)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.rotationBySpeed;
            module.separateAxes = separateAxes;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedSeparateAxes(
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
            var module = particleSystem.rotationBySpeed;
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="RotationBySpeedModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetSeparateAxes(this RotationBySpeedModule module, bool separateAxes)
        {
            module.separateAxes = separateAxes;
            return module;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetSeparateAxes(this RotationBySpeedModule module,
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

        #region X
        /// <summary>
        /// Assign a value to <see cref="RotationBySpeedModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedX(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve x)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.rotationBySpeed;
            module.x = x;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedX(
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
            var module = particleSystem.rotationBySpeed;
            module.x = xChanger(module.x);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="RotationBySpeedModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetX(this RotationBySpeedModule module, MinMaxCurve x)
        {
            module.x = x;
            return module;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetX(this RotationBySpeedModule module,
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
        /// Assign a value to <see cref="RotationBySpeedModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedXMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float xMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.rotationBySpeed;
            module.xMultiplier = xMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedXMultiplier(
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
            var module = particleSystem.rotationBySpeed;
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="RotationBySpeedModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetXMultiplier(this RotationBySpeedModule module, float xMultiplier)
        {
            module.xMultiplier = xMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetXMultiplier(this RotationBySpeedModule module,
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
        /// Assign a value to <see cref="RotationBySpeedModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedY(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve y)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.rotationBySpeed;
            module.y = y;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedY(
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
            var module = particleSystem.rotationBySpeed;
            module.y = yChanger(module.y);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="RotationBySpeedModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetY(this RotationBySpeedModule module, MinMaxCurve y)
        {
            module.y = y;
            return module;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetY(this RotationBySpeedModule module,
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
        /// Assign a value to <see cref="RotationBySpeedModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedYMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float yMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.rotationBySpeed;
            module.yMultiplier = yMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedYMultiplier(
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
            var module = particleSystem.rotationBySpeed;
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="RotationBySpeedModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetYMultiplier(this RotationBySpeedModule module, float yMultiplier)
        {
            module.yMultiplier = yMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetYMultiplier(this RotationBySpeedModule module,
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
        /// Assign a value to <see cref="RotationBySpeedModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedZ(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, MinMaxCurve z)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.rotationBySpeed;
            module.z = z;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedZ(
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
            var module = particleSystem.rotationBySpeed;
            module.z = zChanger(module.z);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="RotationBySpeedModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetZ(this RotationBySpeedModule module, MinMaxCurve z)
        {
            module.z = z;
            return module;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetZ(this RotationBySpeedModule module,
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
        /// Assign a value to <see cref="RotationBySpeedModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedZMultiplier(
#if UNITY_2020_2_OR_NEWER
            [DisallowNull]
#endif
            this ParticleSystem particleSystem, float zMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.rotationBySpeed;
            module.zMultiplier = zMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if UNITY_2020_2_OR_NEWER
        [return: NotNull]
#endif
        public static ParticleSystem SetRotationBySpeedZMultiplier(
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
            var module = particleSystem.rotationBySpeed;
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="RotationBySpeedModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetZMultiplier(this RotationBySpeedModule module, float zMultiplier)
        {
            module.zMultiplier = zMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="RotationBySpeedModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationBySpeedModule SetZMultiplier(this RotationBySpeedModule module,
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
