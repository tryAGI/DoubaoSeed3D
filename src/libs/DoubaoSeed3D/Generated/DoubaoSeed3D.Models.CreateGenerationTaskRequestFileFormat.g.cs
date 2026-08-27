
#nullable enable

namespace DoubaoSeed3D
{
    /// <summary>
    /// Requested 3D model file format.<br/>
    /// Default Value: glb
    /// </summary>
    public enum CreateGenerationTaskRequestFileFormat
    {
        /// <summary>
        ///
        /// </summary>
        Fbx,
        /// <summary>
        ///
        /// </summary>
        Glb,
        /// <summary>
        ///
        /// </summary>
        Obj,
        /// <summary>
        ///
        /// </summary>
        Stl,
        /// <summary>
        ///
        /// </summary>
        Usdz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerationTaskRequestFileFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerationTaskRequestFileFormat value)
        {
            return value switch
            {
                CreateGenerationTaskRequestFileFormat.Fbx => "fbx",
                CreateGenerationTaskRequestFileFormat.Glb => "glb",
                CreateGenerationTaskRequestFileFormat.Obj => "obj",
                CreateGenerationTaskRequestFileFormat.Stl => "stl",
                CreateGenerationTaskRequestFileFormat.Usdz => "usdz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerationTaskRequestFileFormat? ToEnum(string value)
        {
            return value switch
            {
                "fbx" => CreateGenerationTaskRequestFileFormat.Fbx,
                "glb" => CreateGenerationTaskRequestFileFormat.Glb,
                "obj" => CreateGenerationTaskRequestFileFormat.Obj,
                "stl" => CreateGenerationTaskRequestFileFormat.Stl,
                "usdz" => CreateGenerationTaskRequestFileFormat.Usdz,
                _ => null,
            };
        }
    }
}