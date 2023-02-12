using NWS.Dtos.Components;
using NWS.Dtos.Components.Common;

namespace NWS.Dtos;

public sealed record PointsDto : NWSDto
{
	public string Id { get; set; }
	public Geometry Geometry { get; set; }
	public PointsProperties Properties { get; set; }
}
