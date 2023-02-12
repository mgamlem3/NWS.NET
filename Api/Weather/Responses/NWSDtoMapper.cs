using NWS.Dtos;
using NWS.Dtos.Components.ForecastDto;
using NWS.Dtos.Components.StationDto;
using NWS.NET.Common.Objects;
using NWS.NET.Common.Utilities;

namespace NWS.NET.Api.Weather.Responses;

public static class NWSDtoMapper
{
	public static Forecast MapForecastDto(this ForecastDto dto, string rawContent)
	{
		if (dto is null)
			throw new ArgumentNullException(nameof(dto));

		return new Forecast()
		{
			UpdatedAt = dto.Properties.UpdatedAt,
			GeneratedAt = dto.Properties.GeneratedAt,
			Elevation = dto.Properties.Elevation.Value,
			ElevationUnit = dto.Properties.Elevation.GetLengthUnitEnum(),
			Periods = new List<ForecastPeriod>(),
			RawData = rawContent,
		};
	}

	public static ForecastPeriod MapForecastPeriod(this ForecastPeriodDto dto)
	{
		if (dto is null)
			throw new ArgumentNullException(nameof(dto));

		_ = double.TryParse(dto.WindSpeed, out var windSpeed);

		return new ForecastPeriod()
		{
			Number = dto.Number,
			Name = dto.Name,
			StartTime = dto.StartTime,
			EndTime = dto.EndTime,
			IsDayTime = dto.IsDaytime,
			Temperature = dto.Temperature,
			TemperatureUnit = dto.GetTemperatureUnitEnum(),
			TemperatureTrend = dto.TemperatureTrend,
			WindSpeed = windSpeed,
			WindDirection = dto.WindDirection?.MapWindDirection(),
			ShortForecastDescription = dto.ShortForecast,
			LongForecastDescription = dto.DetailedForecast,
		};
	}

	public static CurrentConditions MapObservation(this ObservationDto dto, WeatherStation? station = null, string? rawContent = null) => new()
	{
		ObservationDate = dto?.Properties?.Timestamp,
		WeatherStation = station,
		Temperature = dto?.Properties?.Temperature?.Value,
		TemperatureUnit = dto?.Properties?.GetTemperatureUnitEnum(),
		Description = dto?.Properties?.TextDescription,
		DewPoint = dto?.Properties?.Dewpoint?.Value,
		DewPointUnit = dto?.Properties?.GetDewPointUnitEnum(),
		WindDirection = dto?.Properties?.WindDirection?.Value,
		WindSpeed = dto?.Properties?.WindSpeed?.Value,
		WindSpeedUnit = dto?.Properties?.GetWindSpeedUnitEnum(),
		WindGust = dto?.Properties?.WindGust?.Value,
		WindGustUnit = dto?.Properties?.GetWindGustUnitEnum(),
		BarometricPressure = dto?.Properties?.BarometricPressure?.Value,
		BarometricPressureUnit = dto?.Properties?.GetBarometricPressureUnitEnum(),
		SeaLevelPressure = dto?.Properties?.SeaLevelPressure?.Value,
		SeaLevelPressureUnit = dto?.Properties?.GetSeaLevelPressureUnitEnum(),
		Visibility = dto?.Properties?.Visibility?.Value,
		VisibilityUnit = dto?.Properties?.GetVisibilityUnitEnum(),
		RelativeHumidityPercent = dto?.Properties?.RelativeHumidity?.Value,
		WindChill = dto?.Properties?.WindChill?.Value,
		WindChillUnit = dto?.Properties?.GetWindChillUnitEnum(),
		HeatIndex = dto?.Properties?.HeatIndex?.Value,
		HeatIndexUnit = dto?.Properties?.GetHeatIndexUnitEnum(),
		RawData = rawContent,
		// TODO: add cloud layers
	};

	public static WeatherStation MapWeatherStation(this StationFeature feature) => new()
	{
		Latitude = feature?.Geometry?.Coordinates[0],
		Longitude = feature?.Geometry?.Coordinates[1],
		Elevation = feature?.Properties?.Elevation?.Value,
		ElevationUnit = feature?.Properties?.Elevation?.UnitCode,
		StationIdentifier = feature?.Properties?.StationIdentifier,
		Name = feature?.Properties?.Name,
		TimeZone = feature?.Properties?.TimeZone,
	};
}
