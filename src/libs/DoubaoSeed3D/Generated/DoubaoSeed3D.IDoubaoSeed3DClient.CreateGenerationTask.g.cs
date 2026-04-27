#nullable enable

namespace DoubaoSeed3D
{
    public partial interface IDoubaoSeed3DClient
    {
        /// <summary>
        /// Create a Seed3D generation task<br/>
        /// Submit an asynchronous Doubao Seed3D generation task. Image input is<br/>
        /// represented as a content item with type `input_image` and an `image_url`.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoubaoSeed3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DoubaoSeed3D.GenerationTaskResponse> CreateGenerationTaskAsync(

            global::DoubaoSeed3D.CreateGenerationTaskRequest request,
            global::DoubaoSeed3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a Seed3D generation task<br/>
        /// Submit an asynchronous Doubao Seed3D generation task. Image input is<br/>
        /// represented as a content item with type `input_image` and an `image_url`.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::DoubaoSeed3D.GenerationTaskResponse> CreateGenerationTaskAsync(
            global::System.Collections.Generic.IList<global::DoubaoSeed3D.GenerationContentItem> content,
            string model = "doubao-seed3d-1-0-250928",
            global::DoubaoSeed3D.CreateGenerationTaskRequestSubdivisionLevel? subdivisionLevel = default,
            global::DoubaoSeed3D.CreateGenerationTaskRequestFileFormat? fileFormat = default,
            long? seed = default,
            global::DoubaoSeed3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}