using System;
using System.Collections.Generic;
using System.Text;

namespace Objektai__list_advance_7.ND._5_Maksimali_reikšmė
{
    internal class Car
    {
        public string Model { get; set; }
        public string Mark { get; set; }
        public int Range { get; set; }

        public Car(string model, string mark, int range) 
        {
            Model = model;
            Mark = mark;
            Range = range;
        }
    }
}
