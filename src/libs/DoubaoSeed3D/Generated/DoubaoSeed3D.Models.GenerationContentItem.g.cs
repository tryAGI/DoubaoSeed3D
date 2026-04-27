
#nullable enable

namespace DoubaoSeed3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenerationContentItem
    {
        /// <summary>
        /// Content item type, such as input_image or text.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentItem" /> class.
        /// </summary>
        /// <param name="type">
        /// Content item type, such as input_image or text.
        /// </param>
        /// <param name="imageUrl"></param>
        /// <param name="text"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationContentItem(
            string type,
            string? imageUrl,
            string? text)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ImageUrl = imageUrl;
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationContentItem" /> class.
        /// </summary>
        public GenerationContentItem()
        {
        }
    }
}