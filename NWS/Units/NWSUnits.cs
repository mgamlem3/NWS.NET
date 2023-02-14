using Mg3.Utility.StringUtility;
using NWS.NET.Common.Objects.Units;

namespace NWS.Units;

public static class NWSUnits
{
	public static string? Map(this string? nwsUnit)
	{
		if (nwsUnit.IsNullOrWhitespace())
			return null;

		return nwsUnit switch
		{
			(c_celcius) => Temperature.Celcius,
			(c_farenheit) => Temperature.Farenheit,
			(c_kilometersPerHour) => Velocity.KilometersPerHour,
			(c_pascal) => Pressure.Pascal,
			(c_meter) => Length.Meters,
			(c_milimeter) => Length.Milimeters,
			(c_angle) => WindDirection.Degrees,
			_ => null,
		};
	}

	private const string c_celcius = "degC";
	private const string c_farenheit = "F";
	private const string c_angle = "degree_(angle)";
	private const string c_kilometersPerHour = "km_h-1";
	private const string c_pascal = "Pa";
	private const string c_meter = "m";
	private const string c_milimeter = "mm";
}
