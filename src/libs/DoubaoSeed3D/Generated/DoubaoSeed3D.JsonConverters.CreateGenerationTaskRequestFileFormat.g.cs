#nullable enable

namespace DoubaoSeed3D.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateGenerationTaskRequestFileFormatJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::DoubaoSeed3D.CreateGenerationTaskRequestFileFormat>
    {
        /// <inheritdoc />
        public override global::DoubaoSeed3D.CreateGenerationTaskRequestFileFormat Read(
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
                        return global::DoubaoSeed3D.CreateGenerationTaskRequestFileFormatExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::DoubaoSeed3D.CreateGenerationTaskRequestFileFormat)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::DoubaoSeed3D.CreateGenerationTaskRequestFileFormat);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::DoubaoSeed3D.CreateGenerationTaskRequestFileFormat value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::DoubaoSeed3D.CreateGenerationTaskRequestFileFormatExtensions.ToValueString(value));
        }
    }
}
