using Newtonsoft.Json;

using System.Collections.Generic;

namespace KinopoiskNET.Core.DTO
{
    public record TvSeriesInfoList : KinopoiskDto
    {
        [JsonProperty("tv-series")]
        public List<TvSeriesInfo> TvSeries { get; init; }

        [JsonProperty("pagination")]
        public Pagination Pagination { get; init; }
    }
}
