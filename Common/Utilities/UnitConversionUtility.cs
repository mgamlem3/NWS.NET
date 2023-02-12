using NWS.NET.Common.Enums.Units;

namespace NWS.NET.Common.Utilities;

public static class UnitConversionUtility
{
	public static double ConvertCelsiusToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;

	public static double ConvertMetersPerSecondToMilesPerHour(double speed) => speed * 2.23694;

	public static double ConvertKilometersPerHourToMilesPerHour(double speed) => speed / 1.609;

	public static double? TryConvertToDouble(dynamic value)
	{
		var success = double.TryParse(value.ToString(), out double result);

		return success ? result : null;
	}

	public static TemperatureEnum MapTemperature(this string temperature)
	{
		if (temperature is null)
			throw new ArgumentNullException(nameof(temperature));

		switch (temperature.ToUpperInvariant())
		{
			case (Objects.Units.Temperature.Celcius):
				return TemperatureEnum.Celcius;
			case (Objects.Units.Temperature.Farenheit):
				return TemperatureEnum.Farenheit;
			case (Objects.Units.Temperature.Kelvin):
				return TemperatureEnum.Kelvin;
			default:
				break;
		}

		throw new UnitConversionException("Unexpected error");
	}

	public static string MapTemperature(this TemperatureEnum temperature)
	{
		switch (temperature)
		{
			case (TemperatureEnum.Celcius):
				return Objects.Units.Temperature.Celcius;
			case (TemperatureEnum.Farenheit):
				return Objects.Units.Temperature.Farenheit;
			case (TemperatureEnum.Kelvin):
				return Objects.Units.Temperature.Kelvin;
			default:
				break;
		}

		throw new UnitConversionException("Unexpected error");
	}

	public static VelocityEnum MapVelocity(this string velocity)
	{
		if (velocity is null)
			throw new ArgumentNullException(nameof(velocity));

		switch (velocity.ToUpperInvariant())
		{
			case (Objects.Units.Velocity.MilesPerHour):
				return VelocityEnum.MilesPerHour;
			case (Objects.Units.Velocity.MetersPerSecond):
				return VelocityEnum.MetersPerSecond;
			case (Objects.Units.Velocity.Knots):
				return VelocityEnum.Knots;
			default:
				break;
		}

		throw new UnitConversionException("Unexpected error");
	}

	public static string MapVelocity(this VelocityEnum velocity)
	{
		switch (velocity)
		{
			case (VelocityEnum.MilesPerHour):
				return Objects.Units.Velocity.MilesPerHour;
			case (VelocityEnum.MetersPerSecond):
				return Objects.Units.Velocity.MetersPerSecond;
			case (VelocityEnum.Knots):
				return Objects.Units.Velocity.Knots;
			default:
				break;
		}

		throw new UnitConversionException("Unexpected error");
	}

	public static LengthEnum MapLength(this string length)
	{
		if (length is null)
			throw new ArgumentNullException(nameof(length));

		switch (length.ToUpperInvariant())
		{
			case (Objects.Units.Length.Milimeters):
				return LengthEnum.Milimeters;
			case (Objects.Units.Length.Centimeters):
				return LengthEnum.Centimeters;
			case (Objects.Units.Length.Meters):
				return LengthEnum.Meters;
			case (Objects.Units.Length.Kilometers):
				return LengthEnum.Kilometers;
			case (Objects.Units.Length.Inches):
				return LengthEnum.Inches;
			case (Objects.Units.Length.Feet):
				return LengthEnum.Feet;
			case (Objects.Units.Length.Miles):
				return LengthEnum.Miles;
			default:
				break;
		}

		throw new UnitConversionException("Unexpected error");
	}

	public static string MapLength(this LengthEnum length)
	{
		switch (length)
		{
			case (LengthEnum.Milimeters):
				return Objects.Units.Length.Milimeters;
			case (LengthEnum.Centimeters):
				return Objects.Units.Length.Centimeters;
			case (LengthEnum.Meters):
				return Objects.Units.Length.Meters;
			case (LengthEnum.Kilometers):
				return Objects.Units.Length.Kilometers;
			case (LengthEnum.Inches):
				return Objects.Units.Length.Inches;
			case (LengthEnum.Feet):
				return Objects.Units.Length.Feet;
			case (LengthEnum.Miles):
				return Objects.Units.Length.Miles;
			default:
				break;
		}

		throw new UnitConversionException("Unexpected error");
	}

	public static WindDirectionEnum MapWindDirection(this string direction)
	{
		if (direction is null)
			throw new ArgumentNullException(nameof(direction));

		switch (direction.ToUpperInvariant())
		{
			case (Objects.Units.WindDirection.North):
				return WindDirectionEnum.North;
			case (Objects.Units.WindDirection.NorthNorthEast):
				return WindDirectionEnum.NorthNorthEast;
			case (Objects.Units.WindDirection.NorthEast):
				return WindDirectionEnum.NorthEast;
			case (Objects.Units.WindDirection.EastNorthEast):
				return WindDirectionEnum.EastNorthEast;
			case (Objects.Units.WindDirection.East):
				return WindDirectionEnum.East;
			case (Objects.Units.WindDirection.EastSouthEast):
				return WindDirectionEnum.EastSouthEast;
			case (Objects.Units.WindDirection.SouthEast):
				return WindDirectionEnum.SouthEast;
			case (Objects.Units.WindDirection.SouthSouthEast):
				return WindDirectionEnum.SouthSouthEast;
			case (Objects.Units.WindDirection.South):
				return WindDirectionEnum.South;
			case (Objects.Units.WindDirection.SouthSouthWest):
				return WindDirectionEnum.SouthSouthWest;
			case (Objects.Units.WindDirection.SouthWest):
				return WindDirectionEnum.SouthWest;
			case (Objects.Units.WindDirection.WestSouthWest):
				return WindDirectionEnum.WestSouthWest;
			case (Objects.Units.WindDirection.West):
				return WindDirectionEnum.West;
			case (Objects.Units.WindDirection.WestNorthWest):
				return WindDirectionEnum.WestNorthWest;
			case (Objects.Units.WindDirection.NorthWest):
				return WindDirectionEnum.NorthWest;
			case (Objects.Units.WindDirection.NorthNorthWest):
				return WindDirectionEnum.NorthNorthWest;
			default:
				break;
		}

		throw new UnitConversionException("Unexpected error");
	}

	public static string MapWindDirection(this WindDirectionEnum direction)
	{
		switch (direction)
		{
			case (WindDirectionEnum.North):
				return Objects.Units.WindDirection.North;
			case (WindDirectionEnum.NorthNorthEast):
				return Objects.Units.WindDirection.NorthNorthEast;
			case (WindDirectionEnum.NorthEast):
				return Objects.Units.WindDirection.NorthEast;
			case (WindDirectionEnum.EastNorthEast):
				return Objects.Units.WindDirection.EastNorthEast;
			case (WindDirectionEnum.East):
				return Objects.Units.WindDirection.East;
			case (WindDirectionEnum.EastSouthEast):
				return Objects.Units.WindDirection.EastSouthEast;
			case (WindDirectionEnum.SouthEast):
				return Objects.Units.WindDirection.SouthEast;
			case (WindDirectionEnum.SouthSouthEast):
				return Objects.Units.WindDirection.SouthSouthEast;
			case (WindDirectionEnum.South):
				return Objects.Units.WindDirection.South;
			case (WindDirectionEnum.SouthSouthWest):
				return Objects.Units.WindDirection.SouthSouthWest;
			case (WindDirectionEnum.SouthWest):
				return Objects.Units.WindDirection.SouthWest;
			case (WindDirectionEnum.WestSouthWest):
				return Objects.Units.WindDirection.WestSouthWest;
			case (WindDirectionEnum.West):
				return Objects.Units.WindDirection.West;
			case (WindDirectionEnum.WestNorthWest):
				return Objects.Units.WindDirection.WestNorthWest;
			case (WindDirectionEnum.NorthWest):
				return Objects.Units.WindDirection.NorthWest;
			case (WindDirectionEnum.NorthNorthWest):
				return Objects.Units.WindDirection.NorthNorthWest;

			default:
				break;
		}

		throw new UnitConversionException("Unexpected error");
	}

	public static PressureEnum MapPressure(this string length)
	{
		if (length is null)
			throw new ArgumentNullException(nameof(length));

		switch (length.ToUpperInvariant())
		{
			case (Objects.Units.Pressure.InchesOfMercury):
				return PressureEnum.inHG;
			case (Objects.Units.Pressure.MilimetersOfMercury):
				return PressureEnum.mmHG;
			case (Objects.Units.Pressure.Bars):
				return PressureEnum.Bar;
			default:
				break;
		}

		throw new UnitConversionException("Unexpected error");
	}

	public static string MapPressure(this PressureEnum length)
	{
		switch (length)
		{
			case (PressureEnum.inHG):
				return Objects.Units.Pressure.InchesOfMercury;
			case (PressureEnum.mmHG):
				return Objects.Units.Pressure.MilimetersOfMercury;
			case (PressureEnum.Bar):
				return Objects.Units.Pressure.Bars;
			default:
				break;
		}

		throw new UnitConversionException("Unexpected error");
	}
}
