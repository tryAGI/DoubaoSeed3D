
#nullable enable

namespace DoubaoSeed3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerationTaskRequest
    {
        /// <summary>
        /// Doubao Seed3D model identifier provisioned in Volcano Ark.<br/>
        /// Default Value: doubao-seed3d-1-0-250928
        /// </summary>
        /// <default>"doubao-seed3d-1-0-250928"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; } = "doubao-seed3d-1-0-250928";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::DoubaoSeed3D.GenerationContentItem> Content { get; set; }

        /// <summary>
        /// Output mesh subdivision level.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subdivision_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DoubaoSeed3D.JsonConverters.CreateGenerationTaskRequestSubdivisionLevelJsonConverter))]
        public global::DoubaoSeed3D.CreateGenerationTaskRequestSubdivisionLevel? SubdivisionLevel { get; set; }

        /// <summary>
        /// Requested 3D model file format.<br/>
        /// Default Value: glb
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::DoubaoSeed3D.JsonConverters.CreateGenerationTaskRequestFileFormatJsonConverter))]
        public global::DoubaoSeed3D.CreateGenerationTaskRequestFileFormat? FileFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public long? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerationTaskRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// Doubao Seed3D model identifier provisioned in Volcano Ark.<br/>
        /// Default Value: doubao-seed3d-1-0-250928
        /// </param>
        /// <param name="content"></param>
        /// <param name="subdivisionLevel">
        /// Output mesh subdivision level.
        /// </param>
        /// <param name="fileFormat">
        /// Requested 3D model file format.<br/>
        /// Default Value: glb
        /// </param>
        /// <param name="seed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerationTaskRequest(
            string model,
            global::System.Collections.Generic.IList<global::DoubaoSeed3D.GenerationContentItem> content,
            global::DoubaoSeed3D.CreateGenerationTaskRequestSubdivisionLevel? subdivisionLevel,
            global::DoubaoSeed3D.CreateGenerationTaskRequestFileFormat? fileFormat,
            long? seed)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.SubdivisionLevel = subdivisionLevel;
            this.FileFormat = fileFormat;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerationTaskRequest" /> class.
        /// </summary>
        public CreateGenerationTaskRequest()
        {
        }
    }
}