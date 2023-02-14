namespace NWS.NET.Common.Utilities;

public static class UnitConversionUtility
{
	public static double ConvertCelsiusToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;

	public static double ConvertFarenheitToCelcius(double farenheit) => (farenheit - 32) * 5 / 9;

	public static double ConvertCelciusToKelvin(double celsius) => celsius + c_kelvinCelciusConversionValue;

	public static double ConvertKelvinToCelcius(double kelvin) => kelvin - c_kelvinCelciusConversionValue;

	public static double ConvertFarenheitToKelvin(double farenheit) => ConvertCelciusToKelvin(ConvertFarenheitToCelcius(farenheit));

	public static double ConvertKelvinToFarenheit(double kelvin) => ConvertCelsiusToFahrenheit(ConvertKelvinToCelcius(kelvin));

	public static double ConvertMetersPerSecondToMilesPerHour(double mps) => mps * c_mpsMphConversionValue;

	public static double ConvertMilesPerHourToMetersPerSecond(double mph) => mph / c_mpsMphConversionValue;

	public static double ConvertKilometersPerHourToMilesPerHour(double speed) => speed / c_kphMphConversionValue;

	public static double ConvertMilesPerHourToKilometersPerHour(double speed) => speed * c_kphMphConversionValue;

	private const double c_kelvinCelciusConversionValue = 273.15;
	private const double c_mpsMphConversionValue = 2.237;
	private const double c_kphMphConversionValue = 1.609;
}
