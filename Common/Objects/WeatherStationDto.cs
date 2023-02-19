namespace NWS.NET.Common.Objects;

public sealed record WeatherStationDto
{
	public double? Latitude { get; set; }
	public double? Longitude { get; set; }
	public double? Elevation { get; set; }
	public string? ElevationUnit { get; set; }
	public string? StationIdentifier { get; set; }
	public string? Name { get; set; }
	public string? TimeZone { get; set; }
}
