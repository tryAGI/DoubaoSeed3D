
#nullable enable

namespace DoubaoSeed3D
{
    public partial interface IDoubaoSeed3DClient
    {
        /// <summary>
        /// Authorize using bearer authentication.
        /// </summary>
        /// <param name="apiKey"></param>

        public void AuthorizeUsingBearer(
            string apiKey);
    }
}