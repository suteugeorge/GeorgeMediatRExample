using mediatorAPI.Models;
using mediatorAPI.Protocol.Interfaces;
using mediatorAPI.Protocol.Requests;
using MediatR;

namespace mediatorAPI.BL.RequestHandler;

public class WeatherRequestHandler : IRequestHandler<GetWeatherRequest, WeatherForecast[]>
{
    private readonly IWeatherService _weatherService;

    public WeatherRequestHandler(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    public async Task<WeatherForecast[]> Handle(GetWeatherRequest request, CancellationToken cancellationToken)
    {
        return await _weatherService.GetWeatherForecast();
    }
}