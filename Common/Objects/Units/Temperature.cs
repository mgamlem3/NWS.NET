using System.Collections.ObjectModel;

namespace NWS.NET.Common.Objects.Units;

public static class Temperature
{
	public const string Celcius = "c";
	public const string Farenheit = "f";
	public const string Kelvin = "k";

	public static ReadOnlyCollection<string> GetAllUnitOptions() => new(new List<string>() { Celcius, Farenheit, Kelvin });
}
