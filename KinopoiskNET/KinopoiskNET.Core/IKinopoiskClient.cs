using KinopoiskNET.Core.DTO;

using System.Threading.Tasks;

namespace KinopoiskNET.Core
{
    public interface IKinopoiskClient
    {
        public Task<MovieInfo> GetMovieByIdAsync(string id);
        public Task<MovieInfoList> GetMoviesListAsync(int page = 1);

        public Task<TvSeriesInfo> GetTvSeriesByIdAsync(string id);
        public Task<TvSeriesInfoList> GetTvSeriesListAsync(int page = 1);
    }
}
