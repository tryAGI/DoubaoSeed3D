
#nullable enable

namespace DoubaoSeed3D
{
    /// <summary>
    /// Output mesh subdivision level.
    /// </summary>
    public enum CreateGenerationTaskRequestSubdivisionLevel
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateGenerationTaskRequestSubdivisionLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateGenerationTaskRequestSubdivisionLevel value)
        {
            return value switch
            {
                CreateGenerationTaskRequestSubdivisionLevel.High => "high",
                CreateGenerationTaskRequestSubdivisionLevel.Low => "low",
                CreateGenerationTaskRequestSubdivisionLevel.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateGenerationTaskRequestSubdivisionLevel? ToEnum(string value)
        {
            return value switch
            {
                "high" => CreateGenerationTaskRequestSubdivisionLevel.High,
                "low" => CreateGenerationTaskRequestSubdivisionLevel.Low,
                "medium" => CreateGenerationTaskRequestSubdivisionLevel.Medium,
                _ => null,
            };
        }
    }
}