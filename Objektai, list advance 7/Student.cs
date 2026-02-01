using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Paskaita7_Objektai_list_advance_LinQ
{
    internal class Student2
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public int Amzius { get; set; }

        public Student2(string vardas, string pavarde, int amzius)
        {
        
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
        }


    }
}
