using NWS.NET.Api.Weather;

namespace NWS.NET.Api.Tests;

public class WeatherApiTests
{
	[Theory]
    [InlineData(47.6588, 117.4260)]
	public void Test1(double latitude, double longitude)
	{
		var service = new ApiWeatherService();
		var response = service.GetForecastAsync(latitude, longitude);
		Assert.NotNull(response);
	}
}
