using Newtonsoft.Json;

using System.Collections.Generic;

namespace KinopoiskNET.Core.DTO
{
    public record MovieInfoList : KinopoiskDto
    {
        [JsonProperty("movies")]
        public List<MovieInfo> Movies { get; init; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; init; }
    }
}
