using BlazorProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;

namespace RazorProject.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly WeatherForecastService _weatherForecastService;
    public List<WeatherForecast> Forecasts { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }
    public IndexModel(WeatherForecastService weatherForecastService)
    {
        _weatherForecastService = weatherForecastService;
    }

    public async Task OnGetAsync()
    {
        Forecasts = await _weatherForecastService.GetWeatherForecastsAsync();
    }
    public void OnGet()
    {
       
    }
}
