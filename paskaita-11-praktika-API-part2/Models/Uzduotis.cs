using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace paskaita_11_praktika_API_part2.Models
{
    public class Uzduotis
    {
        public int Id { get; set; }

        [Required]
        [Length(6,50,ErrorMessage = "Netinkamas pavadinimo ilgis")]
        public string Pavadinimas { get; set; }
        public bool ArAtlikta { get; set; }

        public Uzduotis( string pavadinimas, bool arAtlikta)
        {
            
            Pavadinimas = pavadinimas;
            ArAtlikta = arAtlikta;
        }
    }
}


//. Duomenų validacija (Prekės API)
//Tema: Data Annotations naudojimas([Required], [Range], [MaxLength]).
//Modelis(Klasė): Preke
//Atributai: Id(int), Pavadinimas(string), Kaina(decimal).
//Užduotis: Modelyje pridėkite validacijas: pavadinimas privalomas ir ne ilgesnis nei 50 simbolių, kaina privalo būti nuo 0.1 iki 1000. Sukurkite POST metodą naujai prekei priimti.
//Papildomai drąsesniems: Į validacijos atributus įrašykite savo custom klaidų žinutes (pvz., [Required(ErrorMessage = "Pavadinimas yra būtinas!")]). Pastebėkite, kaip .Net pats grąžina 400 statusą, jei duomenys blogi.