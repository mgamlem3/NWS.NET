using Mg3.Utility.EnumerableUtility;
using Newtonsoft.Json;
using NWS.NET.Api.Exceptions;
using NWS.NET.Api.Interfaces;
using NWS.NET.Api.Weather.Responses;
using NWS.NET.Common.Objects;
using NWS.NET.NWS.Dtos;
using NWS.NET.NWS.Dtos.Components.ObservationDto;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Net.Mime;

namespace NWS.NET.Api.Weather;

/// <summary>
/// Gets weather data from the National Weather Service (api.weather.gov)
/// </summary>
public sealed class ApiWeatherService : IApiService
{
	public ApiWeatherService() => m_httpClient = GetDefaultHttpClient();
	public ApiWeatherService(string userAgent) => m_httpClient = GetDefaultHttpClient(userAgent);
	public ApiWeatherService(HttpClient httpClient) => m_httpClient = httpClient;

	/// <summary>
	/// Gets the current weather conditions for a given latitude and longitude
	/// </summary>
	/// <param name="latitude">Latitude</param>
	/// <param name="longitude">Longitude</param>
	/// <returns>Collection of CurrentConditions</returns>
	/// <exception cref="NWSApiException"></exception>
	public async Task<ReadOnlyCollection<CurrentConditionsDto?>?> GetCurrentConditionsAsync(double latitude, double longitude)
	{
		var pointsResponse = await m_httpClient.GetAsync($"https://api.weather.gov/points/{latitude:0.####},{longitude:0.####}");

		if (!pointsResponse.IsSuccessStatusCode)
			throw new NWSApiException($"{pointsResponse.StatusCode} was returned from api");

		var pointsDto = JsonConvert.DeserializeObject<NWSPointsDto>(await pointsResponse.Content.ReadAsStringAsync());

		var observationStationsUrl = pointsDto?.Properties.ObservationStations;

		if (observationStationsUrl is null)
			throw new NWSApiException("Observation URL was not returned");

		var observationResponse = await m_httpClient.GetAsync(observationStationsUrl);

		if (!observationResponse.IsSuccessStatusCode)
			throw new NWSApiException($"{observationResponse.StatusCode} returned from api");

		var observationContent = await observationResponse.Content.ReadAsStringAsync();

		var stationDto = JsonConvert.DeserializeObject<NWSStationDto>(observationContent);

		if (stationDto is null || stationDto.Features is null)
			return null;

		var tasks = stationDto?.Features?.Select(async x =>
		{
			await s_semaphore.WaitAsync();

			try
			{
				return await GetCurrentConditionsForStationAsync(x?.MapWeatherStation());
			}
			catch (NWSApiException e)
			{
				Console.WriteLine(e);
			}
			finally
			{
				s_semaphore.Release();
			}

			return null;
		});

		if (tasks is null)
			return null;

		Task.WaitAll(tasks.ToArray());

		return tasks?.Select(x => x?.Result).AsReadOnlyCollection();
	}

	/// <summary>
	/// Gets the weather forecast for a given latitude and longitude
	/// </summary>
	/// <param name="latitude">Latitude</param>
	/// <param name="longitude">Longitude</param>
	/// <returns>A Forecast containing forecast data for the given latitude and longitude</returns>
	/// <exception cref="NWSApiException"></exception>
	public async Task<Responses.ForecastDto?> GetForecastAsync(double latitude, double longitude)
	{
		var pointsResponse = await m_httpClient.GetAsync($"https://api.weather.gov/points/{latitude:0.####},{longitude:0.####}");

		if (!pointsResponse.IsSuccessStatusCode)
			throw new NWSApiException($"{pointsResponse.StatusCode} was returned from api");

		var pointsDto = JsonConvert.DeserializeObject<NWSPointsDto>(await pointsResponse.Content.ReadAsStringAsync());

		var forecastUri = pointsDto?.Properties?.Forecast;

		if (forecastUri is null)
			throw new NWSApiException("Forecast URL was not returned");

		var forecastResponse = await m_httpClient.GetAsync(forecastUri);

		if (!forecastResponse.IsSuccessStatusCode)
			throw new NWSApiException($"{forecastResponse.StatusCode} was returned from api");

		var forecastResponseContent = await forecastResponse.Content.ReadAsStringAsync();
		var forecastDto = JsonConvert.DeserializeObject<NWSForecastDto>(forecastResponseContent);

		if (forecastDto is null)
			return null;

		var response = forecastDto.MapForecastDto(forecastResponseContent);
		response.Periods = new List<ForecastPeriodDto>();

		foreach (var p in forecastDto.Properties.Periods)
		{
			response.Periods.Add(p.MapForecastPeriod());
		}

		return response;
	}

	/// <summary>
	/// Gets current conditions for the specified weather station
	/// </summary>
	/// <param name="station">Station name</param>
	/// <returns></returns>
	/// <exception cref="NWSApiException"></exception>
	public async Task<CurrentConditionsDto?> GetCurrentConditionsForStationAsync(string? station) => await GetCurrentConditionsForStationAsync(new WeatherStationDto { StationIdentifier = station });

	/// <summary>
	/// Gets current conditions for the specified weather station
	/// </summary>
	/// <param name="station">Weather station to use</param>
	/// <returns></returns>
	/// <exception cref="NWSApiException"></exception>
	public async Task<CurrentConditionsDto?> GetCurrentConditionsForStationAsync(WeatherStationDto? station)
	{
		if (station is null)
			return null;

		var observationsResponse = await m_httpClient.GetAsync($"https://api.weather.gov/stations/{station.StationIdentifier}/observations/latest");

		if (!observationsResponse.IsSuccessStatusCode)
			throw new NWSApiException($"{observationsResponse.StatusCode} was returned from api {station.StationIdentifier}");

		var observationContent = await observationsResponse.Content.ReadAsStringAsync();
		var observationDto = JsonConvert.DeserializeObject<ObservationDto>(observationContent);

		var response = observationDto?.MapObservation(rawContent: observationContent);

		return response;
	}

	private static HttpClient GetDefaultHttpClient(string? userAgent = null)
	{
		var client = new HttpClient() { Timeout = new TimeSpan(0, 0, 5) };
		client.DefaultRequestHeaders.Clear();
		if (userAgent != null)
			client.DefaultRequestHeaders.UserAgent.ParseAdd(userAgent);
		client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));

		return client;
	}

	private readonly HttpClient m_httpClient;
	private static readonly SemaphoreSlim s_semaphore = new(10);
}
