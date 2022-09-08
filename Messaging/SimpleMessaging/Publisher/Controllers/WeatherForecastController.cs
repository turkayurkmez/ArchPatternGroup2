using MassTransit;
using Messages;
using Microsoft.AspNetCore.Mvc;

namespace Publisher.Controllers
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
        private readonly IPublishEndpoint publishEndpoint;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IPublishEndpoint publishEndpoint)
        {
            _logger = logger;
            this.publishEndpoint = publishEndpoint;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost]
        public IActionResult CreateRoomReservation()
        {
            BookCreatedEvent bookCreatedEvent = new BookCreatedEvent()
            {
                CheckInDate = DateTime.Now.AddDays(2),
                Duration = 2,
                Email = "bitatillazim@gmail.com"

            };

            publishEndpoint.Publish(bookCreatedEvent);
            return Ok(new { message = "Booking event sended to Rabbit MQ" });
        }
    }
}