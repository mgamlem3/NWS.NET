namespace NWS.NET.NWS.Dtos.Components.PointsDto.PointsProperties;

public sealed record PointsProperties
{
	public string Id { get; set; }
	public string Type { get; set; }
	public string Cwa { get; set; }
	public Uri ForecastOffice { get; set; }
	public string GridId { get; set; }
	public double GridX { get; set; }
	public double GridY { get; set; }
	public Uri Forecast { get; set; }
	public Uri ForecastHourly { get; set; }
	public Uri ForecastGridData { get; set; }
	public Uri ObservationStations { get; set; }
	public RelativeLocation RelativeLocation { get; set; }
	public Uri ForecastZone { get; set; }
	public Uri County { get; set; }
	public Uri FireWeatherZone { get; set; }
	public string TimeZone { get; set; }
	public string RadarStation { get; set; }
}
