using NWS.NET.Api.Weather;

namespace NWS.NET.TestConsole;

internal class Program
{
	public static async Task Main(string[] args)
	{
		Console.WriteLine("Testing...");
		var service = new ApiWeatherService("NWS.NET.Testing");
		var response = await service.GetForecastAsync(47.6588, -117.4260);
		Console.WriteLine(response);
		var response2 = await service.GetCurrentConditionsAsync(47.6588, -117.4260);
		Console.WriteLine(response);
		var response3 = await service.GetCurrentConditionsForStationAsync("KGEG");
		Console.WriteLine(response);
	}
}
