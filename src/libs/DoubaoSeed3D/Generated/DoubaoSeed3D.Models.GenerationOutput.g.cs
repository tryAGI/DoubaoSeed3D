
#nullable enable

namespace DoubaoSeed3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_url")]
        public string? ModelUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationOutput" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="fileUrl"></param>
        /// <param name="modelUrl"></param>
        /// <param name="imageUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationOutput(
            string? url,
            string? fileUrl,
            string? modelUrl,
            string? imageUrl)
        {
            this.Url = url;
            this.FileUrl = fileUrl;
            this.ModelUrl = modelUrl;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationOutput" /> class.
        /// </summary>
        public GenerationOutput()
        {
        }

    }
}