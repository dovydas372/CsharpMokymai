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
            try
            {
                if (Uzduotys.Count == 0)
                {
                    return Ok("Užduočių sąrašas tuščias.");
                }


                return Ok(Uzduotys);
            }

            catch (Exception)
            {
                return Problem(
                    detail: "Nepavyko gauti užduočių sąrašo.",
                    statusCode: 500,
                    title: "Serverio klaida",
                    type: "https://httpstatuses.com/500"
                );
            }
        }

        [HttpGet("{id}")]

        public ActionResult<Uzduotis> GautiPagalId(int id)
        {
            try
            {
                if (Uzduotys.Count == 0)
                {
                    return BadRequest("Užduočių sąrašas tuščias.");
                }
                else
                {
                    var uzduotis = Uzduotys.FirstOrDefault(uzd => uzd.Id == id);

                    if (uzduotis == null)
                    {
                        return BadRequest($"Užduotis su ID {id} nerasta.");
     
                    }
                    else
                    {

                        return Ok(uzduotis);

                    }

                }
            }

            catch (Exception)
            {
                return Problem(
                    detail: "Nepavyko gauti užduočių sąrašo.",
                    statusCode: 500,
                    title: "Serverio klaida",
                    type: "https://httpstatuses.com/500"
                );

            }

        }

        [HttpPost]

        public IActionResult Sukurti(Uzduotis task)
        {



            try
            {

                if (string.IsNullOrEmpty(task.Pavadinimas))
                {
                    return BadRequest("Neivestas pavadinimas");
                }

                if (task.Id <= 0)
                {
                    return BadRequest("Neteisingas ID.");
                }


                Uzduotys.Add(task);
                return Ok("užduotis pridėta");
            }

            catch (Exception)
            {
                return Problem(
                    detail: "Nepavyko pridėti užduoties",
                    statusCode: 500,
                    title: "Serverio klaida",
                    type: "https://httpstatuses.com/500"
                );
            }

        }

        [HttpPut("{id}")]

        public IActionResult Atnaujinti(int id) {

            try
            {
                if (Uzduotys.Count == 0)
                {
                    return BadRequest("Užduočių sąrašas tuščias.");
                }
                else
                {
                    var uzduotis = Uzduotys.FirstOrDefault(uzd => uzd.Id == id);

                    if (uzduotis == null)
                    {
                        return BadRequest($"Užduotis su ID {id} nerasta.");

                    }
                    else
                    {

                        return Ok(uzduotis = );

                    }

                }
            }

            catch (Exception)
            {
                return Problem(
                    detail: "Nepavyko gauti užduočių sąrašo.",
                    statusCode: 500,
                    title: "Serverio klaida",
                    type: "https://httpstatuses.com/500"
                );

            }

        }

        [HttpDelete("{id}")]

        public void Istrinti(int id) { }




    }
}
