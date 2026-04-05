using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using paskaita_11_praktika_API_part2.Models;

namespace paskaita_11_praktika_API_part2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmaiController : ControllerBase
    {

        public List<Filmas> Filmai { get; set; } = new List<Filmas>{
            new Filmas { Pavadinimas = "Inception", Zanras = "Sci-Fi", IsleidimoMetai = 2010 },
            new Filmas { Pavadinimas = "Titanic", Zanras = "Drama", IsleidimoMetai = 1997 },
            new Filmas { Pavadinimas = "Interstellar", Zanras = "Sci-Fi", IsleidimoMetai = 2014 },
            new Filmas { Pavadinimas = "The Godfather", Zanras = "Crime", IsleidimoMetai = 1972 }
        };

        [HttpGet("filmai")]
        public IActionResult filmuPaieska(string? zanras, int? metai)
        {
            try
            {

                // Pradedame nuo viso sąrašo
                var rezultatas = Filmai.AsEnumerable();

                // 1. Filtruojame pagal žanrą (Case-insensitive + dalinis atitikimas)
                if (!string.IsNullOrWhiteSpace(zanras))
                {
                    rezultatas = rezultatas.Where(f =>
                        f.Zanras.Contains(zanras, StringComparison.OrdinalIgnoreCase));
                    return Ok(rezultatas);
                }

                // 2. Filtruojame pagal metus
                if (metai.HasValue)
                {
                    rezultatas = rezultatas.Where(f => f.IsleidimoMetai == metai.Value);
                    return Ok(rezultatas);
                }

                return Ok(rezultatas);
                //if (string.IsNullOrWhiteSpace(zanras))
                //{


                //    if (metai.HasValue)
                //    {
                //        List<Filmas> filmaiM = Filmai.Where(f => f.IsleidimoMetai == metai).ToList();
                //        return Ok(filmaiM);
                //    }

                //    return Ok(Filmai);

                //}
                //if (metai.HasValue)
                //{
                //    List<Filmas> filmaiMZ = Filmai.Where(f => f.Zanras == zanras && f.IsleidimoMetai == metai).ToList();
                //    return Ok(filmaiMZ);
                //}

                //var filmaiF = Filmai.Where(f => f.Zanras == zanras);

                //return Ok(filmaiF);
            }
            catch (Exception ex)

            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("slaptiFilmai")]
        public IActionResult slaptiFilmai()
        {
            try
            {
                var slaptasKodas = Request.Headers["API-Key"].ToString();

                if (slaptasKodas == "SuperSlaptas123")
                {
                    return Ok("api raktas tinkamas");
                }
                return BadRequest("api raktas netinkamas");

            }
            catch(Exception ex) { 
            return BadRequest(ex.Message);
            }
        
        }

    }
}
