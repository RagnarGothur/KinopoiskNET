using Newtonsoft.Json;

using System;

namespace KinopoiskNET.Core.DTO.Converters
{
    internal class LongConverter : Converter
    {
        public static readonly LongConverter Singleton = new LongConverter();

        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;

            var value = serializer.Deserialize<string>(reader);
            if (Int64.TryParse(value, out long parsed))
                return parsed;

            throw new JsonException($"Cannot unmarshal {value} to long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }
    }
}
