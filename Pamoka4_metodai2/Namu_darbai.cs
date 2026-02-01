using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Pamoka4_metodai2
{
    internal class Namu_darbai
    {
        static void Main(string[] args)
        {
            //2)
            //var dictionary = new Dictionary<string, int> {{ "apple", 5 },{ "banana", 5 }};
            //   printDictionary(dictionary);
            //   Console.WriteLine($" {sandelys(dictionary, 6, "apple", out int pavykoPaimti)}, paime: {pavykoPaimti}");

            //1)
            //string? words = Console.ReadLine();
            //printDictionary(wordCounter(words ?? string.Empty));

            ////2)
            //    var students = new Dictionary<string, List<int>>
            //    {
            //        { "Jonas", new List<int> { 8, 9, 10 } },
            //        { "Ona",   new List<int> { 7, 7, 8 } },
            //        { "Tomas", new List<int> { 10, 10, 9 } }
                  
            //    };

            //getAverage(students, "Ona", out double average);
            //Console.WriteLine($" studento vidurkis: { average}");

            
            //Console.WriteLine("didziausias average:" + getHigestAverage(students));
        }

       static void printDictionary(Dictionary<string, int> sandelys)
        {
           
                foreach (var item in sandelys)
                {
                    Console.WriteLine($"key: {item.Key} value: {item.Value}");
                }
        }


        //  0) Sukurk funkciją, kuri bando paimti iš sandėlio(Dictionary<string, int>) tam tikrą prekės kiekį taip, kad sandėlis po iškvietimo būtų atnaujintas.
        //Per out grąžink, kiek realiai pavyko paimti, o su return grąžink ar pavyko paimti visą prašytą kiekį.

        static string sandelys(Dictionary<string, int> sandelys, int kiekPaimti, string prekesPav, out int pavykoPaimti)
        {
            pavykoPaimti = 0;
            if (sandelys.ContainsKey(prekesPav))
            {
                int paimtosPrekes = sandelys[prekesPav] - kiekPaimti;
                if (paimtosPrekes >= 0)
                {
                    sandelys[prekesPav] = paimtosPrekes;
                    pavykoPaimti = kiekPaimti;
                    return "pavyko paimti visa kieki";
                }
                else
                {
                    pavykoPaimti = paimtosPrekes + kiekPaimti;
                    sandelys[prekesPav] = 0;
                    return "nepavyko paimti viso kiekio";
                }

            }

            return "tokios prekes nera";

        }

        //    1) „Žodžių skaičiuoklė“ (Dictionary)
        //Duota eilutė teksto.Suskaičiuok, kiek kartų pasikartoja kiekvienas žodis (nepaisant didžiųjų/mažųjų raidžių).
        //Reikalavimai:
        //Skirtukais laikyk tarpus ir pagrindinius skyrybos ženklus(.,!?;:).


        static Dictionary<string, int> wordCounter(string words)
        {
            Dictionary<string, int> sameWords = new Dictionary<string, int> { };
            List<string> wordsList = words.ToLower().Split(new[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string word in wordsList)
            {
                if (sameWords.ContainsKey(word))
                {
                    sameWords[word]++;
                }
                else
                {
                    sameWords[word] = 0;
                }

            }


            return sameWords;
        }

        //2) Studentų pažymiai(Dictionary + List)
        //Turi Dictionary<string, List<int>> (vardas → pažymių sąrašas).
        //Parašyk funkcijas:
        //pridėti pažymį studentui,
        //gauti studento vidurkį,
        //rasti studentą su didžiausiu vidurkiu.

        static void addMark(Dictionary<string, List<int>> students, string studentName, int mark )
        {
            students[studentName].Add( mark );
        }

        static void getAverage(Dictionary<string, List<int>> students, string studentName, out double average)
        {
            average = 0;

            if (students.ContainsKey(studentName))
            {
                average = students[studentName].Average();
            }
        }

        static double getHigestAverage(Dictionary<string, List<int>> students)
        { 
            double maxAverage = 0;
            foreach (var item in students) 
            {

                getAverage(students, item.Key,out double average);
               
               if (average >= maxAverage) {
                    maxAverage = average;
                }
                
            }
        
            return maxAverage;
        }

    }
}
