using System;
using System.Collections.Generic;
using System.Text;

namespace Pamoka5_object_programavimas
{




    internal class Staciakampis
    {
        public int VienaKrastine { get; set; }
        public int AntraKrastine { get; set; }

        public Staciakampis(int krastineA, int krastineB)
        {
            VienaKrastine = krastineA;
            AntraKrastine = krastineB;
        }
        public int Plotas()
        {
            return VienaKrastine * AntraKrastine;
        }
    }

}