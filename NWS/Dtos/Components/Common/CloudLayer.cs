namespace NWS.NET.NWS.Dtos.Components.Common;

public sealed record CloudLayer
{
	public Elevation? Base { get; set; }
	public string? Amount { get; set; }
}

