using NWS.NET.NWS.Dtos.Components.Common;
using NWS.NET.NWS.Dtos.Components.PointsDto.PointsProperties;

namespace NWS.NET.NWS.Dtos;

public sealed record NWSPointsDto : NWSDto
{
	public string Id { get; set; }
	public Geometry Geometry { get; set; }
	public PointsProperties Properties { get; set; }
}
