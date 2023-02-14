using System.Collections.ObjectModel;

namespace NWS.NET.Common.Objects.Units;

public static class Velocity
{
	public const string MilesPerHour = "mph";
	public const string MetersPerSecond = "mps";
	public const string Knots = "kn";
	public const string KilometersPerHour = "kph";

	public static ReadOnlyCollection<string> GetAllUnitOptions() => new(new List<string>() { MilesPerHour, MetersPerSecond, Knots });
}
