using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bartok.BusinessLogic.Models;
using Bartok.BusinessLogic.Interfaces;

namespace Bartok.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastController(IWeatherForecastService weatherForecastService, ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var forecasts = _weatherForecastService.GenerateRandomForecasts();
            return forecasts;
        }
    }
}
