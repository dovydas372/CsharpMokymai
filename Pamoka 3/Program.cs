namespace Pamoka3_metodai
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SkaičiuSandauga(1, 2, 3));
            List<int> list = new List<int>() { 4, 7, 9, 3, 5, 4, 7 };
            Console.WriteLine(SąrašoSkaičiųSuma(list));
            List<int> ZodynoList = new List<int>() { 1, 2, 9, 4, 5, 6 };
            Dictionary<int, int> Zodynas = PasikartojamuSkaiciuSkaiciuokle(ZodynoList);
            SpausdintiZodyna(Zodynas);

            MaxValuePrint(DidziausiasPasikartojantisSkaicius(Zodynas));


            foreach (int i in SarasuSutapimas(list, ZodynoList))
            {
                Console.WriteLine(i);
            }
        }
        static int SkaičiuSandauga(int sk1, int sk2, int sk3)
        {
            return sk1 * sk2 * sk3;
        }

        static int SąrašoSkaičiųSuma(List<int> skaičiai)
        {
            int sum = 0;
           foreach (int skaičius in skaičiai)
            {
                sum += skaičius;
            }
           return sum;



        }

        //static int VienodųSkaičiųSkaičiuoklė(List<int> skaičiai)
        //{

        //}
        static Dictionary<int, int> PasikartojamuSkaiciuSkaiciuokle(List<int> skaiciai)
        {
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
            return suskirstytiSkaiciai;
        }

        static void SpausdintiZodyna(Dictionary<int, int> zodynas)
        {
            foreach (var item in zodynas)
            {
                Console.WriteLine($"Skaičius {item.Key} yra {item.Value} kartai");
            }
        }

        static KeyValuePair<int, int> DidziausiasPasikartojantisSkaicius(Dictionary<int,int> zodynas)
        {
            int skaiciusValue = 0;
            int skaiciusKey = 0;
            KeyValuePair<int, int> skaiciusItem = zodynas.First();
            foreach (var item in zodynas)
            {

                if (item.Value > skaiciusValue)
                {
                    skaiciusValue = item.Value;
                    skaiciusKey = item.Key;
                    skaiciusItem = item;
                }


            }
            return skaiciusItem;

        }

        static void MaxValuePrint(KeyValuePair<int, int> item)
        {
            Console.WriteLine($"didziausias skaicius: {item.Key} jis pasikartojo: {item.Value} kartu");
        }

        static List<int> SarasuSutapimas(List<int> list1, List<int> list2)
        {
            List<int> bendrasList = new List<int>(); 

            foreach(var item in list1)
            {
                foreach(var item2 in list2)
                {
                   if (item == item2)
                    {
                        bendrasList.Add(item);
                    }
                }
            }

            return bendrasList;
        }
    }
}
