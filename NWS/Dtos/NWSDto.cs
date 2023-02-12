namespace NWS.Dtos;

public partial record NWSDto
{
	public dynamic @Context { get; set; }
	public string Type { get; set; }
}
