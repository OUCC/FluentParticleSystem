using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class TextureSheetAnimationModuleExtension
    {
#if UNITY_2021_3_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditTextureSheetAnimation(this ParticleSystem particleSystem, Action<TextureSheetAnimationModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.textureSheetAnimation);
            return particleSystem;
        }

        #region FlipU
#if UNITY_2021_3_OR_NEWER
        [Obsolete("flipU property is deprecated. Use ParticleSystemRenderer.flip.x instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFlipU(this ParticleSystem particleSystem, float flipU)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.flipU = flipU;
            return particleSystem;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("flipU property is deprecated. Use ParticleSystemRenderer.flip.x instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFlipU(this ParticleSystem particleSystem, Func<float, float> flipUChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.flipU = flipUChanger(module.flipU);
            return particleSystem;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("flipU property is deprecated. Use ParticleSystemRenderer.flip.x instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFlipU(this TextureSheetAnimationModule module, float flipU)
        {
            module.flipU = flipU;
            return module;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("flipU property is deprecated. Use ParticleSystemRenderer.flip.x instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFlipU(this TextureSheetAnimationModule module, Func<float, float> flipUChanger)
        {
            module.flipU = flipUChanger(module.flipU);
            return module;
        }
        #endregion

        #region FlipV
#if UNITY_2021_3_OR_NEWER
        [Obsolete("flipV property is deprecated. Use ParticleSystemRenderer.flip.y instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFlipV(this ParticleSystem particleSystem, float flipV)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.flipV = flipV;
            return particleSystem;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("flipV property is deprecated. Use ParticleSystemRenderer.flip.y instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFlipV(this ParticleSystem particleSystem, Func<float, float> flipVChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.flipV = flipVChanger(module.flipV);
            return particleSystem;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("flipV property is deprecated. Use ParticleSystemRenderer.flip.y instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFlipV(this TextureSheetAnimationModule module, float flipV)
        {
            module.flipV = flipV;
            return module;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("flipV property is deprecated. Use ParticleSystemRenderer.flip.y instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFlipV(this TextureSheetAnimationModule module, Func<float, float> flipVChanger)
        {
            module.flipV = flipVChanger(module.flipV);
            return module;
        }
        #endregion

        #region UseRandomRow
#if UNITY_2021_3_OR_NEWER
        [Obsolete("useRandomRow property is deprecated. Use rowMode instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationUseRandomRow(this ParticleSystem particleSystem, bool useRandomRow)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.useRandomRow = useRandomRow;
            return particleSystem;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("useRandomRow property is deprecated. Use rowMode instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationUseRandomRow(this ParticleSystem particleSystem, Func<bool, bool> useRandomRowChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.useRandomRow = useRandomRowChanger(module.useRandomRow);
            return particleSystem;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("useRandomRow property is deprecated. Use rowMode instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetUseRandomRow(this TextureSheetAnimationModule module, bool useRandomRow)
        {
            module.useRandomRow = useRandomRow;
            return module;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("useRandomRow property is deprecated. Use rowMode instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetUseRandomRow(this TextureSheetAnimationModule module, Func<bool, bool> useRandomRowChanger)
        {
            module.useRandomRow = useRandomRowChanger(module.useRandomRow);
            return module;
        }
        #endregion

        #region Enabled
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetEnabled(this TextureSheetAnimationModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetEnabled(this TextureSheetAnimationModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Mode
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationMode(this ParticleSystem particleSystem, ParticleSystemAnimationMode mode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.mode = mode;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationMode(this ParticleSystem particleSystem, Func<ParticleSystemAnimationMode, ParticleSystemAnimationMode> modeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.mode = modeChanger(module.mode);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetMode(this TextureSheetAnimationModule module, ParticleSystemAnimationMode mode)
        {
            module.mode = mode;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetMode(this TextureSheetAnimationModule module, Func<ParticleSystemAnimationMode, ParticleSystemAnimationMode> modeChanger)
        {
            module.mode = modeChanger(module.mode);
            return module;
        }
        #endregion

        #region TimeMode
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationTimeMode(this ParticleSystem particleSystem, ParticleSystemAnimationTimeMode timeMode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.timeMode = timeMode;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationTimeMode(this ParticleSystem particleSystem, Func<ParticleSystemAnimationTimeMode, ParticleSystemAnimationTimeMode> timeModeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.timeMode = timeModeChanger(module.timeMode);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetTimeMode(this TextureSheetAnimationModule module, ParticleSystemAnimationTimeMode timeMode)
        {
            module.timeMode = timeMode;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetTimeMode(this TextureSheetAnimationModule module, Func<ParticleSystemAnimationTimeMode, ParticleSystemAnimationTimeMode> timeModeChanger)
        {
            module.timeMode = timeModeChanger(module.timeMode);
            return module;
        }
        #endregion

        #region Fps
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFps(this ParticleSystem particleSystem, float fps)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.fps = fps;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFps(this ParticleSystem particleSystem, Func<float, float> fpsChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.fps = fpsChanger(module.fps);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFps(this TextureSheetAnimationModule module, float fps)
        {
            module.fps = fps;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFps(this TextureSheetAnimationModule module, Func<float, float> fpsChanger)
        {
            module.fps = fpsChanger(module.fps);
            return module;
        }
        #endregion

        #region NumTilesX
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationNumTilesX(this ParticleSystem particleSystem, int numTilesX)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.numTilesX = numTilesX;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationNumTilesX(this ParticleSystem particleSystem, Func<int, int> numTilesXChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.numTilesX = numTilesXChanger(module.numTilesX);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetNumTilesX(this TextureSheetAnimationModule module, int numTilesX)
        {
            module.numTilesX = numTilesX;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetNumTilesX(this TextureSheetAnimationModule module, Func<int, int> numTilesXChanger)
        {
            module.numTilesX = numTilesXChanger(module.numTilesX);
            return module;
        }
        #endregion

        #region NumTilesY
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationNumTilesY(this ParticleSystem particleSystem, int numTilesY)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.numTilesY = numTilesY;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationNumTilesY(this ParticleSystem particleSystem, Func<int, int> numTilesYChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.numTilesY = numTilesYChanger(module.numTilesY);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetNumTilesY(this TextureSheetAnimationModule module, int numTilesY)
        {
            module.numTilesY = numTilesY;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetNumTilesY(this TextureSheetAnimationModule module, Func<int, int> numTilesYChanger)
        {
            module.numTilesY = numTilesYChanger(module.numTilesY);
            return module;
        }
        #endregion

        #region Animation
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationAnimation(this ParticleSystem particleSystem, ParticleSystemAnimationType animation)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.animation = animation;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationAnimation(this ParticleSystem particleSystem, Func<ParticleSystemAnimationType, ParticleSystemAnimationType> animationChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.animation = animationChanger(module.animation);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetAnimation(this TextureSheetAnimationModule module, ParticleSystemAnimationType animation)
        {
            module.animation = animation;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetAnimation(this TextureSheetAnimationModule module, Func<ParticleSystemAnimationType, ParticleSystemAnimationType> animationChanger)
        {
            module.animation = animationChanger(module.animation);
            return module;
        }
        #endregion

        #region RowMode
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationRowMode(this ParticleSystem particleSystem, ParticleSystemAnimationRowMode rowMode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.rowMode = rowMode;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationRowMode(this ParticleSystem particleSystem, Func<ParticleSystemAnimationRowMode, ParticleSystemAnimationRowMode> rowModeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.rowMode = rowModeChanger(module.rowMode);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetRowMode(this TextureSheetAnimationModule module, ParticleSystemAnimationRowMode rowMode)
        {
            module.rowMode = rowMode;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetRowMode(this TextureSheetAnimationModule module, Func<ParticleSystemAnimationRowMode, ParticleSystemAnimationRowMode> rowModeChanger)
        {
            module.rowMode = rowModeChanger(module.rowMode);
            return module;
        }
        #endregion

        #region FrameOverTime
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFrameOverTime(this ParticleSystem particleSystem, MinMaxCurve frameOverTime)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.frameOverTime = frameOverTime;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFrameOverTime(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> frameOverTimeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.frameOverTime = frameOverTimeChanger(module.frameOverTime);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFrameOverTime(this TextureSheetAnimationModule module, MinMaxCurve frameOverTime)
        {
            module.frameOverTime = frameOverTime;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFrameOverTime(this TextureSheetAnimationModule module, Func<MinMaxCurve, MinMaxCurve> frameOverTimeChanger)
        {
            module.frameOverTime = frameOverTimeChanger(module.frameOverTime);
            return module;
        }
        #endregion

        #region FrameOverTimeMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFrameOverTimeMultiplier(this ParticleSystem particleSystem, float frameOverTimeMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.frameOverTimeMultiplier = frameOverTimeMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationFrameOverTimeMultiplier(this ParticleSystem particleSystem, Func<float, float> frameOverTimeMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.frameOverTimeMultiplier = frameOverTimeMultiplierChanger(module.frameOverTimeMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFrameOverTimeMultiplier(this TextureSheetAnimationModule module, float frameOverTimeMultiplier)
        {
            module.frameOverTimeMultiplier = frameOverTimeMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetFrameOverTimeMultiplier(this TextureSheetAnimationModule module, Func<float, float> frameOverTimeMultiplierChanger)
        {
            module.frameOverTimeMultiplier = frameOverTimeMultiplierChanger(module.frameOverTimeMultiplier);
            return module;
        }
        #endregion

        #region StartFrame
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationStartFrame(this ParticleSystem particleSystem, MinMaxCurve startFrame)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.startFrame = startFrame;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationStartFrame(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> startFrameChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.startFrame = startFrameChanger(module.startFrame);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetStartFrame(this TextureSheetAnimationModule module, MinMaxCurve startFrame)
        {
            module.startFrame = startFrame;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetStartFrame(this TextureSheetAnimationModule module, Func<MinMaxCurve, MinMaxCurve> startFrameChanger)
        {
            module.startFrame = startFrameChanger(module.startFrame);
            return module;
        }
        #endregion

        #region StartFrameMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationStartFrameMultiplier(this ParticleSystem particleSystem, float startFrameMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.startFrameMultiplier = startFrameMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationStartFrameMultiplier(this ParticleSystem particleSystem, Func<float, float> startFrameMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.startFrameMultiplier = startFrameMultiplierChanger(module.startFrameMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetStartFrameMultiplier(this TextureSheetAnimationModule module, float startFrameMultiplier)
        {
            module.startFrameMultiplier = startFrameMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetStartFrameMultiplier(this TextureSheetAnimationModule module, Func<float, float> startFrameMultiplierChanger)
        {
            module.startFrameMultiplier = startFrameMultiplierChanger(module.startFrameMultiplier);
            return module;
        }
        #endregion

        #region CycleCount
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationCycleCount(this ParticleSystem particleSystem, int cycleCount)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.cycleCount = cycleCount;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationCycleCount(this ParticleSystem particleSystem, Func<int, int> cycleCountChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.cycleCount = cycleCountChanger(module.cycleCount);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetCycleCount(this TextureSheetAnimationModule module, int cycleCount)
        {
            module.cycleCount = cycleCount;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetCycleCount(this TextureSheetAnimationModule module, Func<int, int> cycleCountChanger)
        {
            module.cycleCount = cycleCountChanger(module.cycleCount);
            return module;
        }
        #endregion

        #region RowIndex
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationRowIndex(this ParticleSystem particleSystem, int rowIndex)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.rowIndex = rowIndex;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationRowIndex(this ParticleSystem particleSystem, Func<int, int> rowIndexChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.rowIndex = rowIndexChanger(module.rowIndex);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetRowIndex(this TextureSheetAnimationModule module, int rowIndex)
        {
            module.rowIndex = rowIndex;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetRowIndex(this TextureSheetAnimationModule module, Func<int, int> rowIndexChanger)
        {
            module.rowIndex = rowIndexChanger(module.rowIndex);
            return module;
        }
        #endregion

        #region UvChannelMask
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationUvChannelMask(this ParticleSystem particleSystem, UnityEngine.Rendering.UVChannelFlags uvChannelMask)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.uvChannelMask = uvChannelMask;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationUvChannelMask(this ParticleSystem particleSystem, Func<UnityEngine.Rendering.UVChannelFlags, UnityEngine.Rendering.UVChannelFlags> uvChannelMaskChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.uvChannelMask = uvChannelMaskChanger(module.uvChannelMask);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetUvChannelMask(this TextureSheetAnimationModule module, UnityEngine.Rendering.UVChannelFlags uvChannelMask)
        {
            module.uvChannelMask = uvChannelMask;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetUvChannelMask(this TextureSheetAnimationModule module, Func<UnityEngine.Rendering.UVChannelFlags, UnityEngine.Rendering.UVChannelFlags> uvChannelMaskChanger)
        {
            module.uvChannelMask = uvChannelMaskChanger(module.uvChannelMask);
            return module;
        }
        #endregion

        #region SpeedRange
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationSpeedRange(this ParticleSystem particleSystem, Vector2 speedRange)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.speedRange = speedRange;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetTextureSheetAnimationSpeedRange(this ParticleSystem particleSystem, Func<Vector2, Vector2> speedRangeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.textureSheetAnimation;
            module.speedRange = speedRangeChanger(module.speedRange);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetSpeedRange(this TextureSheetAnimationModule module, Vector2 speedRange)
        {
            module.speedRange = speedRange;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TextureSheetAnimationModule SetSpeedRange(this TextureSheetAnimationModule module, Func<Vector2, Vector2> speedRangeChanger)
        {
            module.speedRange = speedRangeChanger(module.speedRange);
            return module;
        }
        #endregion
#endif
    }
}
