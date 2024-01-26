using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Controllers;

namespace MSTest.WeatherForecastTests
{
    [TestClass]
    public class WeatherForecastControllerTests
    {
        private WeatherForecastController _controller;

        [TestInitialize]
        public void Setup()
        {
            _controller = new WeatherForecastController(new NullLogger<WeatherForecastController>());
        }

        [TestMethod]
        public void Get_ReturnsFiveWeatherForecasts()
        {
            var result = _controller.Get();
            Assert.AreEqual(5, result.Count(), "Should return 5 weather forecasts.");
        }

        [TestMethod]
        public void Get_ReturnsForecasts_WithinTemperatureRange()
        {
            var result = _controller.Get();
            Assert.IsTrue(result.All(forecast => forecast.TemperatureC >= -20 && forecast.TemperatureC <= 55), "All temperatures should be within the range -20 to 55.");
        }

        [TestMethod]
        public void Get_ReturnsForecasts_WithValidSummaries()
        {
            var validSummaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
            var result = _controller.Get();
            Assert.IsTrue(result.All(forecast => validSummaries.Contains(forecast.Summary)), "All summaries should be valid.");
        }

        [TestMethod]
        public void Get_ReturnsForecasts_WithFutureDates()
        {
            var result = _controller.Get();
            var today = DateOnly.FromDateTime(DateTime.Now);
            Assert.IsTrue(result.All(forecast => forecast.Date > today), "All dates should be in the future.");
        }

        [TestMethod]
        public void Get_WithNullLogger_DoesNotThrowException()
        {
            var controllerWithNullLogger = new WeatherForecastController(null);
            var result = controllerWithNullLogger.Get();
            Assert.IsNotNull(result, "Method should handle null logger without throwing exceptions.");
        }
    }
}
