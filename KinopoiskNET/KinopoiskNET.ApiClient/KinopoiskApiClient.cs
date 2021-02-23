using KinopoiskNET.Core;
using KinopoiskNET.Core.DTO;

using RestSharp;

using System.Net;
using System.Threading.Tasks;

namespace KinopoiskNET.ApiClient
{
    public class KinopoiskApiClient : IKinopoiskClient
    {
        const string BASE_URL = "https://api.kinopoisk.cloud";

        private readonly RestClient _restClient;

        public IWebProxy Proxy
        {
            get => _restClient.Proxy;
            set => _restClient.Proxy = value;
        }

        public KinopoiskApiClient(string token)
        {
            _restClient = new RestClient(BASE_URL);
            _restClient.Authenticator = new TokenBasedAuthenticator(token);
        }

        public async Task<MovieInfo> GetMovieByIdAsync(string id)
        {
            var request = new RestRequest($"movies/{id}");

            return await _restClient.GetAsync<MovieInfo>(request);
        }

        public async Task<MovieInfoList> GetMoviesListAsync(int page = 1)
        {
            var request = new RestRequest($"movies/all/page/{page}");

            return await _restClient.GetAsync<MovieInfoList>(request);
        }

        public async Task<TvSeriesInfo> GetTvSeriesByIdAsync(string id)
        {
            var request = new RestRequest($"tv-series/{id}");

            return await _restClient.GetAsync<TvSeriesInfo>(request);
        }

        public async Task<TvSeriesInfoList> GetTvSeriesListAsync(int page = 1)
        {
            var request = new RestRequest($"tv-series/all/page/{page}");

            return await _restClient.GetAsync<TvSeriesInfoList>(request);
        }
    }
}
