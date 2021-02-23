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
            Assert.AreEqual("�����������", result.Title);
            Assert.AreEqual("The Gentlemen", result.TitleAlternative);
            Assert.AreEqual("�Criminal. Class�", result.Tagline);
            Assert.AreEqual(2019, result.Year);

            Assert.IsNotNull(result.Actors);
            Assert.Contains("������ ���������", result.Actors);

            Assert.IsNotNull(result.Countries);
            Assert.Contains("���", result.Countries);

            Assert.IsNotNull(result.Genres);
            Assert.Contains("�������", result.Genres);

            Assert.IsNotNull(result.Directors);
            Assert.Contains("��� ����", result.Directors);

            Assert.IsNotNull(result.Screenwriters);
            Assert.Contains("����� ��������", result.Screenwriters);

            Assert.IsNotNull(result.Producers);
            Assert.Contains("���� ����", result.Producers);

            Assert.IsNotNull(result.Operators);
            Assert.Contains("���� ������", result.Operators);

            Assert.IsNotNull(result.Composers);
            Assert.Contains("��������� �������", result.Composers);

            Assert.IsNotNull(result.Painters);
            Assert.Contains("������ �������", result.Painters);

            Assert.IsNotNull(result.Editors);
            Assert.Contains("������ �������", result.Editors);
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
            Assert.AreEqual("����� ������� �������� ������", result.Title);
            Assert.AreEqual(1979, result.Year);
            Assert.AreEqual(1, result.Seasons);

            Assert.IsNotNull(result.Actors);
            Assert.Contains("�������� ��������", result.Actors);

            Assert.IsNotNull(result.Countries);
            Assert.Contains("����", result.Countries);

            Assert.IsNotNull(result.Genres);
            Assert.Contains("��������", result.Genres);

            Assert.IsNotNull(result.Directors);
            Assert.Contains("��������� ���������", result.Directors);

            Assert.IsNotNull(result.Screenwriters);
            Assert.Contains("������� ������", result.Screenwriters);

            Assert.IsNotNull(result.Operators);
            Assert.Contains("������ �������", result.Operators);

            Assert.IsNotNull(result.Composers);
            Assert.Contains("������� ��������", result.Composers);

            Assert.IsNotNull(result.Painters);
            Assert.Contains("�������� ���������", result.Painters);

            Assert.IsNotNull(result.Editors);
            Assert.Contains("��������� �������", result.Editors);
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