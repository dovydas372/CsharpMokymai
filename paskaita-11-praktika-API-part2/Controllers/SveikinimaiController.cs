using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace paskaita_11_praktika_API_part2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SveikinimaiController : ControllerBase
    {

        [HttpGet("sveikinimai2")]

        public string Gautisveikinimai()
        {
            return "Sveikas, pasauli! API veikia.";
        }

        [HttpGet("sveikinimaiVardas")]
        public string Gautisveikinimai2([FromQuery]string vardas)
        {
            return $"Sveikas, {vardas}! API veikia.";
        }

    }
}
