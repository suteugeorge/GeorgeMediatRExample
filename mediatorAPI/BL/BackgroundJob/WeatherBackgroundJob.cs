using mediatorAPI.Models;
using mediatorAPI.Protocol.Interfaces;
using mediatorAPI.Protocol.Requests;

namespace mediatorAPI.BL.BackgroundJob;

public class WeatherBackgroundJob : IEventHandler<GetWeatherRequest, WeatherForecast[]>
{
    private readonly IWeatherRepository _weatherRepository;

    public WeatherBackgroundJob(IWeatherRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;
    }
    
    public Task HandledEventArgs(GetWeatherRequest request, WeatherForecast[] response, CancellationToken cancellationToken = default)
    {
        Thread.Sleep(5000);
        var location = _weatherRepository.GetLocations();
        var averageTemp = response.Select(f => f.TemperatureC).Average();
        
        return Task.CompletedTask;
    }
}