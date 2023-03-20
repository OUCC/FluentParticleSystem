#if UNITY_2020_2_OR_NEWER
#nullable enable
#endif
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class TextureSheetAnimationModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.textureSheetAnimation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditTextureSheetAnimation(this ParticleSystem particleSystem, Action<TextureSheetAnimationModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.textureSheetAnimation);
            return particleSystem;
        }

        #region Animation
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.animation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationAnimation(this ParticleSystem particleSystem, ParticleSystemAnimationType animation)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.animation = animation;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.animation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationAnimation(this ParticleSystem particleSystem, Func<ParticleSystemAnimationType, ParticleSystemAnimationType> animationChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(animationChanger != null, "animationChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.animation = animationChanger(module.animation);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.animation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetAnimation(this TextureSheetAnimationModule module, ParticleSystemAnimationType animation)
        {
            module.animation = animation;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.animation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetAnimation(this TextureSheetAnimationModule module, Func<ParticleSystemAnimationType, ParticleSystemAnimationType> animationChanger)
        {
            Debug.Assert(animationChanger != null, "animationChanger cannot be null");
            module.animation = animationChanger(module.animation);
            return module;
        }
        #endregion

        #region CycleCount
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.cycleCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationCycleCount(this ParticleSystem particleSystem, int cycleCount)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.cycleCount = cycleCount;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.cycleCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationCycleCount(this ParticleSystem particleSystem, Func<int, int> cycleCountChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(cycleCountChanger != null, "cycleCountChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.cycleCount = cycleCountChanger(module.cycleCount);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.cycleCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetCycleCount(this TextureSheetAnimationModule module, int cycleCount)
        {
            module.cycleCount = cycleCount;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.cycleCount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetCycleCount(this TextureSheetAnimationModule module, Func<int, int> cycleCountChanger)
        {
            Debug.Assert(cycleCountChanger != null, "cycleCountChanger cannot be null");
            module.cycleCount = cycleCountChanger(module.cycleCount);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetEnabled(this TextureSheetAnimationModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetEnabled(this TextureSheetAnimationModule module, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region FlipU
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.flipU"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("flipU property is deprecated. Use ParticleSystemRenderer.flip.x instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFlipU(this ParticleSystem particleSystem, float flipU)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.flipU = flipU;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.flipU"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("flipU property is deprecated. Use ParticleSystemRenderer.flip.x instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFlipU(this ParticleSystem particleSystem, Func<float, float> flipUChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(flipUChanger != null, "flipUChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.flipU = flipUChanger(module.flipU);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.flipU"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("flipU property is deprecated. Use ParticleSystemRenderer.flip.x instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFlipU(this TextureSheetAnimationModule module, float flipU)
        {
            module.flipU = flipU;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.flipU"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("flipU property is deprecated. Use ParticleSystemRenderer.flip.x instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFlipU(this TextureSheetAnimationModule module, Func<float, float> flipUChanger)
        {
            Debug.Assert(flipUChanger != null, "flipUChanger cannot be null");
            module.flipU = flipUChanger(module.flipU);
            return module;
        }
        #endregion

        #region FlipV
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.flipV"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("flipV property is deprecated. Use ParticleSystemRenderer.flip.y instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFlipV(this ParticleSystem particleSystem, float flipV)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.flipV = flipV;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.flipV"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("flipV property is deprecated. Use ParticleSystemRenderer.flip.y instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFlipV(this ParticleSystem particleSystem, Func<float, float> flipVChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(flipVChanger != null, "flipVChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.flipV = flipVChanger(module.flipV);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.flipV"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("flipV property is deprecated. Use ParticleSystemRenderer.flip.y instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFlipV(this TextureSheetAnimationModule module, float flipV)
        {
            module.flipV = flipV;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.flipV"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("flipV property is deprecated. Use ParticleSystemRenderer.flip.y instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFlipV(this TextureSheetAnimationModule module, Func<float, float> flipVChanger)
        {
            Debug.Assert(flipVChanger != null, "flipVChanger cannot be null");
            module.flipV = flipVChanger(module.flipV);
            return module;
        }
        #endregion

        #region Fps
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.fps"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFps(this ParticleSystem particleSystem, float fps)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.fps = fps;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.fps"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFps(this ParticleSystem particleSystem, Func<float, float> fpsChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(fpsChanger != null, "fpsChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.fps = fpsChanger(module.fps);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.fps"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFps(this TextureSheetAnimationModule module, float fps)
        {
            module.fps = fps;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.fps"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFps(this TextureSheetAnimationModule module, Func<float, float> fpsChanger)
        {
            Debug.Assert(fpsChanger != null, "fpsChanger cannot be null");
            module.fps = fpsChanger(module.fps);
            return module;
        }
        #endregion

        #region FrameOverTime
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.frameOverTime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFrameOverTime(this ParticleSystem particleSystem, MinMaxCurve frameOverTime)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.frameOverTime = frameOverTime;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.frameOverTime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFrameOverTime(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> frameOverTimeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(frameOverTimeChanger != null, "frameOverTimeChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.frameOverTime = frameOverTimeChanger(module.frameOverTime);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.frameOverTime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFrameOverTime(this TextureSheetAnimationModule module, MinMaxCurve frameOverTime)
        {
            module.frameOverTime = frameOverTime;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.frameOverTime"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFrameOverTime(this TextureSheetAnimationModule module, Func<MinMaxCurve, MinMaxCurve> frameOverTimeChanger)
        {
            Debug.Assert(frameOverTimeChanger != null, "frameOverTimeChanger cannot be null");
            module.frameOverTime = frameOverTimeChanger(module.frameOverTime);
            return module;
        }
        #endregion

        #region FrameOverTimeMultiplier
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.frameOverTimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFrameOverTimeMultiplier(this ParticleSystem particleSystem, float frameOverTimeMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.frameOverTimeMultiplier = frameOverTimeMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.frameOverTimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFrameOverTimeMultiplier(this ParticleSystem particleSystem, Func<float, float> frameOverTimeMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(frameOverTimeMultiplierChanger != null, "frameOverTimeMultiplierChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.frameOverTimeMultiplier = frameOverTimeMultiplierChanger(module.frameOverTimeMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.frameOverTimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFrameOverTimeMultiplier(this TextureSheetAnimationModule module, float frameOverTimeMultiplier)
        {
            module.frameOverTimeMultiplier = frameOverTimeMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.frameOverTimeMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFrameOverTimeMultiplier(this TextureSheetAnimationModule module, Func<float, float> frameOverTimeMultiplierChanger)
        {
            Debug.Assert(frameOverTimeMultiplierChanger != null, "frameOverTimeMultiplierChanger cannot be null");
            module.frameOverTimeMultiplier = frameOverTimeMultiplierChanger(module.frameOverTimeMultiplier);
            return module;
        }
        #endregion

        #region Mode
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationMode(this ParticleSystem particleSystem, ParticleSystemAnimationMode mode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.mode = mode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationMode(this ParticleSystem particleSystem, Func<ParticleSystemAnimationMode, ParticleSystemAnimationMode> modeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(modeChanger != null, "modeChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.mode = modeChanger(module.mode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetMode(this TextureSheetAnimationModule module, ParticleSystemAnimationMode mode)
        {
            module.mode = mode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.mode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetMode(this TextureSheetAnimationModule module, Func<ParticleSystemAnimationMode, ParticleSystemAnimationMode> modeChanger)
        {
            Debug.Assert(modeChanger != null, "modeChanger cannot be null");
            module.mode = modeChanger(module.mode);
            return module;
        }
        #endregion

        #region NumTilesX
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.numTilesX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationNumTilesX(this ParticleSystem particleSystem, int numTilesX)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.numTilesX = numTilesX;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.numTilesX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationNumTilesX(this ParticleSystem particleSystem, Func<int, int> numTilesXChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(numTilesXChanger != null, "numTilesXChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.numTilesX = numTilesXChanger(module.numTilesX);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.numTilesX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetNumTilesX(this TextureSheetAnimationModule module, int numTilesX)
        {
            module.numTilesX = numTilesX;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.numTilesX"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetNumTilesX(this TextureSheetAnimationModule module, Func<int, int> numTilesXChanger)
        {
            Debug.Assert(numTilesXChanger != null, "numTilesXChanger cannot be null");
            module.numTilesX = numTilesXChanger(module.numTilesX);
            return module;
        }
        #endregion

        #region NumTilesY
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.numTilesY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationNumTilesY(this ParticleSystem particleSystem, int numTilesY)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.numTilesY = numTilesY;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.numTilesY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationNumTilesY(this ParticleSystem particleSystem, Func<int, int> numTilesYChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(numTilesYChanger != null, "numTilesYChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.numTilesY = numTilesYChanger(module.numTilesY);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.numTilesY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetNumTilesY(this TextureSheetAnimationModule module, int numTilesY)
        {
            module.numTilesY = numTilesY;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.numTilesY"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetNumTilesY(this TextureSheetAnimationModule module, Func<int, int> numTilesYChanger)
        {
            Debug.Assert(numTilesYChanger != null, "numTilesYChanger cannot be null");
            module.numTilesY = numTilesYChanger(module.numTilesY);
            return module;
        }
        #endregion

        #region RowIndex
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.rowIndex"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationRowIndex(this ParticleSystem particleSystem, int rowIndex)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.rowIndex = rowIndex;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.rowIndex"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationRowIndex(this ParticleSystem particleSystem, Func<int, int> rowIndexChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rowIndexChanger != null, "rowIndexChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.rowIndex = rowIndexChanger(module.rowIndex);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.rowIndex"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetRowIndex(this TextureSheetAnimationModule module, int rowIndex)
        {
            module.rowIndex = rowIndex;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.rowIndex"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetRowIndex(this TextureSheetAnimationModule module, Func<int, int> rowIndexChanger)
        {
            Debug.Assert(rowIndexChanger != null, "rowIndexChanger cannot be null");
            module.rowIndex = rowIndexChanger(module.rowIndex);
            return module;
        }
        #endregion
#endif

#if UNITY_2019_4_OR_NEWER
        #region RowMode
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.rowMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationRowMode(this ParticleSystem particleSystem, ParticleSystemAnimationRowMode rowMode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.rowMode = rowMode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.rowMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationRowMode(this ParticleSystem particleSystem, Func<ParticleSystemAnimationRowMode, ParticleSystemAnimationRowMode> rowModeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rowModeChanger != null, "rowModeChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.rowMode = rowModeChanger(module.rowMode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.rowMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetRowMode(this TextureSheetAnimationModule module, ParticleSystemAnimationRowMode rowMode)
        {
            module.rowMode = rowMode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.rowMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetRowMode(this TextureSheetAnimationModule module, Func<ParticleSystemAnimationRowMode, ParticleSystemAnimationRowMode> rowModeChanger)
        {
            Debug.Assert(rowModeChanger != null, "rowModeChanger cannot be null");
            module.rowMode = rowModeChanger(module.rowMode);
            return module;
        }
        #endregion
#endif

#if UNITY_2018_4_OR_NEWER
        #region SpeedRange
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.speedRange"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationSpeedRange(this ParticleSystem particleSystem, Vector2 speedRange)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.speedRange = speedRange;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.speedRange"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationSpeedRange(this ParticleSystem particleSystem, Func<Vector2, Vector2> speedRangeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(speedRangeChanger != null, "speedRangeChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.speedRange = speedRangeChanger(module.speedRange);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.speedRange"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetSpeedRange(this TextureSheetAnimationModule module, Vector2 speedRange)
        {
            module.speedRange = speedRange;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.speedRange"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetSpeedRange(this TextureSheetAnimationModule module, Func<Vector2, Vector2> speedRangeChanger)
        {
            Debug.Assert(speedRangeChanger != null, "speedRangeChanger cannot be null");
            module.speedRange = speedRangeChanger(module.speedRange);
            return module;
        }
        #endregion

        #region StartFrame
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.startFrame"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationStartFrame(this ParticleSystem particleSystem, MinMaxCurve startFrame)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.startFrame = startFrame;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.startFrame"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationStartFrame(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startFrameChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startFrameChanger != null, "startFrameChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.startFrame = startFrameChanger(module.startFrame);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.startFrame"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetStartFrame(this TextureSheetAnimationModule module, MinMaxCurve startFrame)
        {
            module.startFrame = startFrame;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.startFrame"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetStartFrame(this TextureSheetAnimationModule module, Func<MinMaxCurve, MinMaxCurve> startFrameChanger)
        {
            Debug.Assert(startFrameChanger != null, "startFrameChanger cannot be null");
            module.startFrame = startFrameChanger(module.startFrame);
            return module;
        }
        #endregion

        #region StartFrameMultiplier
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.startFrameMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationStartFrameMultiplier(this ParticleSystem particleSystem, float startFrameMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.startFrameMultiplier = startFrameMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.startFrameMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationStartFrameMultiplier(this ParticleSystem particleSystem, Func<float, float> startFrameMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(startFrameMultiplierChanger != null, "startFrameMultiplierChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.startFrameMultiplier = startFrameMultiplierChanger(module.startFrameMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.startFrameMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetStartFrameMultiplier(this TextureSheetAnimationModule module, float startFrameMultiplier)
        {
            module.startFrameMultiplier = startFrameMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.startFrameMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetStartFrameMultiplier(this TextureSheetAnimationModule module, Func<float, float> startFrameMultiplierChanger)
        {
            Debug.Assert(startFrameMultiplierChanger != null, "startFrameMultiplierChanger cannot be null");
            module.startFrameMultiplier = startFrameMultiplierChanger(module.startFrameMultiplier);
            return module;
        }
        #endregion

        #region TimeMode
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.timeMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationTimeMode(this ParticleSystem particleSystem, ParticleSystemAnimationTimeMode timeMode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.timeMode = timeMode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.timeMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationTimeMode(this ParticleSystem particleSystem, Func<ParticleSystemAnimationTimeMode, ParticleSystemAnimationTimeMode> timeModeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(timeModeChanger != null, "timeModeChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.timeMode = timeModeChanger(module.timeMode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.timeMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetTimeMode(this TextureSheetAnimationModule module, ParticleSystemAnimationTimeMode timeMode)
        {
            module.timeMode = timeMode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.timeMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetTimeMode(this TextureSheetAnimationModule module, Func<ParticleSystemAnimationTimeMode, ParticleSystemAnimationTimeMode> timeModeChanger)
        {
            Debug.Assert(timeModeChanger != null, "timeModeChanger cannot be null");
            module.timeMode = timeModeChanger(module.timeMode);
            return module;
        }
        #endregion

        #region UseRandomRow
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.useRandomRow"/>
        /// </summary>
#if UNITY_2019_4_OR_NEWER
        [Obsolete("useRandomRow property is deprecated. Use rowMode instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationUseRandomRow(this ParticleSystem particleSystem, bool useRandomRow)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.useRandomRow = useRandomRow;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.useRandomRow"/>
        /// </summary>
#if UNITY_2019_4_OR_NEWER
        [Obsolete("useRandomRow property is deprecated. Use rowMode instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationUseRandomRow(this ParticleSystem particleSystem, Func<bool, bool> useRandomRowChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(useRandomRowChanger != null, "useRandomRowChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.useRandomRow = useRandomRowChanger(module.useRandomRow);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.useRandomRow"/>
        /// </summary>
#if UNITY_2019_4_OR_NEWER
        [Obsolete("useRandomRow property is deprecated. Use rowMode instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetUseRandomRow(this TextureSheetAnimationModule module, bool useRandomRow)
        {
            module.useRandomRow = useRandomRow;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.useRandomRow"/>
        /// </summary>
#if UNITY_2019_4_OR_NEWER
        [Obsolete("useRandomRow property is deprecated. Use rowMode instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetUseRandomRow(this TextureSheetAnimationModule module, Func<bool, bool> useRandomRowChanger)
        {
            Debug.Assert(useRandomRowChanger != null, "useRandomRowChanger cannot be null");
            module.useRandomRow = useRandomRowChanger(module.useRandomRow);
            return module;
        }
        #endregion

        #region UvChannelMask
        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.uvChannelMask"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationUvChannelMask(this ParticleSystem particleSystem, UnityEngine.Rendering.UVChannelFlags uvChannelMask)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.uvChannelMask = uvChannelMask;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.uvChannelMask"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationUvChannelMask(this ParticleSystem particleSystem, Func<UnityEngine.Rendering.UVChannelFlags, UnityEngine.Rendering.UVChannelFlags> uvChannelMaskChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(uvChannelMaskChanger != null, "uvChannelMaskChanger cannot be null");
            var module = particleSystem.textureSheetAnimation;
            module.uvChannelMask = uvChannelMaskChanger(module.uvChannelMask);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="TextureSheetAnimationModule.uvChannelMask"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetUvChannelMask(this TextureSheetAnimationModule module, UnityEngine.Rendering.UVChannelFlags uvChannelMask)
        {
            module.uvChannelMask = uvChannelMask;
            return module;
        }

        /// <summary>
        /// Edit <see cref="TextureSheetAnimationModule.uvChannelMask"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetUvChannelMask(this TextureSheetAnimationModule module, Func<UnityEngine.Rendering.UVChannelFlags, UnityEngine.Rendering.UVChannelFlags> uvChannelMaskChanger)
        {
            Debug.Assert(uvChannelMaskChanger != null, "uvChannelMaskChanger cannot be null");
            module.uvChannelMask = uvChannelMaskChanger(module.uvChannelMask);
            return module;
        }
        #endregion
#endif
    }
}
