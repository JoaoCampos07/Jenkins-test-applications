namespace UnitTests
{
    using System;

    using FluentAssertions;

    using WebApi.Services;

    using Xunit;

    public class UnitTest1
    {
        private readonly IWeatherService _weatherMicroservice;

        public UnitTest1()
        {
            _weatherMicroservice = new WeatherService();
        }

        [Fact]
        public void WhenCalling_GetWeatherForeacast_ShouldReturn_ForeacastForDaysOfTheWeek()
        {
            var result = _weatherMicroservice.GetWeatherForecast();

            result.Should().NotBeNull();
            result.Should().HaveCountGreaterThan(1);
        }
    }
}
