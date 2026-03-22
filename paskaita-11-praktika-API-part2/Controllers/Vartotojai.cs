using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using paskaita_11_praktika_API_part2.Models;

namespace paskaita_11_praktika_API_part2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Vartotojai : ControllerBase
    {

        [HttpPost("Vartotojas")]
        public IActionResult SukurtiVartotoja(User user)
        {
            try
            {
                if (user == null)
                {
                    return BadRequest("Neatsiųsti vartotojo duomenys.");
                }

                if (string.IsNullOrEmpty(user.Name))
                {
                    return BadRequest("Neįvestas vartotojo vardas.");
                }

                if (string.IsNullOrEmpty(user.Email))
                {
                    return BadRequest("Neįvestas el. paštas.");
                }

                if (!user.Email.Contains("@"))
                {
                    return BadRequest("Neteisingas Email formatas.");
                }

                return Ok($"Vartotojas vardu: {user.Name} sėkmingai sukurtas!");
            }
            catch (Exception)
            {
                return Problem(
                    detail: "Nepavyko sukurti vartotojo.",
                    statusCode: 500,
                    title: "Serverio klaida",
                    type: "https://httpstatuses.com/500"
                );
            }


        }

    }
}
