using Newtonsoft.Json;

using System;

namespace KinopoiskNET.Core.DTO
{
    public record Pagination
    {
        [JsonProperty("current_page")]
        public Uri CurrentPage { get; init; }

        [JsonProperty("end_page")]
        public bool EndPage { get; init; }

        [JsonProperty("total_pages")]
        public long TotalPages { get; init; }
    }
}
