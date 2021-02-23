using KinopoiskNET.Core.DTO.Converters;

using Newtonsoft.Json;

using System;
using System.Collections.Generic;

namespace KinopoiskNET.Core.DTO
{
    public record MovieInfo : KinopoiskDto
    {
        [JsonProperty("id")]
        public long Id { get; init; }

        [JsonProperty("id_kinopoisk")]
        public long IdKinopoisk { get; init; }

        [JsonProperty("url")]
        public string Url { get; init; }

        [JsonProperty("type")]
        public string Type { get; init; }

        [JsonProperty("title")]
        public string Title { get; init; }

        [JsonProperty("title_alternative")]
        public string TitleAlternative { get; init; }

        [JsonProperty("tagline")]
        public string Tagline { get; init; }

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
        public List<string> Producers { get; init; }

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
        public double RatingKinopoisk { get; init; }

        [JsonProperty("rating_imdb")]
        public double RatingImdb { get; init; }

        [JsonProperty("kinopoisk_votes")]
        public object KinopoiskVotes { get; init; }

        [JsonProperty("imdb_votes")]
        public object ImdbVotes { get; init; }

        [JsonProperty("fees_world")]
        public string FeesWorld { get; init; }

        [JsonProperty("fees_russia")]
        public object FeesRussia { get; init; }

        [JsonProperty("premiere_world")]
        public string PremiereWorld { get; init; }

        [JsonProperty("premiere_russia")]
        public string PremiereRussia { get; init; }

        [JsonProperty("frames")]
        public List<Uri> Frames { get; init; }

        [JsonProperty("screenshots")]
        public object Screenshots { get; init; }

        [JsonProperty("videocdn")]
        public MovieCollapse Videocdn { get; init; }

        [JsonProperty("hdvb")]
        public MovieCollapse Hdvb { get; init; }

        [JsonProperty("collapse")]
        public MovieCollapse Collapse { get; init; }

        [JsonProperty("kodik")]
        public MovieCollapse Kodik { get; init; }

        public static MovieInfo FromJson(string json) => JsonConvert.DeserializeObject<MovieInfo>(json, Converter.Settings);
    }

    public partial class MovieCollapse
    {
        [JsonProperty("url")]
        public List<string> Url { get; init; }

        [JsonProperty("quality")]
        public List<string> Quality { get; init; }

        [JsonProperty("duration")]
        public List<string> Duration { get; init; }

        [JsonProperty("voice")]
        public List<string> Voice { get; init; }
    }

    public static partial class Serialize
    {
        public static string ToJson(this MovieInfo self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}
