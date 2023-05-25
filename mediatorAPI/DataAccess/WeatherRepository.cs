using mediatorAPI.Protocol.Interfaces;

namespace mediatorAPI.DataAccess;

public class WeatherRepository : IWeatherRepository
{
    public List<string> GetLocations()
    {
        return new List<string>
        {
            "London",
            "Paris",
            "New York",
            "Moscow",
            "Berlin",
            "Madrid",
            "Rome",
            "Amsterdam",
            "Ottawa",
            "Tokyo",
            "Beijing",
            "Seoul",
            "Hong Kong",
            "Sydney",
            "Melbourne",
            "Cairo",
            "Cape Town",
            "Rio de Janeiro",
            "Mexico City",
            "Buenos Aires",
            "Santiago",
            "Lima",
            "Bogota",
            "Mumbai",
            "New Delhi",
            "Bangkok",
            "Jakarta",
            "Singapore",
            "Kuala Lumpur",
            "Hanoi",
            "Manila",
            "Ho Chi Minh City",
            "Seoul",
            "Istanbul",
            "Cluj-Napoca",
        };
    }
}