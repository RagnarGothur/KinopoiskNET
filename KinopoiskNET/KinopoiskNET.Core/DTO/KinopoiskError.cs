using Newtonsoft.Json;

namespace KinopoiskNET.Core.DTO
{
    public record KinopoiskError
    {
        [JsonProperty("code")]
        public int Code { get; init; }

        [JsonProperty("message")]
        public string Message { get; init; }
    }
}
