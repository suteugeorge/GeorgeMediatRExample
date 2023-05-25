using mediatorAPI.Models;

namespace mediatorAPI.Protocol.Interfaces;

public interface IWeatherService
{
    Task<WeatherForecast[]> GetWeatherForecast();
}