using System.Collections.ObjectModel;

namespace NWS.Dtos.Components.Common;

public sealed record Geometry
{
	public string Type { get; set; }
	public ReadOnlyCollection<double> Coordinates { get; set; }
}
