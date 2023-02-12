using System.Collections.ObjectModel;

namespace NWS.NET.Common.Objects.Units;

public static class WindDirection
{
	public const string North = "N";
	public const string NorthNorthEast = "NNE";
	public const string NorthEast = "NE";
	public const string EastNorthEast = "ENE";
	public const string East = "E";
	public const string EastSouthEast = "ESE";
	public const string SouthEast = "SE";
	public const string SouthSouthEast = "SSE";
	public const string South = "S";
	public const string SouthSouthWest = "SSW";
	public const string SouthWest = "SW";
	public const string WestSouthWest = "WSW";
	public const string West = "W";
	public const string WestNorthWest = "WNW";
	public const string NorthWest = "NW";
	public const string NorthNorthWest = "NNW";

	public static ReadOnlyCollection<string> GetAllUnitOptions() => new(new List<string>() { North, NorthNorthEast, NorthEast, EastNorthEast, East, EastSouthEast, SouthEast, SouthSouthEast, South, SouthSouthWest, SouthWest, WestSouthWest, West, WestNorthWest, NorthWest, NorthNorthWest });
}
