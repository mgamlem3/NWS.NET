using NWS.NET.Common.Enums.Units;

namespace NWS.NET.Api.Weather;

/// <summary>
/// Represents a weather forecast for a defined period of time.
/// </summary>
public sealed record ForecastPeriod
{
	public uint? Number { get; set; }
	public string? Name { get; set; }
	public DateTime? StartTime { get; set; }
	public DateTime? EndTime { get; set; }
	public bool? IsDayTime { get; set; }
	public double? Temperature { get; set; }
	public TemperatureEnum? TemperatureUnit { get; set; }
	public string? TemperatureTrend { get; set; }
	public double? WindSpeed { get; set; }
	public VelocityEnum? WindSpeedUnit { get; set; }
	public WindDirectionEnum? WindDirection { get; set; }
	public string? ShortForecastDescription { get; set; }
	public string? LongForecastDescription { get; set; }
}
