using NWS.Dtos.Components.Common;

namespace NWS.Dtos.Components.PointsDto.PointsProperties;

public record RelativeLocation
{
	public string Type { get; set; }
	public Geometry Geometry { get; set; }
}
