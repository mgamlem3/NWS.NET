using NWS.NET.NWS.Dtos.Components.Common;

namespace NWS.NET.NWS.Dtos.Components.StationDto;

public sealed record StationFeature
{
	public string? Id { get; set; }
	public string? Type { get; set; }
	public Geometry? Geometry { get; set; }
	public StationFeatureProperties Properties { get; set; }
}
