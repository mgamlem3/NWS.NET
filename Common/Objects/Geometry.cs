using System.Collections.ObjectModel;

namespace NWS.NET.Common.Objects;

public sealed class Geometry
{
	public string Type { get; set; }
	public ReadOnlyCollection<GeoCoordinate> Coordinates { get; set; }
}
