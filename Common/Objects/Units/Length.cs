using System.Collections.ObjectModel;

namespace NWS.NET.Common.Objects.Units;

public static class Length
{
	public const string Milimeters = "mm";
	public const string Centimeters = "cm";
	public const string Meters = "m";
	public const string Kilometers = "km";
	public const string Inches = "in";
	public const string Feet = "ft";
	public const string Miles = "mi";

	public static ReadOnlyCollection<string> GetAllUnitOptions() => new(new List<string>() { Milimeters, Centimeters, Meters, Kilometers, Inches, Feet, Miles });
}
