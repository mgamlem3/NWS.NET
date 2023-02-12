using NWS.NET.Common.Utilities;

namespace NWS.NET.Tests.UnitTests;

public class UnitConversionTests
{
	[Theory]
	[InlineData(0, 32)]
	public static void ConvertCelciusToFarenheit(double c, double expected) => Assert.Equal(expected, UnitConversionUtility.ConvertCelsiusToFahrenheit(c));

	[Theory]
	[InlineData(32, 0)]
	public static void ConvertFarenheitToCelcius(double f, double expected) => Assert.Equal(expected, UnitConversionUtility.ConvertFarenheitToCelcius(f));

	[Theory]
	[InlineData(0, 273.15)]
	public static void ConvertCelciusToKelvin(double c, double expected) => Assert.Equal(expected, UnitConversionUtility.ConvertCelciusToKelvin(c));

	[Theory]
	[InlineData(273.15, 0)]
	public static void ConvertKelvinToCelcius(double k, double expected) => Assert.Equal(expected, UnitConversionUtility.ConvertKelvinToCelcius(k));

	[Theory]
	[InlineData(0, 255.372)]
	public static void ConvertFarenheitToKelvin(double f, double expected) => Assert.Equal(expected, UnitConversionUtility.ConvertFarenheitToKelvin(f), 0.0004);

	[Theory]
	[InlineData(255.372, 0)]
	public static void ConvertKelvinToFarenheit(double k, double expected) => Assert.Equal(expected, UnitConversionUtility.ConvertKelvinToFarenheit(k), 0.0004);

	[Theory]
	[InlineData(1, 2.2367)]
	public static void ConvertMetersPerSecondToMilesPerHour(double mps, double expected) => Assert.Equal(expected, UnitConversionUtility.ConvertMetersPerSecondToMilesPerHour(mps), 0.001);

	[Theory]
	[InlineData(2.23694, 1)]
	public static void ConvertMilesPerHourToMetersPerSecond(double mph, double expected) => Assert.Equal(expected, UnitConversionUtility.ConvertMilesPerHourToMetersPerSecond(mph), 0.1);

	[Theory]
	[InlineData(1, 0.621371)]
	public static void ConvertKilometersPerHourToMilesPerHour(double kph, double expected) => Assert.Equal(expected, UnitConversionUtility.ConvertKilometersPerHourToMilesPerHour(kph), 0.1);

	[Theory]
	[InlineData(0.621371, 1)]
	public static void ConvertMilesPerHourToKilometersPerHour(double mph, double expected) => Assert.Equal(expected, UnitConversionUtility.ConvertMilesPerHourToKilometersPerHour(mph), 0.001);
}
