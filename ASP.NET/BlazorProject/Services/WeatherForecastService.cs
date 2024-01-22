namespace BlazorProject.Services
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Models; // Assuming WeatherForecast model is in this namespace

    public class WeatherForecastService(HttpClient httpClient)
    {
        public async Task<List<WeatherForecast>> GetWeatherForecastsAsync()
        {
            string url = "https://localhost:44309/WeatherForecast";
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<WeatherForecast>>(responseBody);
        }
    }

}
