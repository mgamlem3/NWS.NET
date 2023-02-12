using NWS.NET.Common.Enums.Units;
using NWS.NET.Common.Objects;

namespace NWS.NET.Api.Weather.Responses;

public sealed class CurrentConditions
{
	public DateTime? ObservationDate { get; set; }
	public WeatherStation? WeatherStation { get; set; }
	public double? Temperature { get; set; }
	public TemperatureEnum? TemperatureUnit { get; set; }
	public string? Description { get; set; }
	public double? DewPoint { get; set; }
	public TemperatureEnum? DewPointUnit { get; set; }
	public double? WindDirection { get; set; }
	public double? WindSpeed { get; set; }
	public VelocityEnum? WindSpeedUnit { get; set; }
	public double? WindGust { get; set; }
	public VelocityEnum? WindGustUnit { get; set; }
	public double? BarometricPressure { get; set; }
	public PressureEnum? BarometricPressureUnit { get; set; }
	public double? SeaLevelPressure { get; set; }
	public PressureEnum? SeaLevelPressureUnit { get; set; }
	public double? Visibility { get; set; }
	public LengthEnum? VisibilityUnit { get; set; }
	public double? RelativeHumidityPercent { get; set; }
	public double? WindChill { get; set; }
	public TemperatureEnum? WindChillUnit { get; set; }
	public double? HeatIndex { get; set; }
	public TemperatureEnum? HeatIndexUnit { get; set; }
	public string? RawData { get; set; }
	public Uri? NextPage { get; set; }
}
