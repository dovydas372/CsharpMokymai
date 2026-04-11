using Microsoft.AspNetCore.Mvc;

namespace API_ND_26_04_11.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VartotojaiController : ControllerBase
    {


        [HttpGet("vartotojuSarasas")]
        public IActionResult GautiVartotojus()
        { 
            return Ok(new string[] { "Jonas", "Petras" });
        }

        [HttpGet("{Id}")]
        public IActionResult GautiVartotoja([FromRoute]int Id)
        {
            return Ok($"Vartotojo ID yra: {Id}");
        }

        [HttpGet]
        public IActionResult Testas()
        {
            string zinute = "Viskas veikia!";
            return Ok(zinute);
        }


    }
}
