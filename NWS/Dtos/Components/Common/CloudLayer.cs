namespace NWS.Dtos.Components.Common;

public sealed record CloudLayer
{
	public UnitWithValue? Base { get; set; }
	public string? Amount { get; set; }
}

