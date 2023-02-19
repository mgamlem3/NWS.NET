using NWS.NET.NWS.Dtos.Components.Common;

namespace NWS.NET.NWS.Dtos.Components.PointsDto.PointsProperties.RelativeLocationProperties;

public sealed record RelativeLocationProperties
{
	public string City { get; set; }
	public string State { get; set; }
	public Distance Distance { get; set; }
	public Bearing Bearing { get; set; }
}
