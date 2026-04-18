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
        public static List<Uzduotis> Uzduotys { get; set; } = new List<Uzduotis>
        {
         new Uzduotis("Uzduotis1", true)
        };


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
                    detail: $"Nepavyko gauti užduočių sąrašo.",
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


                    return Ok(uzduotis);



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

        public IActionResult Sukurti(Uzduotis siunciamaUzduotis)
        {



            try
            {

                if (string.IsNullOrEmpty(siunciamaUzduotis.Pavadinimas))
                {
                    return BadRequest("Neivestas pavadinimas");
                }

                if (siunciamaUzduotis.Id <= 0)
                {
                    return BadRequest("Neteisingas ID.");
                }


                Uzduotys.Add(siunciamaUzduotis);
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

        public IActionResult Atnaujinti(int id, Uzduotis atsiustaUzduotis)
        {

            try
            {
                if (Uzduotys.Count == 0)
                {
                    return BadRequest("Užduočių sąrašas tuščias.");
                }
                else
                {

                    if (atsiustaUzduotis == null)
                    {
                        return BadRequest("Neatsiųsti užduoties duomenys.");
                    }

                    var uzduotiesIndex = Uzduotys.FindIndex(uzd => uzd.Id == id);

                    if (uzduotiesIndex == -1)
                    {
                        return NotFound($"Užduotis su ID {id} nerasta.");

                    }
                    else
                    {
                        if (string.IsNullOrEmpty(atsiustaUzduotis.Pavadinimas))
                        {
                            return BadRequest("Neivestas pavadinimas");
                        }
                        atsiustaUzduotis.Id = id;
                        Uzduotys[uzduotiesIndex] = atsiustaUzduotis;
                        return Ok($"Sėkmingai paupdeitinta uzduotis su ID: {id}");

                    }

                }
            }

            catch (Exception)
            {
                return Problem(
                    detail: "Nepavyko atnaujinti užduoties.",
                    statusCode: 500,
                    title: "Serverio klaida",
                    type: "https://httpstatuses.com/500"
                );

            }

        }

        [HttpDelete("{id}")]

        public IActionResult Istrinti(int id)
        {

            try
            {
                if (Uzduotys.Count == 0)
                {
                    return BadRequest("Užduočių sąrašas tuščias.");
                }
                else
                {

                    var uzduotiesIndex = Uzduotys.FindIndex(uzd => uzd.Id == id);

                    if (uzduotiesIndex == -1)
                    {
                        return NotFound($"Užduotis su ID {id} nerasta.");

                    }
                    else
                    {


                        Uzduotys.RemoveAt(uzduotiesIndex);
                        return Ok($"Sėkmingai ištrinta uzduotis su ID: {id}");

                    }

                }
            }

            catch (Exception)
            {
                return Problem(
                    detail: "Nepavyko ištrinti užduoties.",
                    statusCode: 500,
                    title: "Serverio klaida",
                    type: "https://httpstatuses.com/500"
                );

            }


        }




    }
}
