using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class SizeOverLifetimeModuleExtension
    {
#if UNITY_2019_4_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditSizeOverLifetime(this ParticleSystem particleSystem, Action<SizeOverLifetimeModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.sizeOverLifetime);
            return particleSystem;
        }

        #region Enabled
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetEnabled(this SizeOverLifetimeModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetEnabled(this SizeOverLifetimeModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region SeparateAxes
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeSeparateAxes(this ParticleSystem particleSystem, bool separateAxes)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.separateAxes = separateAxes;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeSeparateAxes(this ParticleSystem particleSystem, Func<bool, bool> separateAxesChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetSeparateAxes(this SizeOverLifetimeModule module, bool separateAxes)
        {
            module.separateAxes = separateAxes;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetSeparateAxes(this SizeOverLifetimeModule module, Func<bool, bool> separateAxesChanger)
        {
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return module;
        }
        #endregion

        #region Size
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeSize(this ParticleSystem particleSystem, MinMaxCurve size)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.size = size;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeSize(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> sizeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.size = sizeChanger(module.size);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetSize(this SizeOverLifetimeModule module, MinMaxCurve size)
        {
            module.size = size;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetSize(this SizeOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> sizeChanger)
        {
            module.size = sizeChanger(module.size);
            return module;
        }
        #endregion

        #region SizeMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeSizeMultiplier(this ParticleSystem particleSystem, float sizeMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.sizeMultiplier = sizeMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeSizeMultiplier(this ParticleSystem particleSystem, Func<float, float> sizeMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.sizeMultiplier = sizeMultiplierChanger(module.sizeMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetSizeMultiplier(this SizeOverLifetimeModule module, float sizeMultiplier)
        {
            module.sizeMultiplier = sizeMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetSizeMultiplier(this SizeOverLifetimeModule module, Func<float, float> sizeMultiplierChanger)
        {
            module.sizeMultiplier = sizeMultiplierChanger(module.sizeMultiplier);
            return module;
        }
        #endregion

        #region X
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeX(this ParticleSystem particleSystem, MinMaxCurve x)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.x = x;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.x = xChanger(module.x);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetX(this SizeOverLifetimeModule module, MinMaxCurve x)
        {
            module.x = x;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetX(this SizeOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            module.x = xChanger(module.x);
            return module;
        }
        #endregion

        #region XMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeXMultiplier(this ParticleSystem particleSystem, float xMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.xMultiplier = xMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeXMultiplier(this ParticleSystem particleSystem, Func<float, float> xMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetXMultiplier(this SizeOverLifetimeModule module, float xMultiplier)
        {
            module.xMultiplier = xMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetXMultiplier(this SizeOverLifetimeModule module, Func<float, float> xMultiplierChanger)
        {
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return module;
        }
        #endregion

        #region Y
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeY(this ParticleSystem particleSystem, MinMaxCurve y)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.y = y;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.y = yChanger(module.y);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetY(this SizeOverLifetimeModule module, MinMaxCurve y)
        {
            module.y = y;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetY(this SizeOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            module.y = yChanger(module.y);
            return module;
        }
        #endregion

        #region YMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeYMultiplier(this ParticleSystem particleSystem, float yMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.yMultiplier = yMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeYMultiplier(this ParticleSystem particleSystem, Func<float, float> yMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetYMultiplier(this SizeOverLifetimeModule module, float yMultiplier)
        {
            module.yMultiplier = yMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetYMultiplier(this SizeOverLifetimeModule module, Func<float, float> yMultiplierChanger)
        {
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return module;
        }
        #endregion

        #region Z
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeZ(this ParticleSystem particleSystem, MinMaxCurve z)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.z = z;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.z = zChanger(module.z);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetZ(this SizeOverLifetimeModule module, MinMaxCurve z)
        {
            module.z = z;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetZ(this SizeOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            module.z = zChanger(module.z);
            return module;
        }
        #endregion

        #region ZMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeZMultiplier(this ParticleSystem particleSystem, float zMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.zMultiplier = zMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeZMultiplier(this ParticleSystem particleSystem, Func<float, float> zMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.sizeOverLifetime;
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetZMultiplier(this SizeOverLifetimeModule module, float zMultiplier)
        {
            module.zMultiplier = zMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetZMultiplier(this SizeOverLifetimeModule module, Func<float, float> zMultiplierChanger)
        {
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return module;
        }
        #endregion
#endif
    }
}
