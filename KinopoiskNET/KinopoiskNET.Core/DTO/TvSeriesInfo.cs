using KinopoiskNET.Core.DTO.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KinopoiskNET.Core.DTO
{
    public record TvSeriesInfo : KinopoiskDto
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(LongConverter))]
        public long Id { get; init; }

        [JsonProperty("id_kinopoisk")]
        [JsonConverter(typeof(LongConverter))]
        public long IdKinopoisk { get; init; }

        [JsonProperty("url")]
        public string Url { get; init; }

        [JsonProperty("type")]
        public string Type { get; init; }

        [JsonProperty("title")]
        public string Title { get; init; }

        [JsonProperty("title_alternative")]
        public object TitleAlternative { get; init; }

        [JsonProperty("tagline")]
        public object Tagline { get; init; }

        [JsonProperty("description")]
        public string Description { get; init; }

        [JsonProperty("year")]
        public long Year { get; init; }

        [JsonProperty("poster")]
        public string Poster { get; init; }

        [JsonProperty("trailer")]
        public Uri Trailer { get; init; }

        [JsonProperty("age")]
        public string Age { get; init; }

        [JsonProperty("actors")]
        public List<string> Actors { get; init; }

        [JsonProperty("countries")]
        public List<string> Countries { get; init; }

        [JsonProperty("genres")]
        public List<string> Genres { get; init; }

        [JsonProperty("directors")]
        public List<string> Directors { get; init; }

        [JsonProperty("screenwriters")]
        public List<string> Screenwriters { get; init; }

        [JsonProperty("producers")]
        public object Producers { get; init; }

        [JsonProperty("operators")]
        public List<string> Operators { get; init; }

        [JsonProperty("composers")]
        public List<string> Composers { get; init; }

        [JsonProperty("painters")]
        public List<string> Painters { get; init; }

        [JsonProperty("editors")]
        public List<string> Editors { get; init; }

        [JsonProperty("budget")]
        public object Budget { get; init; }

        [JsonProperty("rating_kinopoisk")]
        [JsonConverter(typeof(LongConverter))]
        public long RatingKinopoisk { get; init; }

        [JsonProperty("rating_imdb")]
        public string RatingImdb { get; init; }

        [JsonProperty("kinopoisk_votes")]
        public object KinopoiskVotes { get; init; }

        [JsonProperty("imdb_votes")]
        public object ImdbVotes { get; init; }

        [JsonProperty("fees_world")]
        public object FeesWorld { get; init; }

        [JsonProperty("fees_russia")]
        public object FeesRussia { get; init; }

        [JsonProperty("premiere_world")]
        public string PremiereWorld { get; init; }

        [JsonProperty("premiere_russia")]
        public object PremiereRussia { get; init; }

        [JsonProperty("frames")]
        public List<Uri> Frames { get; init; }

        [JsonProperty("screenshots")]
        public List<Uri> Screenshots { get; init; }

        [JsonProperty("seasons")]
        public long Seasons { get; init; }

        [JsonProperty("videocdn")]
        public TvSeriesCollapse Videocdn { get; init; }

        [JsonProperty("hdvb")]
        public TvSeriesCollapse Hdvb { get; init; }

        [JsonProperty("collapse")]
        public TvSeriesCollapse Collapse { get; init; }

        [JsonProperty("kodik")]
        public TvSeriesCollapse Kodik { get; init; }

        public static TvSeriesInfo FromJson(string json) => JsonConvert.DeserializeObject<TvSeriesInfo>(json, Converter.Settings);
    }

    public partial class TvSeriesCollapse
    {
        [JsonProperty("url")]
        public List<string> Url { get; init; }

        [JsonProperty("quality")]
        public List<string> Quality { get; init; }

        [JsonProperty("duration")]
        public List<string> Duration { get; init; }

        [JsonProperty("voice")]
        public List<string> Voice { get; init; }

        [JsonProperty("seasons")]
        public object Seasons { get; init; }

        [JsonProperty("episodes")]
        public object Episodes { get; init; }
    }

    public static partial class Serialize
    {
        public static string ToJson(this TvSeriesInfo self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
