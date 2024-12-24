namespace WebDevelopmentAndAPI.FifthDay
{
    public class WeatherApiClient
    {
        private HttpClient httpClient;

        public WeatherApiClient()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api.weatherapi.com/v1/");
        }

        public async Task<string?> GetCurrentWeatherAsync(string apiKey, string location)
        {
            string url = $"current.json?key={apiKey}&q={location}&aqi=yes";

            try
            {
                var response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Ошибка передачи данных: {e.Message}");
                return null;
            }
        }
    }
}
