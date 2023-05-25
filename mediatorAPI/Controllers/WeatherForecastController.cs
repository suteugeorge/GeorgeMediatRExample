using mediatorAPI.Protocol.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace mediatorAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IMediator _mediator;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<IActionResult> Get([FromQuery]GetWeatherRequest request)
    {
        var response = await _mediator.Send(request);

        return Ok(response);
    }
}