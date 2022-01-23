using System;
using System.Collections.Generic;
using System.Text;
using Bartok.BusinessLogic.Models;

namespace Bartok.BusinessLogic.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GenerateRandomForecasts();
    }
}
