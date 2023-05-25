using mediatorAPI.Models;
using MediatR;

namespace mediatorAPI.Protocol.Requests;

public class GetWeatherRequest : IRequest<WeatherForecast[]>
{
    public string LocationName { get; set; }
}