namespace DoubaoSeed3D.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static DoubaoSeed3DClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("DOUBAOSEED3D_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("DOUBAOSEED3D_API_KEY environment variable is not found.");

        var client = new DoubaoSeed3DClient(apiKey);
        
        return client;
    }
}
