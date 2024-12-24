using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace WebDevelopmentAndAPI.FifthDay.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : Controller
    {
        private WeatherApiClient weatherApiClient;

        public WeatherController(WeatherApiClient weatherApiClient)
        {
            this.weatherApiClient = weatherApiClient;
        }

        [HttpGet("{location}")]
        public async Task<IActionResult> GetCurrentWeather(string location)
        {
            string apiKey = "88261a0e354d4cd7b6b85443241312";
            var weatherData = await weatherApiClient.GetCurrentWeatherAsync(apiKey, location);

            if (weatherData == null)
            {
                return NotFound();
            }

            var weatherJson = JObject.Parse(weatherData);

            var response = new WeatherResponse
            {
                City = weatherJson?["location"]?["name"]?.ToString() ?? "Unknown",
                Temperature = weatherJson?["current"]?["temp_c"]?.Value<double>() ?? 0.0,
                WindSpeed = weatherJson?["current"]?["wind_kph"]?.Value<double>() ?? 0.0
            };

            return Ok(response);
        }
    }
}
