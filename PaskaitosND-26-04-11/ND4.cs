using System;
using System.Collections.Generic;
using System.Text;

namespace PaskaitosND_26_04_11
{
    internal class ND4
    {
        public static void Nd4()
        {
            Console.WriteLine(" 7 Uždavinys Tikslas: Iš sąrašo pašalinti visus neigiamus skaičius.\n");
            List<int> skaiciai = new List<int> { 5, -2, 9, -8, 3 };
            List<int> skaiciaiNew = new List<int>(skaiciai);
            
            foreach (int skaicius in skaiciai)
            {
                if (skaicius < 0)
                {
                   skaiciaiNew.Remove(skaicius);
                }

            }

            foreach (int i in skaiciaiNew)
            {
                Console.WriteLine(i);
            }
        }
    }
}
