using NWS.NET.NWS.Dtos.Components.Common;

namespace NWS.NET.NWS.Dtos.Components.PointsDto.PointsProperties;

public record RelativeLocation
{
	public string Type { get; set; }
	public Geometry Geometry { get; set; }
}
