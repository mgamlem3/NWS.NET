using Mg3.Utility.StringUtility;
using NWS.Dtos.Components.Common;
using NWS.NET.Common.Enums.Units;
using NWS.NET.Common.Utilities;

namespace NWS.Dtos.Components.ObservationDto;

public sealed record ObservationDtoProperties
{
	public string? @Id { get; set; }
	public string? @Type { get; set; }
	public Elevation? Elevation { get; set; }
	public Uri? Station { get; set; }
	public DateTime? Timestamp { get; set; }
	public string? RawMessage { get; set; }
	public string? TextDescription { get; set; }
	public Uri? Icon { get; set; }

	// Unknown NWS object array
#pragma warning disable CA1819
	public object[]? PresentWeather { get; set; }
#pragma warning restore CA1819

	public Temperature? Temperature { get; set; }
	public Dewpoint? Dewpoint { get; set; }
	public WindDirection? WindDirection { get; set; }
	public WindSpeed? WindSpeed { get; set; }
	public WindGust? WindGust { get; set; }
	public BarometricPressure? BarometricPressure { get; set; }
	public SeaLevelPressure? SeaLevelPressure { get; set; }
	public Visibility? Visibility { get; set; }
	public MaxTemperatureLast24Hours? MaxTemperatureLast24Hours { get; set; }
	public MinTemperatureLast24Hours? MinTemperatureLast24Hours { get; set; }
	public PrecipitationLastHour? PrecipitationLastHour { get; set; }
	public PrecipitationLast3Hours? PrecipitationLast3Hours { get; set; }
	public PrecipitationLast6Hours? PrecipitationLast6Hours { get; set; }
	public RelativeHumidity? RelativeHumidity { get; set; }
	public WindChill? WindChill { get; set; }
	public HeatIndex? HeatIndex { get; set; }
	public IReadOnlyCollection<CloudLayer>? CloudLayers { get; set; }

	public TemperatureEnum? GetTemperatureUnitEnum() => MapTemperatureUnitEnum(Temperature?.UnitCode);
	public TemperatureEnum? GetDewPointUnitEnum() => MapTemperatureUnitEnum(Dewpoint?.UnitCode);
	public VelocityEnum? GetWindSpeedUnitEnum() => MapVelocityUnitEnum(WindSpeed?.UnitCode);
	public VelocityEnum? GetWindGustUnitEnum() => MapVelocityUnitEnum(WindGust?.UnitCode);
	public TemperatureEnum? GetWindChillUnitEnum() => MapTemperatureUnitEnum(WindChill?.UnitCode);
	public TemperatureEnum? GetHeatIndexUnitEnum() => MapTemperatureUnitEnum(HeatIndex?.UnitCode);
	public PressureEnum? GetBarometricPressureUnitEnum() => MapPressureUnitEnum(BarometricPressure?.UnitCode);
	public PressureEnum? GetSeaLevelPressureUnitEnum() => MapPressureUnitEnum(SeaLevelPressure?.UnitCode);
	public LengthEnum? GetVisibilityUnitEnum() => MapLengthUnitEnum(Visibility?.UnitCode);

	private static TemperatureEnum? MapTemperatureUnitEnum(string? value)
	{
		if (value.IsNullOrWhitespace())
			return null;

		var enumUnit = Regexes.UnitRegex().Match(value).Value;

		return NET.Common.Objects.Units.Temperature.GetAllUnitOptions().First(x => x == value).MapTemperature();
	}
	private static VelocityEnum? MapVelocityUnitEnum(string? value)
	{
		if (value.IsNullOrWhitespace())
			return null;

		var enumUnit = Regexes.UnitRegex().Match(value).Value;

		return NET.Common.Objects.Units.Velocity.GetAllUnitOptions().First(x => x == value).MapVelocity();
	}
	private static PressureEnum? MapPressureUnitEnum(string? value)
	{
		if (value.IsNullOrWhitespace())
			return null;

		var enumUnit = Regexes.UnitRegex().Match(value).Value;

		return NET.Common.Objects.Units.Pressure.GetAllUnitOptions().First(x => x == value).MapPressure();
	}
private static LengthEnum? MapLengthUnitEnum(string? value)
	{
		if (value.IsNullOrWhitespace())
			return null;

		var enumUnit = Regexes.UnitRegex().Match(value).Value;

		return NET.Common.Objects.Units.Length.GetAllUnitOptions().First(x => x == value).MapLength();
	}

}
