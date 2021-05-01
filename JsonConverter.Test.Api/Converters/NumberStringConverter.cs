using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonConverter.Test.Api.Converters
{
    public class NumberStringConverter : JsonConverter<int>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            switch (Type.GetTypeCode(typeToConvert))
            {
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Double:
                case TypeCode.Decimal:
                    return true;
                default:
                    return false;
            }
        }

        public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Number)
            {
                if (reader.TryGetInt16(out short shortValue) && Type.GetTypeCode(typeToConvert) == TypeCode.Int16)
                    return shortValue;

                if (reader.TryGetInt32(out int number) && Type.GetTypeCode(typeToConvert) != TypeCode.Int16)
                    return number;

                //if (reader.TryGetDouble(out double fraction))
                    //return fraction;
            }

            if (reader.TokenType == JsonTokenType.String)
            {
                var str = reader.GetString();

                if (short.TryParse(str, out short shortValue) && Type.GetTypeCode(typeToConvert) == TypeCode.Int16)
                    return shortValue;

                if (int.TryParse(str, out var number) && Type.GetTypeCode(typeToConvert) != TypeCode.Int16)
                    return number;

                //if (double.TryParse(str, out double fraction))
                    // return fraction;
            }

            var strg = reader.GetString();
            return reader.GetInt32();

            // throw new JsonException();

            //var str = reader.GetString();

            //return str;
        }

        public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
