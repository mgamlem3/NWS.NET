using NWS.Dtos.Components.Common;
using NWS.Dtos.Components.StationDto;
using System.Collections.ObjectModel;

namespace NWS.Dtos;

public sealed record StationDto : NWSDto
{
	public ReadOnlyCollection<StationFeature> Features { get; set; }
	public Pagination Pagination { get; set; }
}
