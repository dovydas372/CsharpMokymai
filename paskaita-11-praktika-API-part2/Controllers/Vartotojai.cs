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
            if(user.Email.Contains("@"))
             return Ok($"Vartotojas vardu:{user.Name}. Sekmingia sukurtas!");
            return BadRequest($"neteisingas Email formatas");

           
        }

    }
}
