namespace paskaita_11_praktika_API_part2.Models
{
    public class Uzduotis
    {
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public bool ArAtlikta { get; set; }

        public Uzduotis(int id, string pavadinimas, bool arAtlikta)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            ArAtlikta = arAtlikta;
        }
    }
}
