#nullable enable

namespace DoubaoSeed3D
{
    public partial interface IDoubaoSeed3DClient
    {
        /// <summary>
        /// Get a Seed3D generation task
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoubaoSeed3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DoubaoSeed3D.GenerationTaskResponse> GetGenerationTaskAsync(
            string taskId,
            global::DoubaoSeed3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get a Seed3D generation task
        /// </summary>
        /// <param name="taskId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::DoubaoSeed3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::DoubaoSeed3D.AutoSDKHttpResponse<global::DoubaoSeed3D.GenerationTaskResponse>> GetGenerationTaskAsResponseAsync(
            string taskId,
            global::DoubaoSeed3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}