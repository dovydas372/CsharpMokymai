using System.ComponentModel.DataAnnotations;

namespace paskaita_11_praktika_API_part2.Models
{
    public class Klientas
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "privalomas vardas")]
        [Length (2,30)]
        public string Vardas { get; set; }
        [Required(ErrorMessage = "privalomas el. paštas")]
        [EmailAddress(ErrorMessage = "neteisingas el. pašto fromatas")]
        public string ElPastas { get; set; }

    }
}
