using NWS.NET.NWS.Dtos.Components.Common;
using NWS.NET.NWS.Dtos.Components.StationDto;
using System.Collections.ObjectModel;

namespace NWS.NET.NWS.Dtos;

public sealed record NWSStationDto : NWSDto
{
	public ReadOnlyCollection<StationFeature> Features { get; set; }
	public Pagination Pagination { get; set; }
}
