using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using paskaita_11_praktika_API_part2.Models;

namespace paskaita_11_praktika_API_part2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlientaiController : ControllerBase
    {
        public List<Klientas> Klientai { get; set; } = new List<Klientas>();  

        public IActionResult SukurtiKlienta(Klientas klientas)
        {
            try
            {
                klientas.Id = Klientai.Count + 1;

                Klientai.Add(klientas);

                return Created($"/api/Klientai/{klientas.Id}", klientas);

            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
