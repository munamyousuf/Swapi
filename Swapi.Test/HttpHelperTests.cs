using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Swapi.Data.Contracts;
using Swapi.Data.Helpers;
using System.Threading.Tasks;

namespace Swapi.Test
{
    [TestClass]
    public class HttpHelperTests
    {
        [TestMethod]
        public async Task GetJsonResponse_ValidDataPeople_Returnstring()
        {
            IHttpHelper _helper = new HttpHelper("https://swapi.co/api/");
            var expected = true;

            var entity = "people";
            var id = 1;

            var jsonString = await _helper.GetJsonResponse(entity, id);

            var actual = !string.IsNullOrWhiteSpace(jsonString);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public async Task GetJsonResponse_ValidDataFilms_Returnstring()
        {
            IHttpHelper _helper = new HttpHelper("https://swapi.co/api/");
            var expected = true;

            var entity = "films";
            var id = 2;

            var jsonString = await _helper.GetJsonResponse(entity, id);

            var actual = !string.IsNullOrWhiteSpace(jsonString);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public async Task GetJsonResponse_ValidDataStarships_Returnstring()
        {
            IHttpHelper _helper = new HttpHelper("https://swapi.co/api/");
            var expected = true;

            var entity = "starships";
            var id = 12;

            var jsonString = await _helper.GetJsonResponse(entity, id);

            var actual = !string.IsNullOrWhiteSpace(jsonString);
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public async Task GetJsonResponse_InvalidEntity_ReturnsEmptyString()
        {
            IHttpHelper _helper = new HttpHelper("https://swapi.co/api/");
            bool expected = true;

            var entity = "peoples";
            var id = 1;

            var jsonString = await _helper.GetJsonResponse(entity, id);

            bool actual = string.IsNullOrWhiteSpace(jsonString);
            Assert.AreEqual(expected, actual);

        }
    }
}
