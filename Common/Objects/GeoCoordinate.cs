namespace NWS.NET.Common.Objects;

public sealed class GeoCoordinate
{
	public GeoCoordinate(double latitude, double longitude) => (Latitude, Longitude) = (latitude, longitude);

	public double Latitude { get; set; }
	public double Longitude { get; set; }
}
