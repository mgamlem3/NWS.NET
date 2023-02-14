using NWS.Dtos;
using NWS.Dtos.Components.ForecastDto;
using NWS.Dtos.Components.StationDto;
using NWS.NET.Common.Objects;
using NWS.Units;

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
			ElevationUnit = dto.Properties.Elevation.Value is null ? null : NWSUnits.Map(dto.Properties.Elevation.UnitCode),
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
			TemperatureUnit = dto.Temperature is null ? null : NWSUnits.Map(dto.TemperatureUnit),
			TemperatureTrend = dto.TemperatureTrend,
			WindSpeed = windSpeed,
			WindDirection = dto.WindDirection,
			ShortForecastDescription = dto.ShortForecast,
			LongForecastDescription = dto.DetailedForecast,
		};
	}

	public static CurrentConditions MapObservation(this ObservationDto dto, WeatherStation? station = null, string? rawContent = null) => new()
	{
		ObservationDate = dto?.Properties?.Timestamp,
		WeatherStation = station,
		Temperature = dto?.Properties?.Temperature?.Value,
		TemperatureUnit = dto?.Properties?.Temperature?.Value is null ? null : NWSUnits.Map(dto?.Properties?.Temperature?.UnitCode),
		Description = dto?.Properties?.TextDescription,
		DewPoint = dto?.Properties?.Dewpoint?.Value,
		DewPointUnit = dto?.Properties?.Dewpoint?.Value is null ? null : NWSUnits.Map(dto?.Properties?.Dewpoint?.UnitCode),
		WindDirection = dto?.Properties?.WindDirection?.Value,
		WindSpeed = dto?.Properties?.WindSpeed?.Value,
		WindSpeedUnit = dto?.Properties?.WindSpeed?.Value is null ? null : NWSUnits.Map(dto?.Properties?.WindSpeed?.UnitCode),
		WindGust = dto?.Properties?.WindGust?.Value,
		WindGustUnit = dto?.Properties?.WindGust?.Value is null ? null : NWSUnits.Map(dto?.Properties?.WindGust?.UnitCode),
		BarometricPressure = dto?.Properties?.BarometricPressure?.Value,
		BarometricPressureUnit = dto?.Properties?.BarometricPressure?.Value is null ? null : NWSUnits.Map(dto?.Properties?.BarometricPressure?.UnitCode),
		SeaLevelPressure = dto?.Properties?.SeaLevelPressure?.Value,
		SeaLevelPressureUnit = dto?.Properties?.SeaLevelPressure?.Value is null ? null : NWSUnits.Map(dto?.Properties?.SeaLevelPressure?.UnitCode),
		Visibility = dto?.Properties?.Visibility?.Value,
		VisibilityUnit = dto?.Properties?.Visibility?.Value is null ? null : NWSUnits.Map(dto?.Properties?.Visibility?.UnitCode),
		RelativeHumidityPercent = dto?.Properties?.RelativeHumidity?.Value,
		WindChill = dto?.Properties?.WindChill?.Value,
		WindChillUnit = dto?.Properties?.WindChill?.Value is null ? null : NWSUnits.Map(dto?.Properties?.WindChill?.UnitCode),
		HeatIndex = dto?.Properties?.HeatIndex?.Value,
		HeatIndexUnit = dto?.Properties?.HeatIndex?.Value is null ? null : NWSUnits.Map(dto?.Properties?.HeatIndex?.UnitCode),
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
