using System.ComponentModel.DataAnnotations;

namespace paskaita_11_praktika_API_part2.Models
{
    public class Preke
    {
        public int Id { get; set; }

        [Required (ErrorMessage = "Pavadinimas yra būtinas!")]
        [MaxLength(50, ErrorMessage = "Per ilgas pavadinimas!")]
        public string Pavadinimas { get; set; }

        [Range(1,1000,ErrorMessage ="Per didelė kaina!")]
        public int Kaina { get; set; }

    }
}
