using NWS.NET.Api.Weather.Responses;
using NWS.NET.Common.Objects;
using System.Collections.ObjectModel;

namespace NWS.NET.Api.Interfaces;

public interface IApiService
{
	Task<ReadOnlyCollection<CurrentConditionsDto?>?> GetCurrentConditionsAsync(double latitude, double longitude);

	Task<ForecastDto?> GetForecastAsync(double latitude, double longitude);

	Task<CurrentConditionsDto?> GetCurrentConditionsForStationAsync(WeatherStationDto? station);
}
