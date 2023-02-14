namespace NWS.NET.Api.Exceptions;

public class NWSApiException : Exception
{
	public NWSApiException()
	{
	}

	public NWSApiException(string message) : base(message)
	{
	}

	public NWSApiException(string message, Exception innerException) : base(message, innerException)
	{
	}
}
