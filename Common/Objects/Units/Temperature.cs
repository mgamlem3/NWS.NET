using System.Collections.ObjectModel;

namespace NWS.NET.Common.Objects.Units;

public static class Temperature
{
	public const string Celcius = "C";
	public const string Farenheit = "F";
	public const string Kelvin = "K";

	public static ReadOnlyCollection<string> GetAllUnitOptions() => new(new List<string>() { Celcius, Farenheit, Kelvin });
}
