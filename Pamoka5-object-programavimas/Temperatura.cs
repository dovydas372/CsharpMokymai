using System;
using System.Collections.Generic;
using System.Text;

namespace Pamoka5_object_programavimas
{
    internal class Temperatura
    {
        public int Celsius { get; set; }

        public Temperatura(int celsius)
        {
            Celsius = celsius;
        }

        public double ToFahrenheit()
        {
            double farneheit = (Celsius * 9 / 5) + 32;
           return farneheit;
        }
        public double ToKelvin()
        {
            double kelvinai = Celsius + 273.15;

            return kelvinai;
        }
    }
}
