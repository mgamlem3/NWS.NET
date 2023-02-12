using Mg3.Utility.StringUtility;
using NWS.NET.Common.Enums.Units;
using NWS.NET.Common.Objects.Units;
using NWS.NET.Common.Utilities;

namespace NWS.Dtos.Components.Common;

public sealed class Elevation
{
	public string UnitCode { get; set; }
	public double Value { get; set; }

	public LengthEnum? GetLengthUnitEnum()
	{
		if (UnitCode.IsNullOrEmpty())
			return null;

		var unit = Regexes.UnitRegex().Match(UnitCode).Value;

		return Length.GetAllUnitOptions().First(x => x == unit).MapLength();
	}
}
