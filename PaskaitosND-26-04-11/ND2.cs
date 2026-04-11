using System;
using System.Collections.Generic;
using System.Text;

namespace PaskaitosND_26_04_11
{
    internal class ND2
    {
        public static void Nd2()
        {
            Console.WriteLine(" 2 UždavinysTikslas: Pakeisti žodyje visas „a“ raides į „o“ ir atspausdinti rezultatą.\n");
            string tekstas = "bananas";
            tekstas = tekstas.Replace("a", "o");

            Console.WriteLine(tekstas);
        }
    }
}
