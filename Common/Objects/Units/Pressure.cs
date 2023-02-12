using System.Collections.ObjectModel;

namespace NWS.NET.Common.Objects.Units;

public static class Pressure
{
	public const string InchesOfMercury = "inHG";
	public const string MilimetersOfMercury = "mmHG";
	public const string Bars = "bar";

	public static ReadOnlyCollection<string> GetAllUnitOptions() => new(new List<string>() { InchesOfMercury, MilimetersOfMercury, Bars });
}
