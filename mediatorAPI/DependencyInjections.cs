using mediatorAPI.BL.BackgroundJob;
using mediatorAPI.BL.Services;
using mediatorAPI.DataAccess;
using mediatorAPI.Models;
using mediatorAPI.Protocol.Interfaces;
using mediatorAPI.Protocol.Requests;

namespace mediatorAPI;

public static class DependencyInjections
{
    //static method to add dependency injections to service builder
    public static void AddDependencyInjections(IServiceCollection services)
    {
        //add weather service
        services.AddScoped<IWeatherService, WeatherService>();
        services.AddScoped<IWeatherRepository, WeatherRepository>();

        services.AddScoped<IEventHandler<GetWeatherRequest, WeatherForecast[]>, WeatherBackgroundJob>();
    
        services.AddTransient<EventDispatcher>();
    }
}