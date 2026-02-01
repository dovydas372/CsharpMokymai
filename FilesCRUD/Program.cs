namespace FilesCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File.WriteAllText("naujas.txt", "Sveiki, kaip sekasi ?"); // jeigu nera failo ji sukuria, o jeigu yra istrina visa jo turini ir iraso kas pasakyta
            //File.AppendAllText("naujas.txt", $"Kaip reikaliukai ?"); // jis neistrina, bet jeigu failo nera ji sukuria
            //File.AppendAllLines("naujas.txt", new List<string> { "Cia yra apendas", "Viskas apende vyksta", "Paziurekime, kaip veikia apendas" });

            //create
            File.WriteAllText("naujas.txt", "mano naujas failas");

            //Read

            Console.WriteLine(File.ReadAllText("naujas.txt"));

            //Edit/Update
            File.AppendAllText("naujas.txt", $"\npapildomas naujas tekstas");
            File.AppendAllLines("naujas.txt", new List<string> { "\nNaujas Lines", "Naujas Lines" });

            //delete

            //File.Delete("naujas.txt");




            Console.WriteLine(File.ReadAllText("naujas.txt"));

        }
    }
}
