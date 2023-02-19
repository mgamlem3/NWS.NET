using NWS.NET.Common.Objects;

namespace NWS.NET.Api.Weather.Responses;

public sealed class CurrentConditionsDto
{
	public DateTime? ObservationDate { get; set; }
	public WeatherStationDto? WeatherStation { get; set; }
	public double? Temperature { get; set; }
	public string? TemperatureUnit { get; set; }
	public string? Description { get; set; }
	public double? DewPoint { get; set; }
	public string? DewPointUnit { get; set; }
	public double? WindDirection { get; set; }
	public double? WindSpeed { get; set; }
	public string? WindSpeedUnit { get; set; }
	public double? WindGust { get; set; }
	public string? WindGustUnit { get; set; }
	public double? BarometricPressure { get; set; }
	public string? BarometricPressureUnit { get; set; }
	public double? SeaLevelPressure { get; set; }
	public string? SeaLevelPressureUnit { get; set; }
	public double? Visibility { get; set; }
	public string? VisibilityUnit { get; set; }
	public double? RelativeHumidityPercent { get; set; }
	public double? WindChill { get; set; }
	public string? WindChillUnit { get; set; }
	public double? HeatIndex { get; set; }
	public string? HeatIndexUnit { get; set; }
	public string? RawData { get; set; }
	public Uri? NextPage { get; set; }
}
