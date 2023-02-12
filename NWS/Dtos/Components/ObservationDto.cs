using NWS.Dtos.Components.Common;
using NWS.Dtos.Components.ObservationDto;

namespace NWS.Dtos;

public sealed record ObservationDto : NWSDto
{
	public string Id { get; set; }
	public Geometry Geometry { get; set; }
	public ObservationDtoProperties Properties { get; set; }
}
