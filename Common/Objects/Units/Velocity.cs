using System.Collections.ObjectModel;

namespace NWS.NET.Common.Objects.Units;

public static class Velocity
{
	public const string MilesPerHour = "MPH";
	public const string MetersPerSecond = "MPS";
	public const string Knots = "Kn";

	public static ReadOnlyCollection<string> GetAllUnitOptions() => new(new List<string>() { MilesPerHour, MetersPerSecond, Knots });
}
