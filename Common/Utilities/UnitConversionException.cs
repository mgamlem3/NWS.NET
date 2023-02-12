namespace NWS.NET.Common.Utilities;

public class UnitConversionException : Exception
{
	public UnitConversionException()
	{
	}

	public UnitConversionException(string message) : base(message)
	{
	}

	public UnitConversionException(string message, Exception innerException) : base(message, innerException)
	{
	}
}
