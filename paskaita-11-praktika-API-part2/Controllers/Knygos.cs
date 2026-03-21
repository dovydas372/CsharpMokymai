using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using paskaita_11_praktika_API_part2.Models;
namespace paskaita_11_praktika_API_part2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Knygos : ControllerBase
    {
        [HttpGet("knyga")]

        public IActionResult GautiKnygas()
        {
            var knygosList = new List<Knyga>
            {


            };

            if (knygosList.Count() > 0)
            {

                return Ok(knygosList);

            }

            return NotFound("Nerasta knygu");

        }

    }



}




