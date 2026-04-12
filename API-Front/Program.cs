using System.Net.Http.Json;

namespace API_Front
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any button to continue");
            Console.ReadLine();
            // setup http client

            while (true)
            {
                Console.WriteLine("Pasirinkite veiksmą:");
                Console.WriteLine("1. Gauti žmonių sąrašą");
                Console.WriteLine("2. Įterpti naują žmogų");

                var pasirinkimas = Console.ReadLine();
                if (pasirinkimas == "1")
                {
                    HttpClient client = new HttpClient();

                    var response = client.GetAsync("https://localhost:7219/api/Weather/GetPeople").Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        Console.WriteLine(content);
                    }
                }
                else if (pasirinkimas == "2")
                {
                    HttpClient client = new HttpClient();
                    PersonDTO person = new PersonDTO
                    {
                        Vardas = "Jonas",
                        Pavarde = "Jonaitis"
                    };
                    var response = client.PostAsJsonAsync("https://localhost:7219/api/Weather/InsertPerson", person).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        Console.WriteLine(content);
                    }
                }
            }
        }
    }
