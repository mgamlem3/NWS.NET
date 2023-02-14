namespace NWS.Dtos.Components.ForecastDto;

public sealed class ForecastPeriodDto
{
	public uint? Number { get; set; }
	public string? Name { get; set; }
	public DateTime? StartTime { get; set; }
	public DateTime? EndTime { get; set; }
	public bool? IsDaytime { get; set; }
	public double? Temperature { get; set; }
	public string? TemperatureUnit { get; set; }
	public string? TemperatureTrend { get; set; }
	public string? WindSpeed { get; set; }
	public string? WindDirection { get; set; }
	public Uri? Icon { get; set; }
	public string? ShortForecast { get; set; }
	public string? DetailedForecast { get; set; }
}
