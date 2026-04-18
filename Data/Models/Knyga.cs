namespace paskaita_11_praktika_API_part2.Models
{
    public class Knyga
    {
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public string Autorius { get; set; }

        public Knyga(int id, string pavadinimas, string autorius)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            Autorius = autorius;
         }

    
    }
}
