using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StubscribeAngular.API.Controllers
{
    //client will try to access http://localhost:5000/api/{nameofcontroller}
    //app.UseRouting() (?) in Startup.cs will route to the controller and call the method(s) within to return values
    //a GET request will route via [HttpGet()] & a POST will route via [HttpPost()] etc (HttpPUT, HttpDELETE)
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

        // GET api/WeatherForecast
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        //make method so as to add a key?
        [HttpGet("{id}")]
        public ActionResult<string> GetAction(int id) {
            return "value";
        }
    }
}
