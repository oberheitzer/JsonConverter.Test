using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonConverter.Test.Api.Converters
{
    public class ConverterFactory : JsonConverterFactory
    {
        public override bool CanConvert(Type typeToConvert)
        {
            //switch (Type.GetTypeCode(typeToConvert))
            //{
            //    case TypeCode.Int16:
            //    case TypeCode.Int32:
            //    case TypeCode.Int64:
            //    case TypeCode.Double:
            //    case TypeCode.Decimal:
            //        return true;
            //    default:
            //        return false;
            //}

            return true;
        }

        public override System.Text.Json.Serialization.JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
        {
            var type = typeToConvert.GetFields().Select(field => field.GetType()).ToList();

            throw new NotImplementedException();
        }
    }
}
