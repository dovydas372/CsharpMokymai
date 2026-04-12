using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
namespace ToDoConsoleClient
{
    // Modelis, atitinkantis tavo APIpublic class Uzduotis    {        public int Id { get; set; }

}
class Program
{        // Paprasčiausias būdas naudoti HttpClient konsolėje (be DI)private static readonly HttpClient client = new HttpClient();
         // Pakeisk šį URL į tą, ant kurio sukasi tavo API (pvz., https://localhost:7001)private static readonly string baseUrl = "https://localhost:<TAVO_PORTAS>/api/uzduotys";

    static async Task Main(string[] args)
    {
        bool veikia = true;
        while (veikia)
        {
            Console.WriteLine("\n--- ToDo Klientas ---");
            Console.WriteLine("1. Gauti visas užduotis");
            Console.WriteLine("2. Gauti užduotį pagal ID");
            Console.WriteLine("3. Sukurti naują užduotį");
            Console.WriteLine("4. Pažymėti užduotį kaip atliktą (Atnaujinti)");
            Console.WriteLine("5. Ištrinti užduotį");
            Console.WriteLine("0. Išeiti");
            Console.Write("Pasirinkite veiksmą: ");

            string pasirinkimas = Console.ReadLine();

            try
            {
                switch (pasirinkimas)
                {
                    case "1": await GautiVisas(); break;
                    case "2": await GautiPagalId(); break;
                    case "3": await SukurtiUžduotį(); break;
                    case "4": await AtnaujintiUžduotį(); break;
                    case "5": await IstrintiUžduotį(); break;
                    case "0": veikia = false; break;
                    default: Console.WriteLine("Neteisingas pasirinkimas."); break;
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"\n[KLAIDA] Nepavyko susisiekti su API. Ar tikrai paleidai API projektą? Detalės: {ex.Message}");
            }
        }
    }
    static async Task GautiVisas()
    {
        Console.WriteLine("\n--- Visos užduotys ---");
        HttpClient client = new HttpClient();

        var response = client.GetAsync("https://localhost:7219/api/Weather/GetPeople").Result;
        if (response.IsSuccessStatusCode)
        {
            var content = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(content);
        }
    }

    static async Task GautiPagalId()
    {
        Console.Write("Įveskite ieškomos užduoties ID: ");
        string idInput = Console.ReadLine();

        // TODO: Užduotis #3// 1. Padaryk GET requestą į $"{baseUrl}/{idInput}"// 2. Patikrink, ar atsakymo statusas yra sėkmingas (IsSuccessStatusCode).// 3. Jei statusas yra 404 (NotFound) - atspausdink "Užduotis nerasta".// 4. Jei sėkmingas, deserializuok ir atspausdink užduotį.
    }

    static async Task SukurtiUžduotį()
    {
        Console.Write("Įveskite naujos užduoties pavadinimą: ");
        string pavadinimas = Console.ReadLine();

        // TODO: Užduotis #2// 1. Sukurk naują 'Uzduotis' objektą (Id gali palikti 0, API turėtų pats jį sugeneruoti; ArAtlikta = false).// 2. Serializuok objektą į JSON stringą.// 3. Sukurk StringContent objektą (nurodyk UTF8 encoding'ą ir media type "application/json").// 4. Išsiųsk POST requestą (PostAsync).// 5. Patikrink ar pavyko ir pranešk vartotojui.
    }

    static async Task AtnaujintiUžduotį()
    {
        Console.Write("Įveskite užduoties, kurią norite pažymėti kaip atliktą, ID: ");
        string idInput = Console.ReadLine();

        // TODO: Užduotis #4// 1. Pirmiausia atlik GET requestą pagal šį ID, kad gautum esamą užduotį (kaip Užduotyje #3).// 2. Jei grąžino 404 - pranešk, kad tokios užduoties nėra, ir baik metodo darbą (return).// 3. Jei užduotis egzistuoja, pakeisk jos 'ArAtlikta' reikšmę į true.// 4. Serializuok atnaujintą objektą į JSON.// 5. Išsiųsk PUT requestą (PutAsync) į $"{baseUrl}/{idInput}".// 6. Pranešk vartotojui apie sėkmę.
    }

    static async Task IstrintiUžduotį()
    {
        Console.Write("Įveskite užduoties ID, kurią norite ištrinti: ");
        string idInput = Console.ReadLine();

        // TODO: Užduotis #5// 1. Išsiųsk DELETE requestą (DeleteAsync) į $"{baseUrl}/{idInput}".// 2. Patikrink atsakymo statusą.// 3. Jei statusas 404 (NotFound) - pranešk "Nepavyko ištrinti: užduotis nerasta".// 4. Jei sėkmingas - pranešk "Užduotis ištrinta".
    }
}

 