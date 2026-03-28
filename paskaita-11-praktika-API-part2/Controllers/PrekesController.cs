using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using paskaita_11_praktika_API_part2.Models;

namespace paskaita_11_praktika_API_part2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrekesController : ControllerBase
    {

        public static List<Preke> PrekiuSarasas { get; set; } = new List<Preke>();

        [HttpPost()]
        public IActionResult SukurtiPreke(Preke naujaPreke)
        {
            try
            {
                if (naujaPreke == null)
                {
                    return BadRequest("Neatsiųsti prekės duomenys.");
                }
                naujaPreke.Id = PrekiuSarasas.Count + 1;
                PrekiuSarasas.Add(naujaPreke);
                return Created($"/api/Prekes/{naujaPreke.Id}", naujaPreke);

            }
            catch (Exception ex)
            {
                return Problem(
                    detail: $"{ex}",
                    statusCode: 500,
                    title: "Serverio klaida",
                    type: "https://httpstatuses.com/500"
                    );
            }
        }
    }
}
