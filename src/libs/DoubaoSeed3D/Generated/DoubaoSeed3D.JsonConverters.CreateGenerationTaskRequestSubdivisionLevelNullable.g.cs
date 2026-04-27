#nullable enable

namespace DoubaoSeed3D.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateGenerationTaskRequestSubdivisionLevelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DoubaoSeed3D.CreateGenerationTaskRequestSubdivisionLevel?>
    {
        /// <inheritdoc />
        public override global::DoubaoSeed3D.CreateGenerationTaskRequestSubdivisionLevel? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::DoubaoSeed3D.CreateGenerationTaskRequestSubdivisionLevelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DoubaoSeed3D.CreateGenerationTaskRequestSubdivisionLevel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DoubaoSeed3D.CreateGenerationTaskRequestSubdivisionLevel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DoubaoSeed3D.CreateGenerationTaskRequestSubdivisionLevel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::DoubaoSeed3D.CreateGenerationTaskRequestSubdivisionLevelExtensions.ToValueString(value.Value));
            }
        }
    }
}
