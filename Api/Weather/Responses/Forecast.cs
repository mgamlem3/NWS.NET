using NWS.NET.Common.Enums.Units;
using NWS.NET.Common.Objects;

namespace NWS.NET.Api.Weather.Responses;

/// <summary>
/// A weather forecast
/// </summary>
public sealed class Forecast
{
	public Geometry? Geometry { get; set; }
	public DateTime? UpdatedAt { get; set; }
	public DateTime? GeneratedAt { get; set; }
	public double? Elevation { get; set; }
	public LengthEnum? ElevationUnit { get; set; }
	public ICollection<ForecastPeriod>? Periods { get; set; }
	public string RawData { get; set; }
}
