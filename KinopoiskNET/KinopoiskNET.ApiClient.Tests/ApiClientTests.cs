using KinopoiskNET.ApiClient;

using NUnit.Framework;

using System.Threading.Tasks;

namespace KinopoiskNET.Tests
{
    public class Tests
    {
        private KinopoiskApiClient _apiClient;

        [SetUp]
        public void Setup()
        {
            _apiClient = new KinopoiskApiClient(Secrets.TOKEN);
        }

        [Test]
        public async Task TestGetMovieByIdAsync()
        {
            var result = await _apiClient.GetMovieByIdAsync("1143242");

            Assert.IsFalse(result.IsErroneous);

            Assert.AreEqual(1143242, result.IdKinopoisk);
            Assert.AreEqual("movie", result.Type);
            Assert.AreEqual("Джентльмены", result.Title);
            Assert.AreEqual("The Gentlemen", result.TitleAlternative);
            Assert.AreEqual("«Criminal. Class»", result.Tagline);
            Assert.AreEqual(2019, result.Year);

            Assert.IsNotNull(result.Actors);
            Assert.Contains("Мэттью МакКонахи", result.Actors);

            Assert.IsNotNull(result.Countries);
            Assert.Contains("США", result.Countries);

            Assert.IsNotNull(result.Genres);
            Assert.Contains("Комедия", result.Genres);

            Assert.IsNotNull(result.Directors);
            Assert.Contains("Гай Ричи", result.Directors);

            Assert.IsNotNull(result.Screenwriters);
            Assert.Contains("Айван Эткинсон", result.Screenwriters);

            Assert.IsNotNull(result.Producers);
            Assert.Contains("Билл Блок", result.Producers);

            Assert.IsNotNull(result.Operators);
            Assert.Contains("Алан Стюарт", result.Operators);

            Assert.IsNotNull(result.Composers);
            Assert.Contains("Кристофер Бенстед", result.Composers);

            Assert.IsNotNull(result.Painters);
            Assert.Contains("Джемма Джексон", result.Painters);

            Assert.IsNotNull(result.Editors);
            Assert.Contains("Джеймс Херберт", result.Editors);
        }

        [Test]
        public async Task TestGetMoviesListAsync()
        {
            var result = await _apiClient.GetMoviesListAsync(1);

            Assert.IsFalse(result.IsErroneous);

            Assert.IsNotNull(result.Movies);
            Assert.IsNotEmpty(result.Movies);
            Assert.IsNotNull(result.Pagination);
            Assert.Greater(result.Pagination.TotalPages, 1);
        }

        [Test]
        public async Task TestGetTvSeriesByIdAsync()
        {
            var result = await _apiClient.GetTvSeriesByIdAsync("77202");

            Assert.IsFalse(result.IsErroneous);

            Assert.AreEqual(77202, result.IdKinopoisk);
            Assert.AreEqual("tv-series", result.Type);
            Assert.AreEqual("Место встречи изменить нельзя", result.Title);
            Assert.AreEqual(1979, result.Year);
            Assert.AreEqual(1, result.Seasons);

            Assert.IsNotNull(result.Actors);
            Assert.Contains("Владимир Высоцкий", result.Actors);

            Assert.IsNotNull(result.Countries);
            Assert.Contains("СССР", result.Countries);

            Assert.IsNotNull(result.Genres);
            Assert.Contains("Криминал", result.Genres);

            Assert.IsNotNull(result.Directors);
            Assert.Contains("Станислав Говорухин", result.Directors);

            Assert.IsNotNull(result.Screenwriters);
            Assert.Contains("Аркадий Вайнер", result.Screenwriters);

            Assert.IsNotNull(result.Operators);
            Assert.Contains("Леонид Бурлака", result.Operators);

            Assert.IsNotNull(result.Composers);
            Assert.Contains("Евгений Геворгян", result.Composers);

            Assert.IsNotNull(result.Painters);
            Assert.Contains("Валентин Гидулянов", result.Painters);

            Assert.IsNotNull(result.Editors);
            Assert.Contains("Валентина Олейник", result.Editors);
        }

        [Test]
        public async Task TestGetTvSeriesListAsync()
        {
            var result = await _apiClient.GetTvSeriesListAsync(1);

            Assert.IsFalse(result.IsErroneous);

            Assert.IsNotNull(result.TvSeries);
            Assert.IsNotEmpty(result.TvSeries);
            Assert.IsNotNull(result.Pagination);
            Assert.Greater(result.Pagination.TotalPages, 1);
        }
    }
}