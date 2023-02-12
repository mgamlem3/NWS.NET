using NWS.NET.Api.Weather;

internal class Program
{
	public static async Task Main(string[] args)
	{
		Console.WriteLine("Testing...");
		var service = new ApiWeatherService("NWS.NET.Testing");
		var response = await service.GetForecastAsync(47.6588, -117.4260);
		Console.WriteLine(response);
	}
}
