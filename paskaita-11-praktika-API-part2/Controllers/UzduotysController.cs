using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using paskaita_11_praktika_API_part2.Models;

namespace paskaita_11_praktika_API_part2.Controllers

    /// pasibaigti taska su TRY CATCH tikrinimais ir normaliais erroru kodais
{
    [Route("api/[controller]")]
    [ApiController]
    public class UzduotysController : ControllerBase
    {
        public static List<Uzduotis> Uzduotys { get; set; } = new List<Uzduotis>();


        [HttpGet]

        public IActionResult GautiVisas()
        {
           

            return Ok(Uzduotys);
        }

        [HttpGet("{id}")]

        public void GautiPagalId(int id)
        { }

        [HttpPost]

        public void Sukurti(Uzduotis task) { 

            Uzduotys.Add(task); 

        }

        [HttpPut("{id}")]

        public void Atnaujinti(int id) { }

        [HttpDelete("{id}")]

        public void Istrinti(int id) { }




    }
}
