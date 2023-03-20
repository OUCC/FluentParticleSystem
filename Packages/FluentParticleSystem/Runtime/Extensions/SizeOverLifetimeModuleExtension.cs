using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class SizeOverLifetimeModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.sizeOverLifetime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditSizeOverLifetime(this ParticleSystem particleSystem, Action<SizeOverLifetimeModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.sizeOverLifetime);
            return particleSystem;
        }

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetEnabled(this SizeOverLifetimeModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetEnabled(this SizeOverLifetimeModule module, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region SeparateAxes
        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeSeparateAxes(this ParticleSystem particleSystem, bool separateAxes)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.separateAxes = separateAxes;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeSeparateAxes(this ParticleSystem particleSystem, Func<bool, bool> separateAxesChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(separateAxesChanger != null, "separateAxesChanger cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetSeparateAxes(this SizeOverLifetimeModule module, bool separateAxes)
        {
            module.separateAxes = separateAxes;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.separateAxes"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetSeparateAxes(this SizeOverLifetimeModule module, Func<bool, bool> separateAxesChanger)
        {
            Debug.Assert(separateAxesChanger != null, "separateAxesChanger cannot be null");
            module.separateAxes = separateAxesChanger(module.separateAxes);
            return module;
        }
        #endregion

        #region Size
        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.size"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeSize(this ParticleSystem particleSystem, MinMaxCurve size)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.size = size;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.size"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeSize(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> sizeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(sizeChanger != null, "sizeChanger cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.size = sizeChanger(module.size);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.size"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetSize(this SizeOverLifetimeModule module, MinMaxCurve size)
        {
            module.size = size;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.size"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetSize(this SizeOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> sizeChanger)
        {
            Debug.Assert(sizeChanger != null, "sizeChanger cannot be null");
            module.size = sizeChanger(module.size);
            return module;
        }
        #endregion

        #region SizeMultiplier
        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.sizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeSizeMultiplier(this ParticleSystem particleSystem, float sizeMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.sizeMultiplier = sizeMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.sizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeSizeMultiplier(this ParticleSystem particleSystem, Func<float, float> sizeMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(sizeMultiplierChanger != null, "sizeMultiplierChanger cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.sizeMultiplier = sizeMultiplierChanger(module.sizeMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.sizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetSizeMultiplier(this SizeOverLifetimeModule module, float sizeMultiplier)
        {
            module.sizeMultiplier = sizeMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.sizeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetSizeMultiplier(this SizeOverLifetimeModule module, Func<float, float> sizeMultiplierChanger)
        {
            Debug.Assert(sizeMultiplierChanger != null, "sizeMultiplierChanger cannot be null");
            module.sizeMultiplier = sizeMultiplierChanger(module.sizeMultiplier);
            return module;
        }
        #endregion

        #region X
        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeX(this ParticleSystem particleSystem, MinMaxCurve x)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.x = x;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeX(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(xChanger != null, "xChanger cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.x = xChanger(module.x);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetX(this SizeOverLifetimeModule module, MinMaxCurve x)
        {
            module.x = x;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.x"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetX(this SizeOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> xChanger)
        {
            Debug.Assert(xChanger != null, "xChanger cannot be null");
            module.x = xChanger(module.x);
            return module;
        }
        #endregion

        #region XMultiplier
        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeXMultiplier(this ParticleSystem particleSystem, float xMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.xMultiplier = xMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeXMultiplier(this ParticleSystem particleSystem, Func<float, float> xMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(xMultiplierChanger != null, "xMultiplierChanger cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetXMultiplier(this SizeOverLifetimeModule module, float xMultiplier)
        {
            module.xMultiplier = xMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.xMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetXMultiplier(this SizeOverLifetimeModule module, Func<float, float> xMultiplierChanger)
        {
            Debug.Assert(xMultiplierChanger != null, "xMultiplierChanger cannot be null");
            module.xMultiplier = xMultiplierChanger(module.xMultiplier);
            return module;
        }
        #endregion

        #region Y
        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeY(this ParticleSystem particleSystem, MinMaxCurve y)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.y = y;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeY(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(yChanger != null, "yChanger cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.y = yChanger(module.y);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetY(this SizeOverLifetimeModule module, MinMaxCurve y)
        {
            module.y = y;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.y"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetY(this SizeOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> yChanger)
        {
            Debug.Assert(yChanger != null, "yChanger cannot be null");
            module.y = yChanger(module.y);
            return module;
        }
        #endregion

        #region YMultiplier
        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeYMultiplier(this ParticleSystem particleSystem, float yMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.yMultiplier = yMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeYMultiplier(this ParticleSystem particleSystem, Func<float, float> yMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(yMultiplierChanger != null, "yMultiplierChanger cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetYMultiplier(this SizeOverLifetimeModule module, float yMultiplier)
        {
            module.yMultiplier = yMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.yMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetYMultiplier(this SizeOverLifetimeModule module, Func<float, float> yMultiplierChanger)
        {
            Debug.Assert(yMultiplierChanger != null, "yMultiplierChanger cannot be null");
            module.yMultiplier = yMultiplierChanger(module.yMultiplier);
            return module;
        }
        #endregion

        #region Z
        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeZ(this ParticleSystem particleSystem, MinMaxCurve z)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.z = z;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeZ(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(zChanger != null, "zChanger cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.z = zChanger(module.z);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetZ(this SizeOverLifetimeModule module, MinMaxCurve z)
        {
            module.z = z;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.z"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetZ(this SizeOverLifetimeModule module, Func<MinMaxCurve, MinMaxCurve> zChanger)
        {
            Debug.Assert(zChanger != null, "zChanger cannot be null");
            module.z = zChanger(module.z);
            return module;
        }
        #endregion

        #region ZMultiplier
        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeZMultiplier(this ParticleSystem particleSystem, float zMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.zMultiplier = zMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetSizeOverLifetimeZMultiplier(this ParticleSystem particleSystem, Func<float, float> zMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(zMultiplierChanger != null, "zMultiplierChanger cannot be null");
            var module = particleSystem.sizeOverLifetime;
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="SizeOverLifetimeModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetZMultiplier(this SizeOverLifetimeModule module, float zMultiplier)
        {
            module.zMultiplier = zMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="SizeOverLifetimeModule.zMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SizeOverLifetimeModule SetZMultiplier(this SizeOverLifetimeModule module, Func<float, float> zMultiplierChanger)
        {
            Debug.Assert(zMultiplierChanger != null, "zMultiplierChanger cannot be null");
            module.zMultiplier = zMultiplierChanger(module.zMultiplier);
            return module;
        }
        #endregion
#endif
    }
}
