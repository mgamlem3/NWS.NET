using System.Collections.ObjectModel;

namespace NWS.NET.Common.Objects.Units;

public static class Pressure
{
	public const string InchesOfMercury = "inhg";
	public const string MilimetersOfMercury = "mmhg";
	public const string Bars = "bar";
	public const string Pascal = "pa";

	public static ReadOnlyCollection<string> GetAllUnitOptions() => new(new List<string>() { InchesOfMercury, MilimetersOfMercury, Bars, Pascal });
}
