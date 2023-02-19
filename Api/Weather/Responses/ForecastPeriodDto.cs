namespace NWS.NET.Api.Weather;

/// <summary>
/// Represents a weather forecast for a defined period of time.
/// </summary>
public sealed record ForecastPeriodDto
{
	public uint? Number { get; set; }
	public string? Name { get; set; }
	public DateTime? StartTime { get; set; }
	public DateTime? EndTime { get; set; }
	public bool? IsDayTime { get; set; }
	public double? Temperature { get; set; }
	public string? TemperatureUnit { get; set; }
	public string? TemperatureTrend { get; set; }
	public double? WindSpeed { get; set; }
	public string? WindSpeedUnit { get; set; }
	public string? WindDirection { get; set; }
	public string? ShortForecastDescription { get; set; }
	public string? LongForecastDescription { get; set; }
}
