using System;
using System.Collections.Generic;
using System.Text;

namespace PaskaitosND_26_04_11
{
    internal static class ND1
    {


        public static void Nd1()
        {
            Console.WriteLine(" 1 UždavinysTikslas: Atspausdinti visus masyvo elementus.\n");
            int[] skaiciai = { 1, 2, 3, 4, 5 };

            for (int i = 0; i <= skaiciai.Length-1; i++)
            {
                Console.WriteLine(skaiciai[i]);
            }
            
        }



    }
}
