using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Globalization;

namespace KinopoiskNET.Core.DTO.Converters
{
    internal abstract class Converter : JsonConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
