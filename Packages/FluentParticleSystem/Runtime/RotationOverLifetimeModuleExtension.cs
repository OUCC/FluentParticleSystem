using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class RotationOverLifetimeModuleExtension
    {
#if UNITY_2021_3_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditRotationOverLifetime(this ParticleSystem particleSystem, Action<RotationOverLifetimeModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.rotationOverLifetime);
            return particleSystem;
        }

        #region Enabled
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetEnabled(this RotationOverLifetimeModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetEnabled(this RotationOverLifetimeModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region SeparateAxes
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeSeparateAxes(this ParticleSystem particleSystem, bool separateAxes)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.separateAxes = separateAxes;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeSeparateAxes(this ParticleSystem particleSystem, Func<bool, bool> separateAxesChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetSeparateAxes(this RotationOverLifetimeModule module, bool separateAxes)
        {
            module.separateAxes = separateAxes;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetSeparateAxes(this RotationOverLifetimeModule module, Func<bool, bool> separateAxesChanger)
        {
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return module;
        }
        #endregion

        #region X
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeX(this ParticleSystem particleSystem, MinMaxCurve x)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.x = x;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.x = xChanger(module.x);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetX(this RotationOverLifetimeModule module, MinMaxCurve x)
        {
            module.x = x;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetX(this RotationOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            module.x = xChanger(module.x);
            return module;
        }
        #endregion

        #region XMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeXMultiplier(this ParticleSystem particleSystem, float xMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.xMultiplier = xMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeXMultiplier(this ParticleSystem particleSystem, Func<float, float> xMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetXMultiplier(this RotationOverLifetimeModule module, float xMultiplier)
        {
            module.xMultiplier = xMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetXMultiplier(this RotationOverLifetimeModule module, Func<float, float> xMultiplierChanger)
        {
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return module;
        }
        #endregion

        #region Y
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeY(this ParticleSystem particleSystem, MinMaxCurve y)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.y = y;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.y = yChanger(module.y);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetY(this RotationOverLifetimeModule module, MinMaxCurve y)
        {
            module.y = y;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetY(this RotationOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            module.y = yChanger(module.y);
            return module;
        }
        #endregion

        #region YMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeYMultiplier(this ParticleSystem particleSystem, float yMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.yMultiplier = yMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeYMultiplier(this ParticleSystem particleSystem, Func<float, float> yMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetYMultiplier(this RotationOverLifetimeModule module, float yMultiplier)
        {
            module.yMultiplier = yMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetYMultiplier(this RotationOverLifetimeModule module, Func<float, float> yMultiplierChanger)
        {
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return module;
        }
        #endregion

        #region Z
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeZ(this ParticleSystem particleSystem, MinMaxCurve z)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.z = z;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.z = zChanger(module.z);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetZ(this RotationOverLifetimeModule module, MinMaxCurve z)
        {
            module.z = z;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetZ(this RotationOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            module.z = zChanger(module.z);
            return module;
        }
        #endregion

        #region ZMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeZMultiplier(this ParticleSystem particleSystem, float zMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.zMultiplier = zMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetRotationOverLifetimeZMultiplier(this ParticleSystem particleSystem, Func<float, float> zMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.rotationOverLifetime;
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetZMultiplier(this RotationOverLifetimeModule module, float zMultiplier)
        {
            module.zMultiplier = zMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RotationOverLifetimeModule SetZMultiplier(this RotationOverLifetimeModule module, Func<float, float> zMultiplierChanger)
        {
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return module;
        }
        #endregion
#endif
    }
}
