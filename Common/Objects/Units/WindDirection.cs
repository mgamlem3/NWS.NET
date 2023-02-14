using System.Collections.ObjectModel;

namespace NWS.NET.Common.Objects.Units;

public static class WindDirection
{
	public const string North = "n";
	public const string NorthNorthEast = "nne";
	public const string NorthEast = "ne";
	public const string EastNorthEast = "ene";
	public const string East = "e";
	public const string EastSouthEast = "ese";
	public const string SouthEast = "se";
	public const string SouthSouthEast = "sse";
	public const string South = "s";
	public const string SouthSouthWest = "ssw";
	public const string SouthWest = "sw";
	public const string WestSouthWest = "wsw";
	public const string West = "w";
	public const string WestNorthWest = "wnw";
	public const string NorthWest = "nw";
	public const string NorthNorthWest = "nnw";

	public static ReadOnlyCollection<string> GetAllUnitOptions() => new(new List<string>() { North, NorthNorthEast, NorthEast, EastNorthEast, East, EastSouthEast, SouthEast, SouthSouthEast, South, SouthSouthWest, SouthWest, WestSouthWest, West, WestNorthWest, NorthWest, NorthNorthWest });
}
