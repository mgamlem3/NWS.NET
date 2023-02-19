using System.Collections.ObjectModel;

namespace NWS.NET.NWS.Dtos.Components;

public sealed record ForecastGeometry
{
	public string Type { get; set; }
	public ReadOnlyCollection<ReadOnlyCollection<double[]>> Coordinates { get; set; }
}
