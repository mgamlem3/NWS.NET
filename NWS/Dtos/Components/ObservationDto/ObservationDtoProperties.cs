using NWS.Dtos.Components.Common;

namespace NWS.Dtos.Components.ObservationDto;

public sealed record ObservationDtoProperties
{
	public string? @Id { get; set; }
	public string? @Type { get; set; }
	public Elevation? Elevation { get; set; }
	public Uri? Station { get; set; }
	public DateTime? Timestamp { get; set; }
	public string? RawMessage { get; set; }
	public string? TextDescription { get; set; }
	public Uri? Icon { get; set; }

	// Unknown NWS object array
#pragma warning disable CA1819
	public object[]? PresentWeather { get; set; }
#pragma warning restore CA1819

	public Temperature? Temperature { get; set; }
	public Dewpoint? Dewpoint { get; set; }
	public WindDirection? WindDirection { get; set; }
	public WindSpeed? WindSpeed { get; set; }
	public WindGust? WindGust { get; set; }
	public BarometricPressure? BarometricPressure { get; set; }
	public SeaLevelPressure? SeaLevelPressure { get; set; }
	public Visibility? Visibility { get; set; }
	public MaxTemperatureLast24Hours? MaxTemperatureLast24Hours { get; set; }
	public MinTemperatureLast24Hours? MinTemperatureLast24Hours { get; set; }
	public PrecipitationLastHour? PrecipitationLastHour { get; set; }
	public PrecipitationLast3Hours? PrecipitationLast3Hours { get; set; }
	public PrecipitationLast6Hours? PrecipitationLast6Hours { get; set; }
	public RelativeHumidity? RelativeHumidity { get; set; }
	public WindChill? WindChill { get; set; }
	public HeatIndex? HeatIndex { get; set; }
	public IReadOnlyCollection<CloudLayer>? CloudLayers { get; set; }
}
