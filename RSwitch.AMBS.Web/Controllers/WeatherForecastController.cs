using Microsoft.AspNetCore.Mvc;

namespace RSwitch_AMBS_Integration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpGet]
        [Route("[action]")]
        public decimal Divide(decimal a, decimal b)
        {
            try
            {
                return (a / b);
            }
            catch (Exception ex)
            {
                _logger.LogInformation("Error in Divide Method - Value of a is {a}", a);
                _logger.LogInformation("Error in Divide Method - Value of b is {b}", b);
                _logger.LogError(ex, "Error in Divide Method");
                return 0;
            }
        }
    }
}