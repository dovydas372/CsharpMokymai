using System;

namespace Pamoka2_ciklai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("iveskite 5 skaicius");
            //List<int> skaiciai = new List<int>();

            //for (int i = 1; i <= 5; i++)
            //{
            //    skaiciai.Add(int.Parse(Console.ReadLine()));


            //}

            //int suma = 0;
            //foreach (int skaicius in skaiciai)
            //{
            //    suma += skaicius;
            //}


            //Console.WriteLine("Ivestu skaiciu suma yra: " + suma);


            //Console.WriteLine("iveskite skaicius");
            //List<int> skaiciai = new List<int>();

            //while (true)
            //{

            //    string input = Console.ReadLine();
            //    if (input == "")
            //    {
            //        break;
            //    }

            //    skaiciai.Add(int.Parse(input));


            //}

            //int suma = 0;
            //foreach (int skaicius in skaiciai)
            //{
            //    suma += skaicius;
            //}


            //Console.WriteLine("Ivestu skaiciu suma yra: " + suma);


            // CRUD - Create Read Update Delete

            //List<string> vardai = new List<string>();

            //vardai.Add("Tomas");

            //vardai.Add("Antanas");

            //// Read

            //Console.WriteLine(vardai[0]);

            //// Update

            //vardai[0] = "Jonas";

            //Console.WriteLine(vardai[0]);

            //// Delete

            //vardai.RemoveAt(1);

            //Console.WriteLine(vardai[0]);

            // for foreach ir while ciklai

            //int limitas = 5;

            //int kiekKartuPrasisuko = 0;

            //while (kiekKartuPrasisuko < limitas)

            //{

            //    Console.WriteLine("Labas");

            //    kiekKartuPrasisuko++; // kiekKartuPrasisuko = kiekKartuPrasisuko +1;

            //}

            //List<int> skaiciai = new List<int>();

            //for (int i = 0; i < 100; i++)

            //{

            //    Console.WriteLine(i);

            //    skaiciai.Add(i);

            //}

            //foreach (string vardas in vardai) // string vardas = vardai[0]; string vardas = vardai[1];

            //{

            //    Console.WriteLine(vardas);

            //}


            //for (int i = 0; i < vardai.Count; i++)

            //{

            //    Console.WriteLine(vardai[i]);

            //}

            //int index = 0;

            //while (index < vardai.Count)

            //{

            //    Console.WriteLine(vardai[index]);

            //    index++;

            //}

            //List<int> skaiciai = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 5, 7, 4, 9, 5, 4 };

            //foreach (int skaicius in skaiciai)

            //{

            //    if (skaicius == 5)

            //    {

            //        Console.WriteLine("Radau 5");

            //        break;

            //    }

            //    Console.WriteLine(skaicius);

            //}

            // dictionary

            //List<int> mariausPazymiai = new List<int>() { 10, 8, 7, 6, 9 };

            //Dictionary<string, string> zodynas = new Dictionary<string, string>();

            //zodynas.Add("Lietuva", "Vilnius");

            //zodynas.Add("Latvija", "Ryga");

            //// CRUD

            ////Create

            //zodynas["Estija"] = "Talinas"; // Jeigu tokio nera, jis sukurs nauja

            ////Read

            //Console.WriteLine(zodynas["Latvija"]);

            //// Update

            //zodynas["Lietuva"] = "Kaunas"; // jeigu toks raktas jau yra jis atnaujins jo reiksme

            ////Delete

            //zodynas.Remove("Estija");

            //Dictionary<int, double> vietos = new Dictionary<int, double>();

            //vietos[1] = 17.5;

            //vietos[2] = 18.0;

            //Dictionary<string, List<int>> pazymiai = new Dictionary<string, List<int>>();

            //pazymiai["Deividas"] = [7, 5, 10, 9, 4, 9, 10];

            //Dictionary<string, string> zodynas = new Dictionary<string, string>

            //{

            //    { "Latvija","Ryga" },

            //    { "Latvija","Rygele" },


            //};

            //Dictionary<string, string> zodynas = new Dictionary<string, string>();

            //zodynas.Add("Lietuva", "Vilnius");

            //zodynas.Add("Latvija", "Ryga");

            //zodynas["Estija"] = "Talinas";

            //foreach (var item in zodynas)

            //{

            //    Console.WriteLine(item); // [key, value]

            //    Console.WriteLine(item.Key); // key

            //    Console.WriteLine(item.Value); // value

            //}

            //Console.WriteLine(zodynas.Capacity);

            //bool arEgzistuoja = zodynas.ContainsKey("Lietuva");

            //Console.WriteLine(arEgzistuoja);


            //Sukurkite sąrašą ranka kuriame būtų bent 10 skaičių (bent keli pasikartojimai to paties skaičiaus). 

            //Tuomet parašykite programą, kuri suskaičiuos, kiek kiekvieno skaičiaus yra, pvz rezultate spausdintų

            //Skaičiaus 7 yra 3 kartai
            //Skaičiaus 4 yra 2 kartai
            //Skaičiaus 9 yra vienas kartas
            //skaičiaus 2 yra 4 kartai

            List<int> skaiciai = new List<int>() { 10, 10, 8, 7, 8, 7, 6, 9, 6, 10 };
            List<int> skaiciai2 = new List<int>() {};
            Dictionary<int, int> suskirstytiSkaiciai = new Dictionary<int, int>();

            foreach (int skaicius in skaiciai)
            {
                if (suskirstytiSkaiciai.ContainsKey(skaicius))
                {
                    suskirstytiSkaiciai[skaicius]++;
                }
                else
                {
                    suskirstytiSkaiciai[skaicius] = 1;
                }
            }

            foreach (var item in suskirstytiSkaiciai)
            {
                Console.WriteLine($"Skaičius {item.Key} yra {item.Value} kartai");
            }

            int skaiciusValue = 0;
            int skaiciusKey = 0;

            foreach (var item in suskirstytiSkaiciai)
            {
              
                if (item.Value > skaiciusValue)
                {
                    skaiciusValue = item.Value;
                    skaiciusKey = item.Key;
                }
               

            }

            Console.WriteLine($"Didžiausias pasikartojantis skaičius yra {skaiciusKey} pasikartojo {skaiciusValue} kartų");
        }
    }
}

