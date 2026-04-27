
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace DoubaoSeed3D
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::DoubaoSeed3D.JsonConverters.CreateGenerationTaskRequestSubdivisionLevelJsonConverter),

            typeof(global::DoubaoSeed3D.JsonConverters.CreateGenerationTaskRequestSubdivisionLevelNullableJsonConverter),

            typeof(global::DoubaoSeed3D.JsonConverters.CreateGenerationTaskRequestFileFormatJsonConverter),

            typeof(global::DoubaoSeed3D.JsonConverters.CreateGenerationTaskRequestFileFormatNullableJsonConverter),

            typeof(global::DoubaoSeed3D.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoubaoSeed3D.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoubaoSeed3D.CreateGenerationTaskRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::DoubaoSeed3D.GenerationContentItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoubaoSeed3D.GenerationContentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoubaoSeed3D.CreateGenerationTaskRequestSubdivisionLevel), TypeInfoPropertyName = "CreateGenerationTaskRequestSubdivisionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoubaoSeed3D.CreateGenerationTaskRequestFileFormat), TypeInfoPropertyName = "CreateGenerationTaskRequestFileFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoubaoSeed3D.GenerationTaskResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoubaoSeed3D.GenerationOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoubaoSeed3D.Usage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::DoubaoSeed3D.ApiError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::DoubaoSeed3D.GenerationContentItem>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}