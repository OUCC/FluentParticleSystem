#if UNITY_2020_2_OR_NEWER
#nullable enable
#endif
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static UnityEngine.ParticleSystem;

namespace OUCC.FluentParticleSystem
{
    public static class ShapeModuleExtension
    {
#if UNITY_2018_4_OR_NEWER
        /// <summary>
        /// Edit <see cref="ParticleSystem.shape"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem EditShape(this ParticleSystem particleSystem, Action<ShapeModule> moduleEditor)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(moduleEditor != null, "moduleEditor cannot be null");
            moduleEditor(particleSystem.shape);
            return particleSystem;
        }

        #region AlignToDirection
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.alignToDirection"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeAlignToDirection(this ParticleSystem particleSystem, bool alignToDirection)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.alignToDirection = alignToDirection;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.alignToDirection"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeAlignToDirection(this ParticleSystem particleSystem, Func<bool, bool> alignToDirectionChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(alignToDirectionChanger != null, "alignToDirectionChanger cannot be null");
            var module = particleSystem.shape;
            module.alignToDirection = alignToDirectionChanger(module.alignToDirection);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.alignToDirection"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetAlignToDirection(this ShapeModule module, bool alignToDirection)
        {
            module.alignToDirection = alignToDirection;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.alignToDirection"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetAlignToDirection(this ShapeModule module, Func<bool, bool> alignToDirectionChanger)
        {
            Debug.Assert(alignToDirectionChanger != null, "alignToDirectionChanger cannot be null");
            module.alignToDirection = alignToDirectionChanger(module.alignToDirection);
            return module;
        }
        #endregion

        #region Angle
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.angle"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeAngle(this ParticleSystem particleSystem, float angle)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.angle = angle;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.angle"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeAngle(this ParticleSystem particleSystem, Func<float, float> angleChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(angleChanger != null, "angleChanger cannot be null");
            var module = particleSystem.shape;
            module.angle = angleChanger(module.angle);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.angle"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetAngle(this ShapeModule module, float angle)
        {
            module.angle = angle;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.angle"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetAngle(this ShapeModule module, Func<float, float> angleChanger)
        {
            Debug.Assert(angleChanger != null, "angleChanger cannot be null");
            module.angle = angleChanger(module.angle);
            return module;
        }
        #endregion

        #region Arc
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.arc"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArc(this ParticleSystem particleSystem, float arc)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.arc = arc;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.arc"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArc(this ParticleSystem particleSystem, Func<float, float> arcChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(arcChanger != null, "arcChanger cannot be null");
            var module = particleSystem.shape;
            module.arc = arcChanger(module.arc);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.arc"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArc(this ShapeModule module, float arc)
        {
            module.arc = arc;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.arc"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArc(this ShapeModule module, Func<float, float> arcChanger)
        {
            Debug.Assert(arcChanger != null, "arcChanger cannot be null");
            module.arc = arcChanger(module.arc);
            return module;
        }
        #endregion

        #region ArcMode
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.arcMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcMode(this ParticleSystem particleSystem, ParticleSystemShapeMultiModeValue arcMode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.arcMode = arcMode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.arcMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcMode(this ParticleSystem particleSystem, Func<ParticleSystemShapeMultiModeValue, ParticleSystemShapeMultiModeValue> arcModeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(arcModeChanger != null, "arcModeChanger cannot be null");
            var module = particleSystem.shape;
            module.arcMode = arcModeChanger(module.arcMode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.arcMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcMode(this ShapeModule module, ParticleSystemShapeMultiModeValue arcMode)
        {
            module.arcMode = arcMode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.arcMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcMode(this ShapeModule module, Func<ParticleSystemShapeMultiModeValue, ParticleSystemShapeMultiModeValue> arcModeChanger)
        {
            Debug.Assert(arcModeChanger != null, "arcModeChanger cannot be null");
            module.arcMode = arcModeChanger(module.arcMode);
            return module;
        }
        #endregion

        #region ArcSpeed
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.arcSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcSpeed(this ParticleSystem particleSystem, MinMaxCurve arcSpeed)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.arcSpeed = arcSpeed;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.arcSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcSpeed(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> arcSpeedChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(arcSpeedChanger != null, "arcSpeedChanger cannot be null");
            var module = particleSystem.shape;
            module.arcSpeed = arcSpeedChanger(module.arcSpeed);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.arcSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcSpeed(this ShapeModule module, MinMaxCurve arcSpeed)
        {
            module.arcSpeed = arcSpeed;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.arcSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcSpeed(this ShapeModule module, Func<MinMaxCurve, MinMaxCurve> arcSpeedChanger)
        {
            Debug.Assert(arcSpeedChanger != null, "arcSpeedChanger cannot be null");
            module.arcSpeed = arcSpeedChanger(module.arcSpeed);
            return module;
        }
        #endregion

        #region ArcSpeedMultiplier
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.arcSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcSpeedMultiplier(this ParticleSystem particleSystem, float arcSpeedMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.arcSpeedMultiplier = arcSpeedMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.arcSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcSpeedMultiplier(this ParticleSystem particleSystem, Func<float, float> arcSpeedMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(arcSpeedMultiplierChanger != null, "arcSpeedMultiplierChanger cannot be null");
            var module = particleSystem.shape;
            module.arcSpeedMultiplier = arcSpeedMultiplierChanger(module.arcSpeedMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.arcSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcSpeedMultiplier(this ShapeModule module, float arcSpeedMultiplier)
        {
            module.arcSpeedMultiplier = arcSpeedMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.arcSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcSpeedMultiplier(this ShapeModule module, Func<float, float> arcSpeedMultiplierChanger)
        {
            Debug.Assert(arcSpeedMultiplierChanger != null, "arcSpeedMultiplierChanger cannot be null");
            module.arcSpeedMultiplier = arcSpeedMultiplierChanger(module.arcSpeedMultiplier);
            return module;
        }
        #endregion

        #region ArcSpread
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.arcSpread"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcSpread(this ParticleSystem particleSystem, float arcSpread)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.arcSpread = arcSpread;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.arcSpread"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeArcSpread(this ParticleSystem particleSystem, Func<float, float> arcSpreadChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(arcSpreadChanger != null, "arcSpreadChanger cannot be null");
            var module = particleSystem.shape;
            module.arcSpread = arcSpreadChanger(module.arcSpread);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.arcSpread"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcSpread(this ShapeModule module, float arcSpread)
        {
            module.arcSpread = arcSpread;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.arcSpread"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetArcSpread(this ShapeModule module, Func<float, float> arcSpreadChanger)
        {
            Debug.Assert(arcSpreadChanger != null, "arcSpreadChanger cannot be null");
            module.arcSpread = arcSpreadChanger(module.arcSpread);
            return module;
        }
        #endregion

        #region Box
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.box"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("Please use scale instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/ShapeModule.scale", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeBox(this ParticleSystem particleSystem, Vector3 box)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.box = box;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.box"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("Please use scale instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/ShapeModule.scale", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeBox(this ParticleSystem particleSystem, Func<Vector3, Vector3> boxChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(boxChanger != null, "boxChanger cannot be null");
            var module = particleSystem.shape;
            module.box = boxChanger(module.box);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.box"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("Please use scale instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/ShapeModule.scale", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetBox(this ShapeModule module, Vector3 box)
        {
            module.box = box;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.box"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("Please use scale instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/ShapeModule.scale", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetBox(this ShapeModule module, Func<Vector3, Vector3> boxChanger)
        {
            Debug.Assert(boxChanger != null, "boxChanger cannot be null");
            module.box = boxChanger(module.box);
            return module;
        }
        #endregion

        #region BoxThickness
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.boxThickness"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeBoxThickness(this ParticleSystem particleSystem, Vector3 boxThickness)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.boxThickness = boxThickness;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.boxThickness"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeBoxThickness(this ParticleSystem particleSystem, Func<Vector3, Vector3> boxThicknessChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(boxThicknessChanger != null, "boxThicknessChanger cannot be null");
            var module = particleSystem.shape;
            module.boxThickness = boxThicknessChanger(module.boxThickness);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.boxThickness"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetBoxThickness(this ShapeModule module, Vector3 boxThickness)
        {
            module.boxThickness = boxThickness;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.boxThickness"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetBoxThickness(this ShapeModule module, Func<Vector3, Vector3> boxThicknessChanger)
        {
            Debug.Assert(boxThicknessChanger != null, "boxThicknessChanger cannot be null");
            module.boxThickness = boxThicknessChanger(module.boxThickness);
            return module;
        }
        #endregion

        #region DonutRadius
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.donutRadius"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeDonutRadius(this ParticleSystem particleSystem, float donutRadius)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.donutRadius = donutRadius;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.donutRadius"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeDonutRadius(this ParticleSystem particleSystem, Func<float, float> donutRadiusChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(donutRadiusChanger != null, "donutRadiusChanger cannot be null");
            var module = particleSystem.shape;
            module.donutRadius = donutRadiusChanger(module.donutRadius);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.donutRadius"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetDonutRadius(this ShapeModule module, float donutRadius)
        {
            module.donutRadius = donutRadius;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.donutRadius"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetDonutRadius(this ShapeModule module, Func<float, float> donutRadiusChanger)
        {
            Debug.Assert(donutRadiusChanger != null, "donutRadiusChanger cannot be null");
            module.donutRadius = donutRadiusChanger(module.donutRadius);
            return module;
        }
        #endregion

        #region Enabled
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeEnabled(this ParticleSystem particleSystem, bool enabled)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.enabled = enabled;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeEnabled(this ParticleSystem particleSystem, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            var module = particleSystem.shape;
            module.enabled = enabledChanger(module.enabled);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetEnabled(this ShapeModule module, bool enabled)
        {
            module.enabled = enabled;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.enabled"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetEnabled(this ShapeModule module, Func<bool, bool> enabledChanger)
        {
            Debug.Assert(enabledChanger != null, "enabledChanger cannot be null");
            module.enabled = enabledChanger(module.enabled);
            return module;
        }
        #endregion

        #region Length
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.length"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeLength(this ParticleSystem particleSystem, float length)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.length = length;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.length"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeLength(this ParticleSystem particleSystem, Func<float, float> lengthChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(lengthChanger != null, "lengthChanger cannot be null");
            var module = particleSystem.shape;
            module.length = lengthChanger(module.length);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.length"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetLength(this ShapeModule module, float length)
        {
            module.length = length;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.length"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetLength(this ShapeModule module, Func<float, float> lengthChanger)
        {
            Debug.Assert(lengthChanger != null, "lengthChanger cannot be null");
            module.length = lengthChanger(module.length);
            return module;
        }
        #endregion

        #region Mesh
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.mesh"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMesh(this ParticleSystem particleSystem, Mesh mesh)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.mesh = mesh;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.mesh"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMesh(this ParticleSystem particleSystem, Func<Mesh, Mesh> meshChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(meshChanger != null, "meshChanger cannot be null");
            var module = particleSystem.shape;
            module.mesh = meshChanger(module.mesh);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.mesh"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMesh(this ShapeModule module, Mesh mesh)
        {
            module.mesh = mesh;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.mesh"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMesh(this ShapeModule module, Func<Mesh, Mesh> meshChanger)
        {
            Debug.Assert(meshChanger != null, "meshChanger cannot be null");
            module.mesh = meshChanger(module.mesh);
            return module;
        }
        #endregion

        #region MeshMaterialIndex
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshMaterialIndex"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshMaterialIndex(this ParticleSystem particleSystem, int meshMaterialIndex)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.meshMaterialIndex = meshMaterialIndex;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshMaterialIndex"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshMaterialIndex(this ParticleSystem particleSystem, Func<int, int> meshMaterialIndexChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(meshMaterialIndexChanger != null, "meshMaterialIndexChanger cannot be null");
            var module = particleSystem.shape;
            module.meshMaterialIndex = meshMaterialIndexChanger(module.meshMaterialIndex);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshMaterialIndex"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshMaterialIndex(this ShapeModule module, int meshMaterialIndex)
        {
            module.meshMaterialIndex = meshMaterialIndex;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshMaterialIndex"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshMaterialIndex(this ShapeModule module, Func<int, int> meshMaterialIndexChanger)
        {
            Debug.Assert(meshMaterialIndexChanger != null, "meshMaterialIndexChanger cannot be null");
            module.meshMaterialIndex = meshMaterialIndexChanger(module.meshMaterialIndex);
            return module;
        }
        #endregion

        #region MeshRenderer
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshRenderer"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshRenderer(this ParticleSystem particleSystem, MeshRenderer meshRenderer)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.meshRenderer = meshRenderer;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshRenderer"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshRenderer(this ParticleSystem particleSystem, Func<MeshRenderer, MeshRenderer> meshRendererChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(meshRendererChanger != null, "meshRendererChanger cannot be null");
            var module = particleSystem.shape;
            module.meshRenderer = meshRendererChanger(module.meshRenderer);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshRenderer"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshRenderer(this ShapeModule module, MeshRenderer meshRenderer)
        {
            module.meshRenderer = meshRenderer;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshRenderer"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshRenderer(this ShapeModule module, Func<MeshRenderer, MeshRenderer> meshRendererChanger)
        {
            Debug.Assert(meshRendererChanger != null, "meshRendererChanger cannot be null");
            module.meshRenderer = meshRendererChanger(module.meshRenderer);
            return module;
        }
        #endregion

        #region MeshScale
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshScale"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("meshScale property is deprecated.Please use scale instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshScale(this ParticleSystem particleSystem, float meshScale)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.meshScale = meshScale;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshScale"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("meshScale property is deprecated.Please use scale instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshScale(this ParticleSystem particleSystem, Func<float, float> meshScaleChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(meshScaleChanger != null, "meshScaleChanger cannot be null");
            var module = particleSystem.shape;
            module.meshScale = meshScaleChanger(module.meshScale);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshScale"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("meshScale property is deprecated.Please use scale instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshScale(this ShapeModule module, float meshScale)
        {
            module.meshScale = meshScale;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshScale"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("meshScale property is deprecated.Please use scale instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshScale(this ShapeModule module, Func<float, float> meshScaleChanger)
        {
            Debug.Assert(meshScaleChanger != null, "meshScaleChanger cannot be null");
            module.meshScale = meshScaleChanger(module.meshScale);
            return module;
        }
        #endregion

        #region MeshShapeType
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshShapeType"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshShapeType(this ParticleSystem particleSystem, ParticleSystemMeshShapeType meshShapeType)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.meshShapeType = meshShapeType;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshShapeType"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshShapeType(this ParticleSystem particleSystem, Func<ParticleSystemMeshShapeType, ParticleSystemMeshShapeType> meshShapeTypeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(meshShapeTypeChanger != null, "meshShapeTypeChanger cannot be null");
            var module = particleSystem.shape;
            module.meshShapeType = meshShapeTypeChanger(module.meshShapeType);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshShapeType"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshShapeType(this ShapeModule module, ParticleSystemMeshShapeType meshShapeType)
        {
            module.meshShapeType = meshShapeType;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshShapeType"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshShapeType(this ShapeModule module, Func<ParticleSystemMeshShapeType, ParticleSystemMeshShapeType> meshShapeTypeChanger)
        {
            Debug.Assert(meshShapeTypeChanger != null, "meshShapeTypeChanger cannot be null");
            module.meshShapeType = meshShapeTypeChanger(module.meshShapeType);
            return module;
        }
        #endregion

        #region MeshSpawnMode
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshSpawnMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnMode(this ParticleSystem particleSystem, ParticleSystemShapeMultiModeValue meshSpawnMode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.meshSpawnMode = meshSpawnMode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshSpawnMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnMode(this ParticleSystem particleSystem, Func<ParticleSystemShapeMultiModeValue, ParticleSystemShapeMultiModeValue> meshSpawnModeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(meshSpawnModeChanger != null, "meshSpawnModeChanger cannot be null");
            var module = particleSystem.shape;
            module.meshSpawnMode = meshSpawnModeChanger(module.meshSpawnMode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshSpawnMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnMode(this ShapeModule module, ParticleSystemShapeMultiModeValue meshSpawnMode)
        {
            module.meshSpawnMode = meshSpawnMode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshSpawnMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnMode(this ShapeModule module, Func<ParticleSystemShapeMultiModeValue, ParticleSystemShapeMultiModeValue> meshSpawnModeChanger)
        {
            Debug.Assert(meshSpawnModeChanger != null, "meshSpawnModeChanger cannot be null");
            module.meshSpawnMode = meshSpawnModeChanger(module.meshSpawnMode);
            return module;
        }
        #endregion

        #region MeshSpawnSpeed
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshSpawnSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnSpeed(this ParticleSystem particleSystem, MinMaxCurve meshSpawnSpeed)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.meshSpawnSpeed = meshSpawnSpeed;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshSpawnSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnSpeed(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> meshSpawnSpeedChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(meshSpawnSpeedChanger != null, "meshSpawnSpeedChanger cannot be null");
            var module = particleSystem.shape;
            module.meshSpawnSpeed = meshSpawnSpeedChanger(module.meshSpawnSpeed);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshSpawnSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnSpeed(this ShapeModule module, MinMaxCurve meshSpawnSpeed)
        {
            module.meshSpawnSpeed = meshSpawnSpeed;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshSpawnSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnSpeed(this ShapeModule module, Func<MinMaxCurve, MinMaxCurve> meshSpawnSpeedChanger)
        {
            Debug.Assert(meshSpawnSpeedChanger != null, "meshSpawnSpeedChanger cannot be null");
            module.meshSpawnSpeed = meshSpawnSpeedChanger(module.meshSpawnSpeed);
            return module;
        }
        #endregion

        #region MeshSpawnSpeedMultiplier
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshSpawnSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnSpeedMultiplier(this ParticleSystem particleSystem, float meshSpawnSpeedMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.meshSpawnSpeedMultiplier = meshSpawnSpeedMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshSpawnSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnSpeedMultiplier(this ParticleSystem particleSystem, Func<float, float> meshSpawnSpeedMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(meshSpawnSpeedMultiplierChanger != null, "meshSpawnSpeedMultiplierChanger cannot be null");
            var module = particleSystem.shape;
            module.meshSpawnSpeedMultiplier = meshSpawnSpeedMultiplierChanger(module.meshSpawnSpeedMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshSpawnSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnSpeedMultiplier(this ShapeModule module, float meshSpawnSpeedMultiplier)
        {
            module.meshSpawnSpeedMultiplier = meshSpawnSpeedMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshSpawnSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnSpeedMultiplier(this ShapeModule module, Func<float, float> meshSpawnSpeedMultiplierChanger)
        {
            Debug.Assert(meshSpawnSpeedMultiplierChanger != null, "meshSpawnSpeedMultiplierChanger cannot be null");
            module.meshSpawnSpeedMultiplier = meshSpawnSpeedMultiplierChanger(module.meshSpawnSpeedMultiplier);
            return module;
        }
        #endregion

        #region MeshSpawnSpread
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshSpawnSpread"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnSpread(this ParticleSystem particleSystem, float meshSpawnSpread)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.meshSpawnSpread = meshSpawnSpread;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshSpawnSpread"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeMeshSpawnSpread(this ParticleSystem particleSystem, Func<float, float> meshSpawnSpreadChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(meshSpawnSpreadChanger != null, "meshSpawnSpreadChanger cannot be null");
            var module = particleSystem.shape;
            module.meshSpawnSpread = meshSpawnSpreadChanger(module.meshSpawnSpread);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.meshSpawnSpread"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnSpread(this ShapeModule module, float meshSpawnSpread)
        {
            module.meshSpawnSpread = meshSpawnSpread;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.meshSpawnSpread"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetMeshSpawnSpread(this ShapeModule module, Func<float, float> meshSpawnSpreadChanger)
        {
            Debug.Assert(meshSpawnSpreadChanger != null, "meshSpawnSpreadChanger cannot be null");
            module.meshSpawnSpread = meshSpawnSpreadChanger(module.meshSpawnSpread);
            return module;
        }
        #endregion

        #region NormalOffset
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.normalOffset"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeNormalOffset(this ParticleSystem particleSystem, float normalOffset)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.normalOffset = normalOffset;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.normalOffset"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeNormalOffset(this ParticleSystem particleSystem, Func<float, float> normalOffsetChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(normalOffsetChanger != null, "normalOffsetChanger cannot be null");
            var module = particleSystem.shape;
            module.normalOffset = normalOffsetChanger(module.normalOffset);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.normalOffset"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetNormalOffset(this ShapeModule module, float normalOffset)
        {
            module.normalOffset = normalOffset;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.normalOffset"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetNormalOffset(this ShapeModule module, Func<float, float> normalOffsetChanger)
        {
            Debug.Assert(normalOffsetChanger != null, "normalOffsetChanger cannot be null");
            module.normalOffset = normalOffsetChanger(module.normalOffset);
            return module;
        }
        #endregion

        #region Position
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.position"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapePosition(this ParticleSystem particleSystem, Vector3 position)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.position = position;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.position"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapePosition(this ParticleSystem particleSystem, Func<Vector3, Vector3> positionChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(positionChanger != null, "positionChanger cannot be null");
            var module = particleSystem.shape;
            module.position = positionChanger(module.position);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.position"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetPosition(this ShapeModule module, Vector3 position)
        {
            module.position = position;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.position"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetPosition(this ShapeModule module, Func<Vector3, Vector3> positionChanger)
        {
            Debug.Assert(positionChanger != null, "positionChanger cannot be null");
            module.position = positionChanger(module.position);
            return module;
        }
        #endregion

        #region Radius
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.radius"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadius(this ParticleSystem particleSystem, float radius)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.radius = radius;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.radius"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadius(this ParticleSystem particleSystem, Func<float, float> radiusChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(radiusChanger != null, "radiusChanger cannot be null");
            var module = particleSystem.shape;
            module.radius = radiusChanger(module.radius);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.radius"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadius(this ShapeModule module, float radius)
        {
            module.radius = radius;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.radius"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadius(this ShapeModule module, Func<float, float> radiusChanger)
        {
            Debug.Assert(radiusChanger != null, "radiusChanger cannot be null");
            module.radius = radiusChanger(module.radius);
            return module;
        }
        #endregion

        #region RadiusMode
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.radiusMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusMode(this ParticleSystem particleSystem, ParticleSystemShapeMultiModeValue radiusMode)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.radiusMode = radiusMode;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.radiusMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusMode(this ParticleSystem particleSystem, Func<ParticleSystemShapeMultiModeValue, ParticleSystemShapeMultiModeValue> radiusModeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(radiusModeChanger != null, "radiusModeChanger cannot be null");
            var module = particleSystem.shape;
            module.radiusMode = radiusModeChanger(module.radiusMode);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.radiusMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusMode(this ShapeModule module, ParticleSystemShapeMultiModeValue radiusMode)
        {
            module.radiusMode = radiusMode;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.radiusMode"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusMode(this ShapeModule module, Func<ParticleSystemShapeMultiModeValue, ParticleSystemShapeMultiModeValue> radiusModeChanger)
        {
            Debug.Assert(radiusModeChanger != null, "radiusModeChanger cannot be null");
            module.radiusMode = radiusModeChanger(module.radiusMode);
            return module;
        }
        #endregion

        #region RadiusSpeed
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.radiusSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusSpeed(this ParticleSystem particleSystem, MinMaxCurve radiusSpeed)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.radiusSpeed = radiusSpeed;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.radiusSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusSpeed(this ParticleSystem particleSystem, Func<MinMaxCurve, MinMaxCurve> radiusSpeedChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(radiusSpeedChanger != null, "radiusSpeedChanger cannot be null");
            var module = particleSystem.shape;
            module.radiusSpeed = radiusSpeedChanger(module.radiusSpeed);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.radiusSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusSpeed(this ShapeModule module, MinMaxCurve radiusSpeed)
        {
            module.radiusSpeed = radiusSpeed;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.radiusSpeed"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusSpeed(this ShapeModule module, Func<MinMaxCurve, MinMaxCurve> radiusSpeedChanger)
        {
            Debug.Assert(radiusSpeedChanger != null, "radiusSpeedChanger cannot be null");
            module.radiusSpeed = radiusSpeedChanger(module.radiusSpeed);
            return module;
        }
        #endregion

        #region RadiusSpeedMultiplier
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.radiusSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusSpeedMultiplier(this ParticleSystem particleSystem, float radiusSpeedMultiplier)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.radiusSpeedMultiplier = radiusSpeedMultiplier;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.radiusSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusSpeedMultiplier(this ParticleSystem particleSystem, Func<float, float> radiusSpeedMultiplierChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(radiusSpeedMultiplierChanger != null, "radiusSpeedMultiplierChanger cannot be null");
            var module = particleSystem.shape;
            module.radiusSpeedMultiplier = radiusSpeedMultiplierChanger(module.radiusSpeedMultiplier);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.radiusSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusSpeedMultiplier(this ShapeModule module, float radiusSpeedMultiplier)
        {
            module.radiusSpeedMultiplier = radiusSpeedMultiplier;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.radiusSpeedMultiplier"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusSpeedMultiplier(this ShapeModule module, Func<float, float> radiusSpeedMultiplierChanger)
        {
            Debug.Assert(radiusSpeedMultiplierChanger != null, "radiusSpeedMultiplierChanger cannot be null");
            module.radiusSpeedMultiplier = radiusSpeedMultiplierChanger(module.radiusSpeedMultiplier);
            return module;
        }
        #endregion

        #region RadiusSpread
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.radiusSpread"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusSpread(this ParticleSystem particleSystem, float radiusSpread)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.radiusSpread = radiusSpread;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.radiusSpread"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusSpread(this ParticleSystem particleSystem, Func<float, float> radiusSpreadChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(radiusSpreadChanger != null, "radiusSpreadChanger cannot be null");
            var module = particleSystem.shape;
            module.radiusSpread = radiusSpreadChanger(module.radiusSpread);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.radiusSpread"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusSpread(this ShapeModule module, float radiusSpread)
        {
            module.radiusSpread = radiusSpread;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.radiusSpread"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusSpread(this ShapeModule module, Func<float, float> radiusSpreadChanger)
        {
            Debug.Assert(radiusSpreadChanger != null, "radiusSpreadChanger cannot be null");
            module.radiusSpread = radiusSpreadChanger(module.radiusSpread);
            return module;
        }
        #endregion

        #region RadiusThickness
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.radiusThickness"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusThickness(this ParticleSystem particleSystem, float radiusThickness)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.radiusThickness = radiusThickness;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.radiusThickness"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRadiusThickness(this ParticleSystem particleSystem, Func<float, float> radiusThicknessChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(radiusThicknessChanger != null, "radiusThicknessChanger cannot be null");
            var module = particleSystem.shape;
            module.radiusThickness = radiusThicknessChanger(module.radiusThickness);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.radiusThickness"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusThickness(this ShapeModule module, float radiusThickness)
        {
            module.radiusThickness = radiusThickness;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.radiusThickness"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRadiusThickness(this ShapeModule module, Func<float, float> radiusThicknessChanger)
        {
            Debug.Assert(radiusThicknessChanger != null, "radiusThicknessChanger cannot be null");
            module.radiusThickness = radiusThicknessChanger(module.radiusThickness);
            return module;
        }
        #endregion

        #region RandomDirection
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.randomDirection"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("randomDirection property is deprecated. Use randomDirectionAmount instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRandomDirection(this ParticleSystem particleSystem, bool randomDirection)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.randomDirection = randomDirection;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.randomDirection"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("randomDirection property is deprecated. Use randomDirectionAmount instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRandomDirection(this ParticleSystem particleSystem, Func<bool, bool> randomDirectionChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(randomDirectionChanger != null, "randomDirectionChanger cannot be null");
            var module = particleSystem.shape;
            module.randomDirection = randomDirectionChanger(module.randomDirection);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.randomDirection"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("randomDirection property is deprecated. Use randomDirectionAmount instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRandomDirection(this ShapeModule module, bool randomDirection)
        {
            module.randomDirection = randomDirection;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.randomDirection"/>
        /// </summary>
#if UNITY_2018_4_OR_NEWER
        [Obsolete("randomDirection property is deprecated. Use randomDirectionAmount instead.", false)]
#endif
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRandomDirection(this ShapeModule module, Func<bool, bool> randomDirectionChanger)
        {
            Debug.Assert(randomDirectionChanger != null, "randomDirectionChanger cannot be null");
            module.randomDirection = randomDirectionChanger(module.randomDirection);
            return module;
        }
        #endregion

        #region RandomDirectionAmount
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.randomDirectionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRandomDirectionAmount(this ParticleSystem particleSystem, float randomDirectionAmount)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.randomDirectionAmount = randomDirectionAmount;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.randomDirectionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRandomDirectionAmount(this ParticleSystem particleSystem, Func<float, float> randomDirectionAmountChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(randomDirectionAmountChanger != null, "randomDirectionAmountChanger cannot be null");
            var module = particleSystem.shape;
            module.randomDirectionAmount = randomDirectionAmountChanger(module.randomDirectionAmount);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.randomDirectionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRandomDirectionAmount(this ShapeModule module, float randomDirectionAmount)
        {
            module.randomDirectionAmount = randomDirectionAmount;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.randomDirectionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRandomDirectionAmount(this ShapeModule module, Func<float, float> randomDirectionAmountChanger)
        {
            Debug.Assert(randomDirectionAmountChanger != null, "randomDirectionAmountChanger cannot be null");
            module.randomDirectionAmount = randomDirectionAmountChanger(module.randomDirectionAmount);
            return module;
        }
        #endregion

        #region RandomPositionAmount
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.randomPositionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRandomPositionAmount(this ParticleSystem particleSystem, float randomPositionAmount)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.randomPositionAmount = randomPositionAmount;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.randomPositionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRandomPositionAmount(this ParticleSystem particleSystem, Func<float, float> randomPositionAmountChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(randomPositionAmountChanger != null, "randomPositionAmountChanger cannot be null");
            var module = particleSystem.shape;
            module.randomPositionAmount = randomPositionAmountChanger(module.randomPositionAmount);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.randomPositionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRandomPositionAmount(this ShapeModule module, float randomPositionAmount)
        {
            module.randomPositionAmount = randomPositionAmount;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.randomPositionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRandomPositionAmount(this ShapeModule module, Func<float, float> randomPositionAmountChanger)
        {
            Debug.Assert(randomPositionAmountChanger != null, "randomPositionAmountChanger cannot be null");
            module.randomPositionAmount = randomPositionAmountChanger(module.randomPositionAmount);
            return module;
        }
        #endregion

        #region Rotation
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.rotation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRotation(this ParticleSystem particleSystem, Vector3 rotation)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.rotation = rotation;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.rotation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeRotation(this ParticleSystem particleSystem, Func<Vector3, Vector3> rotationChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(rotationChanger != null, "rotationChanger cannot be null");
            var module = particleSystem.shape;
            module.rotation = rotationChanger(module.rotation);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.rotation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRotation(this ShapeModule module, Vector3 rotation)
        {
            module.rotation = rotation;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.rotation"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetRotation(this ShapeModule module, Func<Vector3, Vector3> rotationChanger)
        {
            Debug.Assert(rotationChanger != null, "rotationChanger cannot be null");
            module.rotation = rotationChanger(module.rotation);
            return module;
        }
        #endregion

        #region Scale
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.scale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeScale(this ParticleSystem particleSystem, Vector3 scale)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.scale = scale;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.scale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeScale(this ParticleSystem particleSystem, Func<Vector3, Vector3> scaleChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(scaleChanger != null, "scaleChanger cannot be null");
            var module = particleSystem.shape;
            module.scale = scaleChanger(module.scale);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.scale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetScale(this ShapeModule module, Vector3 scale)
        {
            module.scale = scale;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.scale"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetScale(this ShapeModule module, Func<Vector3, Vector3> scaleChanger)
        {
            Debug.Assert(scaleChanger != null, "scaleChanger cannot be null");
            module.scale = scaleChanger(module.scale);
            return module;
        }
        #endregion

        #region ShapeType
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.shapeType"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeShapeType(this ParticleSystem particleSystem, ParticleSystemShapeType shapeType)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.shapeType = shapeType;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.shapeType"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeShapeType(this ParticleSystem particleSystem, Func<ParticleSystemShapeType, ParticleSystemShapeType> shapeTypeChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(shapeTypeChanger != null, "shapeTypeChanger cannot be null");
            var module = particleSystem.shape;
            module.shapeType = shapeTypeChanger(module.shapeType);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.shapeType"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetShapeType(this ShapeModule module, ParticleSystemShapeType shapeType)
        {
            module.shapeType = shapeType;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.shapeType"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetShapeType(this ShapeModule module, Func<ParticleSystemShapeType, ParticleSystemShapeType> shapeTypeChanger)
        {
            Debug.Assert(shapeTypeChanger != null, "shapeTypeChanger cannot be null");
            module.shapeType = shapeTypeChanger(module.shapeType);
            return module;
        }
        #endregion

        #region SkinnedMeshRenderer
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.skinnedMeshRenderer"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSkinnedMeshRenderer(this ParticleSystem particleSystem, SkinnedMeshRenderer skinnedMeshRenderer)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.skinnedMeshRenderer = skinnedMeshRenderer;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.skinnedMeshRenderer"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSkinnedMeshRenderer(this ParticleSystem particleSystem, Func<SkinnedMeshRenderer, SkinnedMeshRenderer> skinnedMeshRendererChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(skinnedMeshRendererChanger != null, "skinnedMeshRendererChanger cannot be null");
            var module = particleSystem.shape;
            module.skinnedMeshRenderer = skinnedMeshRendererChanger(module.skinnedMeshRenderer);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.skinnedMeshRenderer"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSkinnedMeshRenderer(this ShapeModule module, SkinnedMeshRenderer skinnedMeshRenderer)
        {
            module.skinnedMeshRenderer = skinnedMeshRenderer;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.skinnedMeshRenderer"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSkinnedMeshRenderer(this ShapeModule module, Func<SkinnedMeshRenderer, SkinnedMeshRenderer> skinnedMeshRendererChanger)
        {
            Debug.Assert(skinnedMeshRendererChanger != null, "skinnedMeshRendererChanger cannot be null");
            module.skinnedMeshRenderer = skinnedMeshRendererChanger(module.skinnedMeshRenderer);
            return module;
        }
        #endregion

        #region SphericalDirectionAmount
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.sphericalDirectionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSphericalDirectionAmount(this ParticleSystem particleSystem, float sphericalDirectionAmount)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.sphericalDirectionAmount = sphericalDirectionAmount;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.sphericalDirectionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSphericalDirectionAmount(this ParticleSystem particleSystem, Func<float, float> sphericalDirectionAmountChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(sphericalDirectionAmountChanger != null, "sphericalDirectionAmountChanger cannot be null");
            var module = particleSystem.shape;
            module.sphericalDirectionAmount = sphericalDirectionAmountChanger(module.sphericalDirectionAmount);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.sphericalDirectionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSphericalDirectionAmount(this ShapeModule module, float sphericalDirectionAmount)
        {
            module.sphericalDirectionAmount = sphericalDirectionAmount;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.sphericalDirectionAmount"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSphericalDirectionAmount(this ShapeModule module, Func<float, float> sphericalDirectionAmountChanger)
        {
            Debug.Assert(sphericalDirectionAmountChanger != null, "sphericalDirectionAmountChanger cannot be null");
            module.sphericalDirectionAmount = sphericalDirectionAmountChanger(module.sphericalDirectionAmount);
            return module;
        }
        #endregion

        #region Sprite
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.sprite"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSprite(this ParticleSystem particleSystem, Sprite sprite)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.sprite = sprite;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.sprite"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSprite(this ParticleSystem particleSystem, Func<Sprite, Sprite> spriteChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(spriteChanger != null, "spriteChanger cannot be null");
            var module = particleSystem.shape;
            module.sprite = spriteChanger(module.sprite);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.sprite"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSprite(this ShapeModule module, Sprite sprite)
        {
            module.sprite = sprite;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.sprite"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSprite(this ShapeModule module, Func<Sprite, Sprite> spriteChanger)
        {
            Debug.Assert(spriteChanger != null, "spriteChanger cannot be null");
            module.sprite = spriteChanger(module.sprite);
            return module;
        }
        #endregion

        #region SpriteRenderer
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.spriteRenderer"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSpriteRenderer(this ParticleSystem particleSystem, SpriteRenderer spriteRenderer)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.spriteRenderer = spriteRenderer;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.spriteRenderer"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeSpriteRenderer(this ParticleSystem particleSystem, Func<SpriteRenderer, SpriteRenderer> spriteRendererChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(spriteRendererChanger != null, "spriteRendererChanger cannot be null");
            var module = particleSystem.shape;
            module.spriteRenderer = spriteRendererChanger(module.spriteRenderer);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.spriteRenderer"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSpriteRenderer(this ShapeModule module, SpriteRenderer spriteRenderer)
        {
            module.spriteRenderer = spriteRenderer;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.spriteRenderer"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetSpriteRenderer(this ShapeModule module, Func<SpriteRenderer, SpriteRenderer> spriteRendererChanger)
        {
            Debug.Assert(spriteRendererChanger != null, "spriteRendererChanger cannot be null");
            module.spriteRenderer = spriteRendererChanger(module.spriteRenderer);
            return module;
        }
        #endregion

        #region Texture
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.texture"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTexture(this ParticleSystem particleSystem, Texture2D texture)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.texture = texture;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.texture"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTexture(this ParticleSystem particleSystem, Func<Texture2D, Texture2D> textureChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(textureChanger != null, "textureChanger cannot be null");
            var module = particleSystem.shape;
            module.texture = textureChanger(module.texture);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.texture"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTexture(this ShapeModule module, Texture2D texture)
        {
            module.texture = texture;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.texture"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTexture(this ShapeModule module, Func<Texture2D, Texture2D> textureChanger)
        {
            Debug.Assert(textureChanger != null, "textureChanger cannot be null");
            module.texture = textureChanger(module.texture);
            return module;
        }
        #endregion

        #region TextureAlphaAffectsParticles
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.textureAlphaAffectsParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureAlphaAffectsParticles(this ParticleSystem particleSystem, bool textureAlphaAffectsParticles)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.textureAlphaAffectsParticles = textureAlphaAffectsParticles;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.textureAlphaAffectsParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureAlphaAffectsParticles(this ParticleSystem particleSystem, Func<bool, bool> textureAlphaAffectsParticlesChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(textureAlphaAffectsParticlesChanger != null, "textureAlphaAffectsParticlesChanger cannot be null");
            var module = particleSystem.shape;
            module.textureAlphaAffectsParticles = textureAlphaAffectsParticlesChanger(module.textureAlphaAffectsParticles);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.textureAlphaAffectsParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureAlphaAffectsParticles(this ShapeModule module, bool textureAlphaAffectsParticles)
        {
            module.textureAlphaAffectsParticles = textureAlphaAffectsParticles;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.textureAlphaAffectsParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureAlphaAffectsParticles(this ShapeModule module, Func<bool, bool> textureAlphaAffectsParticlesChanger)
        {
            Debug.Assert(textureAlphaAffectsParticlesChanger != null, "textureAlphaAffectsParticlesChanger cannot be null");
            module.textureAlphaAffectsParticles = textureAlphaAffectsParticlesChanger(module.textureAlphaAffectsParticles);
            return module;
        }
        #endregion

        #region TextureBilinearFiltering
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.textureBilinearFiltering"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureBilinearFiltering(this ParticleSystem particleSystem, bool textureBilinearFiltering)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.textureBilinearFiltering = textureBilinearFiltering;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.textureBilinearFiltering"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureBilinearFiltering(this ParticleSystem particleSystem, Func<bool, bool> textureBilinearFilteringChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(textureBilinearFilteringChanger != null, "textureBilinearFilteringChanger cannot be null");
            var module = particleSystem.shape;
            module.textureBilinearFiltering = textureBilinearFilteringChanger(module.textureBilinearFiltering);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.textureBilinearFiltering"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureBilinearFiltering(this ShapeModule module, bool textureBilinearFiltering)
        {
            module.textureBilinearFiltering = textureBilinearFiltering;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.textureBilinearFiltering"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureBilinearFiltering(this ShapeModule module, Func<bool, bool> textureBilinearFilteringChanger)
        {
            Debug.Assert(textureBilinearFilteringChanger != null, "textureBilinearFilteringChanger cannot be null");
            module.textureBilinearFiltering = textureBilinearFilteringChanger(module.textureBilinearFiltering);
            return module;
        }
        #endregion

        #region TextureClipChannel
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.textureClipChannel"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureClipChannel(this ParticleSystem particleSystem, ParticleSystemShapeTextureChannel textureClipChannel)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.textureClipChannel = textureClipChannel;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.textureClipChannel"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureClipChannel(this ParticleSystem particleSystem, Func<ParticleSystemShapeTextureChannel, ParticleSystemShapeTextureChannel> textureClipChannelChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(textureClipChannelChanger != null, "textureClipChannelChanger cannot be null");
            var module = particleSystem.shape;
            module.textureClipChannel = textureClipChannelChanger(module.textureClipChannel);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.textureClipChannel"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureClipChannel(this ShapeModule module, ParticleSystemShapeTextureChannel textureClipChannel)
        {
            module.textureClipChannel = textureClipChannel;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.textureClipChannel"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureClipChannel(this ShapeModule module, Func<ParticleSystemShapeTextureChannel, ParticleSystemShapeTextureChannel> textureClipChannelChanger)
        {
            Debug.Assert(textureClipChannelChanger != null, "textureClipChannelChanger cannot be null");
            module.textureClipChannel = textureClipChannelChanger(module.textureClipChannel);
            return module;
        }
        #endregion

        #region TextureClipThreshold
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.textureClipThreshold"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureClipThreshold(this ParticleSystem particleSystem, float textureClipThreshold)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.textureClipThreshold = textureClipThreshold;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.textureClipThreshold"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureClipThreshold(this ParticleSystem particleSystem, Func<float, float> textureClipThresholdChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(textureClipThresholdChanger != null, "textureClipThresholdChanger cannot be null");
            var module = particleSystem.shape;
            module.textureClipThreshold = textureClipThresholdChanger(module.textureClipThreshold);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.textureClipThreshold"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureClipThreshold(this ShapeModule module, float textureClipThreshold)
        {
            module.textureClipThreshold = textureClipThreshold;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.textureClipThreshold"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureClipThreshold(this ShapeModule module, Func<float, float> textureClipThresholdChanger)
        {
            Debug.Assert(textureClipThresholdChanger != null, "textureClipThresholdChanger cannot be null");
            module.textureClipThreshold = textureClipThresholdChanger(module.textureClipThreshold);
            return module;
        }
        #endregion

        #region TextureColorAffectsParticles
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.textureColorAffectsParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureColorAffectsParticles(this ParticleSystem particleSystem, bool textureColorAffectsParticles)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.textureColorAffectsParticles = textureColorAffectsParticles;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.textureColorAffectsParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureColorAffectsParticles(this ParticleSystem particleSystem, Func<bool, bool> textureColorAffectsParticlesChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(textureColorAffectsParticlesChanger != null, "textureColorAffectsParticlesChanger cannot be null");
            var module = particleSystem.shape;
            module.textureColorAffectsParticles = textureColorAffectsParticlesChanger(module.textureColorAffectsParticles);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.textureColorAffectsParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureColorAffectsParticles(this ShapeModule module, bool textureColorAffectsParticles)
        {
            module.textureColorAffectsParticles = textureColorAffectsParticles;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.textureColorAffectsParticles"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureColorAffectsParticles(this ShapeModule module, Func<bool, bool> textureColorAffectsParticlesChanger)
        {
            Debug.Assert(textureColorAffectsParticlesChanger != null, "textureColorAffectsParticlesChanger cannot be null");
            module.textureColorAffectsParticles = textureColorAffectsParticlesChanger(module.textureColorAffectsParticles);
            return module;
        }
        #endregion

        #region TextureUVChannel
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.textureUVChannel"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureUVChannel(this ParticleSystem particleSystem, int textureUVChannel)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.textureUVChannel = textureUVChannel;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.textureUVChannel"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeTextureUVChannel(this ParticleSystem particleSystem, Func<int, int> textureUVChannelChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(textureUVChannelChanger != null, "textureUVChannelChanger cannot be null");
            var module = particleSystem.shape;
            module.textureUVChannel = textureUVChannelChanger(module.textureUVChannel);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.textureUVChannel"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureUVChannel(this ShapeModule module, int textureUVChannel)
        {
            module.textureUVChannel = textureUVChannel;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.textureUVChannel"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetTextureUVChannel(this ShapeModule module, Func<int, int> textureUVChannelChanger)
        {
            Debug.Assert(textureUVChannelChanger != null, "textureUVChannelChanger cannot be null");
            module.textureUVChannel = textureUVChannelChanger(module.textureUVChannel);
            return module;
        }
        #endregion

        #region UseMeshColors
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.useMeshColors"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeUseMeshColors(this ParticleSystem particleSystem, bool useMeshColors)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.useMeshColors = useMeshColors;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.useMeshColors"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeUseMeshColors(this ParticleSystem particleSystem, Func<bool, bool> useMeshColorsChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(useMeshColorsChanger != null, "useMeshColorsChanger cannot be null");
            var module = particleSystem.shape;
            module.useMeshColors = useMeshColorsChanger(module.useMeshColors);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.useMeshColors"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetUseMeshColors(this ShapeModule module, bool useMeshColors)
        {
            module.useMeshColors = useMeshColors;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.useMeshColors"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetUseMeshColors(this ShapeModule module, Func<bool, bool> useMeshColorsChanger)
        {
            Debug.Assert(useMeshColorsChanger != null, "useMeshColorsChanger cannot be null");
            module.useMeshColors = useMeshColorsChanger(module.useMeshColors);
            return module;
        }
        #endregion

        #region UseMeshMaterialIndex
        /// <summary>
        /// Assign a value to <see cref="ShapeModule.useMeshMaterialIndex"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeUseMeshMaterialIndex(this ParticleSystem particleSystem, bool useMeshMaterialIndex)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            var module = particleSystem.shape;
            module.useMeshMaterialIndex = useMeshMaterialIndex;
            return particleSystem;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.useMeshMaterialIndex"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem SetShapeUseMeshMaterialIndex(this ParticleSystem particleSystem, Func<bool, bool> useMeshMaterialIndexChanger)
        {
            Debug.Assert(particleSystem != null, "particleSystem cannot be null");
            Debug.Assert(useMeshMaterialIndexChanger != null, "useMeshMaterialIndexChanger cannot be null");
            var module = particleSystem.shape;
            module.useMeshMaterialIndex = useMeshMaterialIndexChanger(module.useMeshMaterialIndex);
            return particleSystem;
        }

        /// <summary>
        /// Assign a value to <see cref="ShapeModule.useMeshMaterialIndex"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetUseMeshMaterialIndex(this ShapeModule module, bool useMeshMaterialIndex)
        {
            module.useMeshMaterialIndex = useMeshMaterialIndex;
            return module;
        }

        /// <summary>
        /// Edit <see cref="ShapeModule.useMeshMaterialIndex"/>
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ShapeModule SetUseMeshMaterialIndex(this ShapeModule module, Func<bool, bool> useMeshMaterialIndexChanger)
        {
            Debug.Assert(useMeshMaterialIndexChanger != null, "useMeshMaterialIndexChanger cannot be null");
            module.useMeshMaterialIndex = useMeshMaterialIndexChanger(module.useMeshMaterialIndex);
            return module;
        }
        #endregion
#endif
    }
}
