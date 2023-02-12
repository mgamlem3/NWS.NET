using Mg3.Utility.StringUtility;
using NWS.NET.Common.Enums.Units;
using NWS.NET.Common.Utilities;

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

	public TemperatureEnum? GetTemperatureUnitEnum()
	{
		if (TemperatureUnit.IsNullOrWhitespace())
			return null;

		var enumUnit = Regexes.UnitRegex().Match(TemperatureUnit).Value;

		return NET.Common.Objects.Units.Temperature.GetAllUnitOptions().First(x => x == TemperatureUnit).MapTemperature();
	}

	public WindDirectionEnum? GetWindDirectionUnitEnum()
	{
		if (WindDirection.IsNullOrWhitespace())
			return null;

		var enumUnit = Regexes.UnitRegex().Match(WindDirection).Value;

		return NET.Common.Objects.Units.WindDirection.GetAllUnitOptions().First(x => x == WindDirection).MapWindDirection();
	}
}
