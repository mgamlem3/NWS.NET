using NWS.Dtos.Components;
using NWS.Dtos.Components.ForecastDto;

namespace NWS.Dtos;

public sealed record ForecastDto : NWSDto
{
	public ForecastGeometry Geometry { get; set; }
	public ForecastProperties Properties { get; set; }
}
