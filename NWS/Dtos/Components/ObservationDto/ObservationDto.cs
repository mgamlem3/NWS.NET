using NWS.NET.NWS.Dtos.Components.Common;

namespace NWS.NET.NWS.Dtos.Components.ObservationDto;

public sealed record ObservationDto : NWSDto
{
	public string Id { get; set; }
	public Geometry Geometry { get; set; }
	public ObservationDtoProperties Properties { get; set; }
}
