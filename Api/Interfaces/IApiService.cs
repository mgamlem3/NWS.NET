using NWS.NET.Api.Weather.Responses;
using NWS.NET.Common.Objects;
using System.Collections.ObjectModel;

namespace NWS.NET.Api.Interfaces;

public interface IApiService
{
	Task<ReadOnlyCollection<CurrentConditions?>?> GetCurrentConditionsAsync(double latitude, double longitude);

	Task<Forecast?> GetForecastAsync(double latitude, double longitude);

	Task<CurrentConditions?> GetCurrentConditionsForStationAsync(WeatherStation? station);
}
