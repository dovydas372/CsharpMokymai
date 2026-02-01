using System;
using System.Collections.Generic;
using System.Text;

namespace PaveldejimasND
{
    internal class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public int WeightKg { get; set; }



        public Animal(int age, string name, int weightKg)
        {
            Age = age;
            Name = name;
            WeightKg = weightKg;

        }


        public int CalculateDailyFoodGrams()
        {
            return WeightKg * 30 + 200;
        }

        public int getAge()

        {
            return Age;
        }

    }
}
