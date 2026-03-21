using Microsoft.AspNetCore.Mvc;

namespace paskaita_10_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries =
        [
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        ];

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


        [HttpGet("vardukas")] // endpoint
        public string GetVardas()
        {
            //jeigu klaida
            //return BadRequest("Ivyko klaida")
            return "Tomas";
        }



        [HttpGet("Tikrinimas")] // endpoint
        public IActionResult skaiciausTikrinimas(int skaicius)
        {
            if (skaicius > 0)
            {
                return Ok($"Sveiki jums yra: {skaicius} metų");

            }
            return BadRequest("skaicius mažesnis už 0");
        }
    }
}
