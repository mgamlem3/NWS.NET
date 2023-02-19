using NWS.NET.NWS.Dtos.Components;
using NWS.NET.NWS.Dtos.Components.ForecastDto;

namespace NWS.NET.NWS.Dtos;

public sealed record NWSForecastDto : NWSDto
{
	public ForecastGeometry Geometry { get; set; }
	public ForecastProperties Properties { get; set; }
}
