namespace NWS.Dtos.Components.Common;

public abstract record UnitWithValue
{
	public string? UnitCode { get; set; }
	public double? Value { get; set; }
	public string? QualityControl { get; set; }
}
