using NWS.NET.NWS.Dtos.Components.Common;
using System.Collections.ObjectModel;

namespace NWS.NET.NWS.Dtos.Components.ForecastDto;

public sealed record ForecastProperties
{
	public DateTime Updated { get; set; }
	public string Units { get; set; }
	public string ForecastGenerator { get; set; }
	public DateTime GeneratedAt { get; set; }
	public DateTime UpdatedAt { get; set; }
	public string ValidTimes { get; set; }
	public Elevation Elevation { get; set; }
	public ReadOnlyCollection<NWSForecastPeriodDto> Periods { get; set; }
}
