using NWS.Dtos.Components.Common;

namespace NWS.Dtos.Components.StationDto;

public sealed record StationFeatureProperties
{
	public string? Id { get; set; }
	public string? Type { get; set; }
	public Elevation? Elevation { get; set; }
	public string? StationIdentifier { get; set; }
	public string? Name { get; set; }
	public string? TimeZone { get; set; }
	public Uri? Forecast { get; set; }
	public Uri? County { get; set; }
	public Uri? FireWeatherZone { get; set; }
}
