using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class ShapeModuleExtension
    {
#if UNITY_2021_3_OR_NEWER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditShape(this ParticleSystem particleSystem, Action<ShapeModule> moduleEditor)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            moduleEditor(particleSystem.shape);
            return particleSystem;
        }

        #region AlignToDirection
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeAlignToDirection(this ParticleSystem particleSystem, bool alignToDirection)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.alignToDirection = alignToDirection;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeAlignToDirection(this ParticleSystem particleSystem, Func<bool, bool> alignToDirectionChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.alignToDirection = alignToDirectionChanger(module.alignToDirection);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetAlignToDirection(this ShapeModule module, bool alignToDirection)
        {
            module.alignToDirection = alignToDirection;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetAlignToDirection(this ShapeModule module, Func<bool, bool> alignToDirectionChanger)
        {
            module.alignToDirection = alignToDirectionChanger(module.alignToDirection);
            return module;
        }
        #endregion

        #region Angle
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeAngle(this ParticleSystem particleSystem, float angle)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.angle = angle;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeAngle(this ParticleSystem particleSystem, Func<float, float> angleChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.angle = angleChanger(module.angle);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetAngle(this ShapeModule module, float angle)
        {
            module.angle = angle;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetAngle(this ShapeModule module, Func<float, float> angleChanger)
        {
            module.angle = angleChanger(module.angle);
            return module;
        }
        #endregion

        #region Arc
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArc(this ParticleSystem particleSystem, float arc)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.arc = arc;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArc(this ParticleSystem particleSystem, Func<float, float> arcChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.arc = arcChanger(module.arc);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArc(this ShapeModule module, float arc)
        {
            module.arc = arc;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArc(this ShapeModule module, Func<float, float> arcChanger)
        {
            module.arc = arcChanger(module.arc);
            return module;
        }
        #endregion

        #region ArcMode
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcMode(this ParticleSystem particleSystem, ParticleSystemShapeMultiModeValue arcMode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.arcMode = arcMode;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcMode(this ParticleSystem particleSystem, Func<ParticleSystemShapeMultiModeValue, ParticleSystemShapeMultiModeValue> arcModeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.arcMode = arcModeChanger(module.arcMode);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcMode(this ShapeModule module, ParticleSystemShapeMultiModeValue arcMode)
        {
            module.arcMode = arcMode;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcMode(this ShapeModule module, Func<ParticleSystemShapeMultiModeValue, ParticleSystemShapeMultiModeValue> arcModeChanger)
        {
            module.arcMode = arcModeChanger(module.arcMode);
            return module;
        }
        #endregion

        #region ArcSpeed
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcSpeed(this ParticleSystem particleSystem, MinMaxCurve arcSpeed)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.arcSpeed = arcSpeed;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcSpeed(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> arcSpeedChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.arcSpeed = arcSpeedChanger(module.arcSpeed);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcSpeed(this ShapeModule module, MinMaxCurve arcSpeed)
        {
            module.arcSpeed = arcSpeed;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcSpeed(this ShapeModule module, Func<MinMaxCurve, MinMaxCurve> arcSpeedChanger)
        {
            module.arcSpeed = arcSpeedChanger(module.arcSpeed);
            return module;
        }
        #endregion

        #region ArcSpeedMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcSpeedMultiplier(this ParticleSystem particleSystem, float arcSpeedMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.arcSpeedMultiplier = arcSpeedMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcSpeedMultiplier(this ParticleSystem particleSystem, Func<float, float> arcSpeedMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.arcSpeedMultiplier = arcSpeedMultiplierChanger(module.arcSpeedMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcSpeedMultiplier(this ShapeModule module, float arcSpeedMultiplier)
        {
            module.arcSpeedMultiplier = arcSpeedMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcSpeedMultiplier(this ShapeModule module, Func<float, float> arcSpeedMultiplierChanger)
        {
            module.arcSpeedMultiplier = arcSpeedMultiplierChanger(module.arcSpeedMultiplier);
            return module;
        }
        #endregion

        #region ArcSpread
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcSpread(this ParticleSystem particleSystem, float arcSpread)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.arcSpread = arcSpread;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcSpread(this ParticleSystem particleSystem, Func<float, float> arcSpreadChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.arcSpread = arcSpreadChanger(module.arcSpread);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcSpread(this ShapeModule module, float arcSpread)
        {
            module.arcSpread = arcSpread;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcSpread(this ShapeModule module, Func<float, float> arcSpreadChanger)
        {
            module.arcSpread = arcSpreadChanger(module.arcSpread);
            return module;
        }
        #endregion

        #region Box
#if UNITY_2021_3_OR_NEWER
        [Obsolete("Please use scale instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/ShapeModule.scale", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeBox(this ParticleSystem particleSystem, Vector3 box)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.box = box;
            return particleSystem;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("Please use scale instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/ShapeModule.scale", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeBox(this ParticleSystem particleSystem, Func<Vector3, Vector3> boxChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.box = boxChanger(module.box);
            return particleSystem;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("Please use scale instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/ShapeModule.scale", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetBox(this ShapeModule module, Vector3 box)
        {
            module.box = box;
            return module;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("Please use scale instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/ShapeModule.scale", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetBox(this ShapeModule module, Func<Vector3, Vector3> boxChanger)
        {
            module.box = boxChanger(module.box);
            return module;
        }
        #endregion

        #region BoxThickness
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeBoxThickness(this ParticleSystem particleSystem, Vector3 boxThickness)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.boxThickness = boxThickness;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeBoxThickness(this ParticleSystem particleSystem, Func<Vector3, Vector3> boxThicknessChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.boxThickness = boxThicknessChanger(module.boxThickness);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetBoxThickness(this ShapeModule module, Vector3 boxThickness)
        {
            module.boxThickness = boxThickness;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetBoxThickness(this ShapeModule module, Func<Vector3, Vector3> boxThicknessChanger)
        {
            module.boxThickness = boxThicknessChanger(module.boxThickness);
            return module;
        }
        #endregion

        #region DonutRadius
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeDonutRadius(this ParticleSystem particleSystem, float donutRadius)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.donutRadius = donutRadius;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeDonutRadius(this ParticleSystem particleSystem, Func<float, float> donutRadiusChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.donutRadius = donutRadiusChanger(module.donutRadius);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetDonutRadius(this ShapeModule module, float donutRadius)
        {
            module.donutRadius = donutRadius;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetDonutRadius(this ShapeModule module, Func<float, float> donutRadiusChanger)
        {
            module.donutRadius = donutRadiusChanger(module.donutRadius);
            return module;
        }
        #endregion

        #region Enabled
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.enabled = enabled;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetEnabled(this ShapeModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetEnabled(this ShapeModule module, Func<bool, bool> enabledChanger)
        {
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Length
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeLength(this ParticleSystem particleSystem, float length)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.length = length;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeLength(this ParticleSystem particleSystem, Func<float, float> lengthChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.length = lengthChanger(module.length);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetLength(this ShapeModule module, float length)
        {
            module.length = length;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetLength(this ShapeModule module, Func<float, float> lengthChanger)
        {
            module.length = lengthChanger(module.length);
            return module;
        }
        #endregion

        #region Mesh
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMesh(this ParticleSystem particleSystem, Mesh mesh)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.mesh = mesh;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMesh(this ParticleSystem particleSystem, Func<Mesh, Mesh> meshChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.mesh = meshChanger(module.mesh);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMesh(this ShapeModule module, Mesh mesh)
        {
            module.mesh = mesh;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMesh(this ShapeModule module, Func<Mesh, Mesh> meshChanger)
        {
            module.mesh = meshChanger(module.mesh);
            return module;
        }
        #endregion

        #region MeshMaterialIndex
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshMaterialIndex(this ParticleSystem particleSystem, int meshMaterialIndex)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshMaterialIndex = meshMaterialIndex;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshMaterialIndex(this ParticleSystem particleSystem, Func<int, int> meshMaterialIndexChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshMaterialIndex = meshMaterialIndexChanger(module.meshMaterialIndex);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshMaterialIndex(this ShapeModule module, int meshMaterialIndex)
        {
            module.meshMaterialIndex = meshMaterialIndex;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshMaterialIndex(this ShapeModule module, Func<int, int> meshMaterialIndexChanger)
        {
            module.meshMaterialIndex = meshMaterialIndexChanger(module.meshMaterialIndex);
            return module;
        }
        #endregion

        #region MeshRenderer
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshRenderer(this ParticleSystem particleSystem, MeshRenderer meshRenderer)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshRenderer = meshRenderer;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshRenderer(this ParticleSystem particleSystem, Func<MeshRenderer, MeshRenderer> meshRendererChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshRenderer = meshRendererChanger(module.meshRenderer);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshRenderer(this ShapeModule module, MeshRenderer meshRenderer)
        {
            module.meshRenderer = meshRenderer;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshRenderer(this ShapeModule module, Func<MeshRenderer, MeshRenderer> meshRendererChanger)
        {
            module.meshRenderer = meshRendererChanger(module.meshRenderer);
            return module;
        }
        #endregion

        #region MeshScale
#if UNITY_2021_3_OR_NEWER
        [Obsolete("meshScale property is deprecated.Please use scale instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshScale(this ParticleSystem particleSystem, float meshScale)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshScale = meshScale;
            return particleSystem;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("meshScale property is deprecated.Please use scale instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshScale(this ParticleSystem particleSystem, Func<float, float> meshScaleChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshScale = meshScaleChanger(module.meshScale);
            return particleSystem;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("meshScale property is deprecated.Please use scale instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshScale(this ShapeModule module, float meshScale)
        {
            module.meshScale = meshScale;
            return module;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("meshScale property is deprecated.Please use scale instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshScale(this ShapeModule module, Func<float, float> meshScaleChanger)
        {
            module.meshScale = meshScaleChanger(module.meshScale);
            return module;
        }
        #endregion

        #region MeshShapeType
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshShapeType(this ParticleSystem particleSystem, ParticleSystemMeshShapeType meshShapeType)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshShapeType = meshShapeType;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshShapeType(this ParticleSystem particleSystem, Func<ParticleSystemMeshShapeType, ParticleSystemMeshShapeType> meshShapeTypeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshShapeType = meshShapeTypeChanger(module.meshShapeType);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshShapeType(this ShapeModule module, ParticleSystemMeshShapeType meshShapeType)
        {
            module.meshShapeType = meshShapeType;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshShapeType(this ShapeModule module, Func<ParticleSystemMeshShapeType, ParticleSystemMeshShapeType> meshShapeTypeChanger)
        {
            module.meshShapeType = meshShapeTypeChanger(module.meshShapeType);
            return module;
        }
        #endregion

        #region MeshSpawnMode
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnMode(this ParticleSystem particleSystem, ParticleSystemShapeMultiModeValue meshSpawnMode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshSpawnMode = meshSpawnMode;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnMode(this ParticleSystem particleSystem, Func<ParticleSystemShapeMultiModeValue, ParticleSystemShapeMultiModeValue> meshSpawnModeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshSpawnMode = meshSpawnModeChanger(module.meshSpawnMode);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnMode(this ShapeModule module, ParticleSystemShapeMultiModeValue meshSpawnMode)
        {
            module.meshSpawnMode = meshSpawnMode;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnMode(this ShapeModule module, Func<ParticleSystemShapeMultiModeValue, ParticleSystemShapeMultiModeValue> meshSpawnModeChanger)
        {
            module.meshSpawnMode = meshSpawnModeChanger(module.meshSpawnMode);
            return module;
        }
        #endregion

        #region MeshSpawnSpeed
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnSpeed(this ParticleSystem particleSystem, MinMaxCurve meshSpawnSpeed)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshSpawnSpeed = meshSpawnSpeed;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnSpeed(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> meshSpawnSpeedChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshSpawnSpeed = meshSpawnSpeedChanger(module.meshSpawnSpeed);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnSpeed(this ShapeModule module, MinMaxCurve meshSpawnSpeed)
        {
            module.meshSpawnSpeed = meshSpawnSpeed;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnSpeed(this ShapeModule module, Func<MinMaxCurve, MinMaxCurve> meshSpawnSpeedChanger)
        {
            module.meshSpawnSpeed = meshSpawnSpeedChanger(module.meshSpawnSpeed);
            return module;
        }
        #endregion

        #region MeshSpawnSpeedMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnSpeedMultiplier(this ParticleSystem particleSystem, float meshSpawnSpeedMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshSpawnSpeedMultiplier = meshSpawnSpeedMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnSpeedMultiplier(this ParticleSystem particleSystem, Func<float, float> meshSpawnSpeedMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshSpawnSpeedMultiplier = meshSpawnSpeedMultiplierChanger(module.meshSpawnSpeedMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnSpeedMultiplier(this ShapeModule module, float meshSpawnSpeedMultiplier)
        {
            module.meshSpawnSpeedMultiplier = meshSpawnSpeedMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnSpeedMultiplier(this ShapeModule module, Func<float, float> meshSpawnSpeedMultiplierChanger)
        {
            module.meshSpawnSpeedMultiplier = meshSpawnSpeedMultiplierChanger(module.meshSpawnSpeedMultiplier);
            return module;
        }
        #endregion

        #region MeshSpawnSpread
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnSpread(this ParticleSystem particleSystem, float meshSpawnSpread)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshSpawnSpread = meshSpawnSpread;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnSpread(this ParticleSystem particleSystem, Func<float, float> meshSpawnSpreadChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.meshSpawnSpread = meshSpawnSpreadChanger(module.meshSpawnSpread);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnSpread(this ShapeModule module, float meshSpawnSpread)
        {
            module.meshSpawnSpread = meshSpawnSpread;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnSpread(this ShapeModule module, Func<float, float> meshSpawnSpreadChanger)
        {
            module.meshSpawnSpread = meshSpawnSpreadChanger(module.meshSpawnSpread);
            return module;
        }
        #endregion

        #region NormalOffset
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeNormalOffset(this ParticleSystem particleSystem, float normalOffset)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.normalOffset = normalOffset;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeNormalOffset(this ParticleSystem particleSystem, Func<float, float> normalOffsetChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.normalOffset = normalOffsetChanger(module.normalOffset);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetNormalOffset(this ShapeModule module, float normalOffset)
        {
            module.normalOffset = normalOffset;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetNormalOffset(this ShapeModule module, Func<float, float> normalOffsetChanger)
        {
            module.normalOffset = normalOffsetChanger(module.normalOffset);
            return module;
        }
        #endregion

        #region Position
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapePosition(this ParticleSystem particleSystem, Vector3 position)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.position = position;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapePosition(this ParticleSystem particleSystem, Func<Vector3, Vector3> positionChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.position = positionChanger(module.position);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetPosition(this ShapeModule module, Vector3 position)
        {
            module.position = position;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetPosition(this ShapeModule module, Func<Vector3, Vector3> positionChanger)
        {
            module.position = positionChanger(module.position);
            return module;
        }
        #endregion

        #region Radius
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadius(this ParticleSystem particleSystem, float radius)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.radius = radius;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadius(this ParticleSystem particleSystem, Func<float, float> radiusChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.radius = radiusChanger(module.radius);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadius(this ShapeModule module, float radius)
        {
            module.radius = radius;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadius(this ShapeModule module, Func<float, float> radiusChanger)
        {
            module.radius = radiusChanger(module.radius);
            return module;
        }
        #endregion

        #region RadiusMode
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusMode(this ParticleSystem particleSystem, ParticleSystemShapeMultiModeValue radiusMode)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.radiusMode = radiusMode;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusMode(this ParticleSystem particleSystem, Func<ParticleSystemShapeMultiModeValue, ParticleSystemShapeMultiModeValue> radiusModeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.radiusMode = radiusModeChanger(module.radiusMode);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusMode(this ShapeModule module, ParticleSystemShapeMultiModeValue radiusMode)
        {
            module.radiusMode = radiusMode;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusMode(this ShapeModule module, Func<ParticleSystemShapeMultiModeValue, ParticleSystemShapeMultiModeValue> radiusModeChanger)
        {
            module.radiusMode = radiusModeChanger(module.radiusMode);
            return module;
        }
        #endregion

        #region RadiusSpeed
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusSpeed(this ParticleSystem particleSystem, MinMaxCurve radiusSpeed)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.radiusSpeed = radiusSpeed;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusSpeed(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> radiusSpeedChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.radiusSpeed = radiusSpeedChanger(module.radiusSpeed);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusSpeed(this ShapeModule module, MinMaxCurve radiusSpeed)
        {
            module.radiusSpeed = radiusSpeed;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusSpeed(this ShapeModule module, Func<MinMaxCurve, MinMaxCurve> radiusSpeedChanger)
        {
            module.radiusSpeed = radiusSpeedChanger(module.radiusSpeed);
            return module;
        }
        #endregion

        #region RadiusSpeedMultiplier
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusSpeedMultiplier(this ParticleSystem particleSystem, float radiusSpeedMultiplier)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.radiusSpeedMultiplier = radiusSpeedMultiplier;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusSpeedMultiplier(this ParticleSystem particleSystem, Func<float, float> radiusSpeedMultiplierChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.radiusSpeedMultiplier = radiusSpeedMultiplierChanger(module.radiusSpeedMultiplier);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusSpeedMultiplier(this ShapeModule module, float radiusSpeedMultiplier)
        {
            module.radiusSpeedMultiplier = radiusSpeedMultiplier;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusSpeedMultiplier(this ShapeModule module, Func<float, float> radiusSpeedMultiplierChanger)
        {
            module.radiusSpeedMultiplier = radiusSpeedMultiplierChanger(module.radiusSpeedMultiplier);
            return module;
        }
        #endregion

        #region RadiusSpread
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusSpread(this ParticleSystem particleSystem, float radiusSpread)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.radiusSpread = radiusSpread;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusSpread(this ParticleSystem particleSystem, Func<float, float> radiusSpreadChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.radiusSpread = radiusSpreadChanger(module.radiusSpread);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusSpread(this ShapeModule module, float radiusSpread)
        {
            module.radiusSpread = radiusSpread;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusSpread(this ShapeModule module, Func<float, float> radiusSpreadChanger)
        {
            module.radiusSpread = radiusSpreadChanger(module.radiusSpread);
            return module;
        }
        #endregion

        #region RadiusThickness
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusThickness(this ParticleSystem particleSystem, float radiusThickness)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.radiusThickness = radiusThickness;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusThickness(this ParticleSystem particleSystem, Func<float, float> radiusThicknessChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.radiusThickness = radiusThicknessChanger(module.radiusThickness);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusThickness(this ShapeModule module, float radiusThickness)
        {
            module.radiusThickness = radiusThickness;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusThickness(this ShapeModule module, Func<float, float> radiusThicknessChanger)
        {
            module.radiusThickness = radiusThicknessChanger(module.radiusThickness);
            return module;
        }
        #endregion

        #region RandomDirection
#if UNITY_2021_3_OR_NEWER
        [Obsolete("randomDirection property is deprecated. Use randomDirectionAmount instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRandomDirection(this ParticleSystem particleSystem, bool randomDirection)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.randomDirection = randomDirection;
            return particleSystem;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("randomDirection property is deprecated. Use randomDirectionAmount instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRandomDirection(this ParticleSystem particleSystem, Func<bool, bool> randomDirectionChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.randomDirection = randomDirectionChanger(module.randomDirection);
            return particleSystem;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("randomDirection property is deprecated. Use randomDirectionAmount instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRandomDirection(this ShapeModule module, bool randomDirection)
        {
            module.randomDirection = randomDirection;
            return module;
        }

#if UNITY_2021_3_OR_NEWER
        [Obsolete("randomDirection property is deprecated. Use randomDirectionAmount instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRandomDirection(this ShapeModule module, Func<bool, bool> randomDirectionChanger)
        {
            module.randomDirection = randomDirectionChanger(module.randomDirection);
            return module;
        }
        #endregion

        #region RandomDirectionAmount
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRandomDirectionAmount(this ParticleSystem particleSystem, float randomDirectionAmount)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.randomDirectionAmount = randomDirectionAmount;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRandomDirectionAmount(this ParticleSystem particleSystem, Func<float, float> randomDirectionAmountChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.randomDirectionAmount = randomDirectionAmountChanger(module.randomDirectionAmount);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRandomDirectionAmount(this ShapeModule module, float randomDirectionAmount)
        {
            module.randomDirectionAmount = randomDirectionAmount;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRandomDirectionAmount(this ShapeModule module, Func<float, float> randomDirectionAmountChanger)
        {
            module.randomDirectionAmount = randomDirectionAmountChanger(module.randomDirectionAmount);
            return module;
        }
        #endregion

        #region RandomPositionAmount
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRandomPositionAmount(this ParticleSystem particleSystem, float randomPositionAmount)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.randomPositionAmount = randomPositionAmount;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRandomPositionAmount(this ParticleSystem particleSystem, Func<float, float> randomPositionAmountChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.randomPositionAmount = randomPositionAmountChanger(module.randomPositionAmount);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRandomPositionAmount(this ShapeModule module, float randomPositionAmount)
        {
            module.randomPositionAmount = randomPositionAmount;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRandomPositionAmount(this ShapeModule module, Func<float, float> randomPositionAmountChanger)
        {
            module.randomPositionAmount = randomPositionAmountChanger(module.randomPositionAmount);
            return module;
        }
        #endregion

        #region Rotation
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRotation(this ParticleSystem particleSystem, Vector3 rotation)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.rotation = rotation;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRotation(this ParticleSystem particleSystem, Func<Vector3, Vector3> rotationChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.rotation = rotationChanger(module.rotation);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRotation(this ShapeModule module, Vector3 rotation)
        {
            module.rotation = rotation;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRotation(this ShapeModule module, Func<Vector3, Vector3> rotationChanger)
        {
            module.rotation = rotationChanger(module.rotation);
            return module;
        }
        #endregion

        #region Scale
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeScale(this ParticleSystem particleSystem, Vector3 scale)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.scale = scale;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeScale(this ParticleSystem particleSystem, Func<Vector3, Vector3> scaleChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.scale = scaleChanger(module.scale);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetScale(this ShapeModule module, Vector3 scale)
        {
            module.scale = scale;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetScale(this ShapeModule module, Func<Vector3, Vector3> scaleChanger)
        {
            module.scale = scaleChanger(module.scale);
            return module;
        }
        #endregion

        #region ShapeType
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeShapeType(this ParticleSystem particleSystem, ParticleSystemShapeType shapeType)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.shapeType = shapeType;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeShapeType(this ParticleSystem particleSystem, Func<ParticleSystemShapeType, ParticleSystemShapeType> shapeTypeChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.shapeType = shapeTypeChanger(module.shapeType);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetShapeType(this ShapeModule module, ParticleSystemShapeType shapeType)
        {
            module.shapeType = shapeType;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetShapeType(this ShapeModule module, Func<ParticleSystemShapeType, ParticleSystemShapeType> shapeTypeChanger)
        {
            module.shapeType = shapeTypeChanger(module.shapeType);
            return module;
        }
        #endregion

        #region SkinnedMeshRenderer
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSkinnedMeshRenderer(this ParticleSystem particleSystem, SkinnedMeshRenderer skinnedMeshRenderer)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.skinnedMeshRenderer = skinnedMeshRenderer;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSkinnedMeshRenderer(this ParticleSystem particleSystem, Func<SkinnedMeshRenderer, SkinnedMeshRenderer> skinnedMeshRendererChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.skinnedMeshRenderer = skinnedMeshRendererChanger(module.skinnedMeshRenderer);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSkinnedMeshRenderer(this ShapeModule module, SkinnedMeshRenderer skinnedMeshRenderer)
        {
            module.skinnedMeshRenderer = skinnedMeshRenderer;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSkinnedMeshRenderer(this ShapeModule module, Func<SkinnedMeshRenderer, SkinnedMeshRenderer> skinnedMeshRendererChanger)
        {
            module.skinnedMeshRenderer = skinnedMeshRendererChanger(module.skinnedMeshRenderer);
            return module;
        }
        #endregion

        #region SphericalDirectionAmount
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSphericalDirectionAmount(this ParticleSystem particleSystem, float sphericalDirectionAmount)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.sphericalDirectionAmount = sphericalDirectionAmount;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSphericalDirectionAmount(this ParticleSystem particleSystem, Func<float, float> sphericalDirectionAmountChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.sphericalDirectionAmount = sphericalDirectionAmountChanger(module.sphericalDirectionAmount);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSphericalDirectionAmount(this ShapeModule module, float sphericalDirectionAmount)
        {
            module.sphericalDirectionAmount = sphericalDirectionAmount;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSphericalDirectionAmount(this ShapeModule module, Func<float, float> sphericalDirectionAmountChanger)
        {
            module.sphericalDirectionAmount = sphericalDirectionAmountChanger(module.sphericalDirectionAmount);
            return module;
        }
        #endregion

        #region Sprite
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSprite(this ParticleSystem particleSystem, Sprite sprite)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.sprite = sprite;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSprite(this ParticleSystem particleSystem, Func<Sprite, Sprite> spriteChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.sprite = spriteChanger(module.sprite);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSprite(this ShapeModule module, Sprite sprite)
        {
            module.sprite = sprite;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSprite(this ShapeModule module, Func<Sprite, Sprite> spriteChanger)
        {
            module.sprite = spriteChanger(module.sprite);
            return module;
        }
        #endregion

        #region SpriteRenderer
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSpriteRenderer(this ParticleSystem particleSystem, SpriteRenderer spriteRenderer)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.spriteRenderer = spriteRenderer;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSpriteRenderer(this ParticleSystem particleSystem, Func<SpriteRenderer, SpriteRenderer> spriteRendererChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.spriteRenderer = spriteRendererChanger(module.spriteRenderer);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSpriteRenderer(this ShapeModule module, SpriteRenderer spriteRenderer)
        {
            module.spriteRenderer = spriteRenderer;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSpriteRenderer(this ShapeModule module, Func<SpriteRenderer, SpriteRenderer> spriteRendererChanger)
        {
            module.spriteRenderer = spriteRendererChanger(module.spriteRenderer);
            return module;
        }
        #endregion

        #region Texture
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTexture(this ParticleSystem particleSystem, Texture2D texture)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.texture = texture;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTexture(this ParticleSystem particleSystem, Func<Texture2D, Texture2D> textureChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.texture = textureChanger(module.texture);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTexture(this ShapeModule module, Texture2D texture)
        {
            module.texture = texture;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTexture(this ShapeModule module, Func<Texture2D, Texture2D> textureChanger)
        {
            module.texture = textureChanger(module.texture);
            return module;
        }
        #endregion

        #region TextureAlphaAffectsParticles
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureAlphaAffectsParticles(this ParticleSystem particleSystem, bool textureAlphaAffectsParticles)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.textureAlphaAffectsParticles = textureAlphaAffectsParticles;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureAlphaAffectsParticles(this ParticleSystem particleSystem, Func<bool, bool> textureAlphaAffectsParticlesChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.textureAlphaAffectsParticles = textureAlphaAffectsParticlesChanger(module.textureAlphaAffectsParticles);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureAlphaAffectsParticles(this ShapeModule module, bool textureAlphaAffectsParticles)
        {
            module.textureAlphaAffectsParticles = textureAlphaAffectsParticles;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureAlphaAffectsParticles(this ShapeModule module, Func<bool, bool> textureAlphaAffectsParticlesChanger)
        {
            module.textureAlphaAffectsParticles = textureAlphaAffectsParticlesChanger(module.textureAlphaAffectsParticles);
            return module;
        }
        #endregion

        #region TextureBilinearFiltering
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureBilinearFiltering(this ParticleSystem particleSystem, bool textureBilinearFiltering)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.textureBilinearFiltering = textureBilinearFiltering;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureBilinearFiltering(this ParticleSystem particleSystem, Func<bool, bool> textureBilinearFilteringChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.textureBilinearFiltering = textureBilinearFilteringChanger(module.textureBilinearFiltering);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureBilinearFiltering(this ShapeModule module, bool textureBilinearFiltering)
        {
            module.textureBilinearFiltering = textureBilinearFiltering;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureBilinearFiltering(this ShapeModule module, Func<bool, bool> textureBilinearFilteringChanger)
        {
            module.textureBilinearFiltering = textureBilinearFilteringChanger(module.textureBilinearFiltering);
            return module;
        }
        #endregion

        #region TextureClipChannel
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureClipChannel(this ParticleSystem particleSystem, ParticleSystemShapeTextureChannel textureClipChannel)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.textureClipChannel = textureClipChannel;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureClipChannel(this ParticleSystem particleSystem, Func<ParticleSystemShapeTextureChannel, ParticleSystemShapeTextureChannel> textureClipChannelChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.textureClipChannel = textureClipChannelChanger(module.textureClipChannel);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureClipChannel(this ShapeModule module, ParticleSystemShapeTextureChannel textureClipChannel)
        {
            module.textureClipChannel = textureClipChannel;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureClipChannel(this ShapeModule module, Func<ParticleSystemShapeTextureChannel, ParticleSystemShapeTextureChannel> textureClipChannelChanger)
        {
            module.textureClipChannel = textureClipChannelChanger(module.textureClipChannel);
            return module;
        }
        #endregion

        #region TextureClipThreshold
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureClipThreshold(this ParticleSystem particleSystem, float textureClipThreshold)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.textureClipThreshold = textureClipThreshold;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureClipThreshold(this ParticleSystem particleSystem, Func<float, float> textureClipThresholdChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.textureClipThreshold = textureClipThresholdChanger(module.textureClipThreshold);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureClipThreshold(this ShapeModule module, float textureClipThreshold)
        {
            module.textureClipThreshold = textureClipThreshold;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureClipThreshold(this ShapeModule module, Func<float, float> textureClipThresholdChanger)
        {
            module.textureClipThreshold = textureClipThresholdChanger(module.textureClipThreshold);
            return module;
        }
        #endregion

        #region TextureColorAffectsParticles
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureColorAffectsParticles(this ParticleSystem particleSystem, bool textureColorAffectsParticles)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.textureColorAffectsParticles = textureColorAffectsParticles;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureColorAffectsParticles(this ParticleSystem particleSystem, Func<bool, bool> textureColorAffectsParticlesChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.textureColorAffectsParticles = textureColorAffectsParticlesChanger(module.textureColorAffectsParticles);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureColorAffectsParticles(this ShapeModule module, bool textureColorAffectsParticles)
        {
            module.textureColorAffectsParticles = textureColorAffectsParticles;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureColorAffectsParticles(this ShapeModule module, Func<bool, bool> textureColorAffectsParticlesChanger)
        {
            module.textureColorAffectsParticles = textureColorAffectsParticlesChanger(module.textureColorAffectsParticles);
            return module;
        }
        #endregion

        #region TextureUVChannel
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureUVChannel(this ParticleSystem particleSystem, int textureUVChannel)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.textureUVChannel = textureUVChannel;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureUVChannel(this ParticleSystem particleSystem, Func<int, int> textureUVChannelChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.textureUVChannel = textureUVChannelChanger(module.textureUVChannel);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureUVChannel(this ShapeModule module, int textureUVChannel)
        {
            module.textureUVChannel = textureUVChannel;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureUVChannel(this ShapeModule module, Func<int, int> textureUVChannelChanger)
        {
            module.textureUVChannel = textureUVChannelChanger(module.textureUVChannel);
            return module;
        }
        #endregion

        #region UseMeshColors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeUseMeshColors(this ParticleSystem particleSystem, bool useMeshColors)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.useMeshColors = useMeshColors;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeUseMeshColors(this ParticleSystem particleSystem, Func<bool, bool> useMeshColorsChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.useMeshColors = useMeshColorsChanger(module.useMeshColors);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetUseMeshColors(this ShapeModule module, bool useMeshColors)
        {
            module.useMeshColors = useMeshColors;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetUseMeshColors(this ShapeModule module, Func<bool, bool> useMeshColorsChanger)
        {
            module.useMeshColors = useMeshColorsChanger(module.useMeshColors);
            return module;
        }
        #endregion

        #region UseMeshMaterialIndex
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeUseMeshMaterialIndex(this ParticleSystem particleSystem, bool useMeshMaterialIndex)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.useMeshMaterialIndex = useMeshMaterialIndex;
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeUseMeshMaterialIndex(this ParticleSystem particleSystem, Func<bool, bool> useMeshMaterialIndexChanger)
        {
            ThrowHelper.ThrowArgumentNullExceptionIfNull(particleSystem, nameof(particleSystem));
            var module = particleSystem.shape;
            module.useMeshMaterialIndex = useMeshMaterialIndexChanger(module.useMeshMaterialIndex);
            return particleSystem;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetUseMeshMaterialIndex(this ShapeModule module, bool useMeshMaterialIndex)
        {
            module.useMeshMaterialIndex = useMeshMaterialIndex;
            return module;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetUseMeshMaterialIndex(this ShapeModule module, Func<bool, bool> useMeshMaterialIndexChanger)
        {
            module.useMeshMaterialIndex = useMeshMaterialIndexChanger(module.useMeshMaterialIndex);
            return module;
        }
        #endregion
#endif
    }
}
