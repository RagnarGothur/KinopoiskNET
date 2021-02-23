using Newtonsoft.Json;

namespace KinopoiskNET.Core.DTO
{
    public abstract record KinopoiskDto
    {
        [JsonProperty("error")]
        public KinopoiskError Error { get; init; }

        public bool IsErroneous { get => Error != null; }
    }
}
