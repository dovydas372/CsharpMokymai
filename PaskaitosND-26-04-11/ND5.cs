using System;
using System.Collections.Generic;
using System.Text;

namespace PaskaitosND_26_04_11
{
    internal class ND5
    {
        public static List<string> Vartotojai { get; set; } = new List<string>();
        public static void Nd5(string vardas)
        {
            Console.WriteLine(" 9 UždavinysTikslas: Pridėti naują elementą į vartotojų sąrašą.\n");


            Vartotojai.Add(vardas);

        }
    }
}
