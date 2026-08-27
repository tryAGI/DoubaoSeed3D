
#nullable enable

namespace DoubaoSeed3D
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GenerationTaskResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_id")]
        public string? TaskId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public long? UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public global::DoubaoSeed3D.GenerationOutput? Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::DoubaoSeed3D.GenerationContentItem>? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::DoubaoSeed3D.Usage? Usage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::DoubaoSeed3D.ApiError? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationTaskResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="taskId"></param>
        /// <param name="model"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="output"></param>
        /// <param name="content"></param>
        /// <param name="usage"></param>
        /// <param name="error"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerationTaskResponse(
            string? id,
            string? taskId,
            string? model,
            string? status,
            long? createdAt,
            long? updatedAt,
            global::DoubaoSeed3D.GenerationOutput? output,
            global::System.Collections.Generic.IList<global::DoubaoSeed3D.GenerationContentItem>? content,
            global::DoubaoSeed3D.Usage? usage,
            global::DoubaoSeed3D.ApiError? error)
        {
            this.Id = id;
            this.TaskId = taskId;
            this.Model = model;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Output = output;
            this.Content = content;
            this.Usage = usage;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerationTaskResponse" /> class.
        /// </summary>
        public GenerationTaskResponse()
        {
        }

    }
}