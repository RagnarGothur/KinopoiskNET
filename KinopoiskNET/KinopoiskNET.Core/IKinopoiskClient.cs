using KinopoiskNET.Core.DTO;

using System.Collections.Generic;

namespace KinopoiskNET.Core
{
    public interface IKinopoiskClient
    {
        public TvSeriesInfo GetTvSeries(string id);
        public MovieInfo GetMovie(string id);

        public List<TvSeriesInfo> GetTvSeries(int page = 1);
        public List<MovieInfo> GetMovies(int page = 1);
    }
}
