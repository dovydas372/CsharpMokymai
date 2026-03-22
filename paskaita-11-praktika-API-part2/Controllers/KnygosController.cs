using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using paskaita_11_praktika_API_part2.Models;
namespace paskaita_11_praktika_API_part2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnygosController : ControllerBase
    {

        public static List<Knyga> KnyguSarasas { get; set; } = new List<Knyga> { new Knyga(10, "Dogma", "J.Peterson") };

        [HttpGet("knyga")]
        public ActionResult GautiKnygas()
        {
            try
            {
                if (KnyguSarasas.Count == 0)
                {
                    return BadRequest("Knygų sąrašas tuščias.");
                }
                else
                {
                    return Ok(KnyguSarasas);
                }
            }

            catch (Exception)
            {
                return Problem(
                    detail: "Nepavyko gauti knygų sąrašo.",
                    statusCode: 500,
                    title: "Serverio klaida",
                    type: "https://httpstatuses.com/500"
                );
            }
        }

    }



}




