using Mg3.Utility.StringUtility;
using NWS.NET.Common.Objects.Units;

namespace NWS.Units;

public static class NWSUnits
{
	public static string? Map(this string? unit)
	{
		if (unit.IsNullOrWhitespace())
			return null;

		// Allow because unit descriptions 
#pragma warning disable CA1308
		var formattedUnit = unit.ToLowerInvariant();
#pragma warning restore CA1308
		if (formattedUnit.Contains(c_celcius))
			return Temperature.Celcius;
		if (formattedUnit.Contains(c_kilometersPerHour))
			return Velocity.KilometersPerHour;
		if (formattedUnit.Contains(c_pascal))
			return Pressure.Pascal;
		if (formattedUnit.Contains(c_meter))
			return Length.Meters;
		if (formattedUnit.Contains(c_milimeter))
			return Length.Milimeters;
		if (formattedUnit.Contains(c_angle))
			return WindDirection.Degrees;

		return null;
	}

	private const string c_celcius = "degC";
	private const string c_angle = "degree_(angle)";
	private const string c_kilometersPerHour = "km_h-1";
	private const string c_pascal = "Pa";
	private const string c_meter = "m";
	private const string c_milimeter = "mm";
}
