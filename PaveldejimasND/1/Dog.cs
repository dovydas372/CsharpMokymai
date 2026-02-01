using System;
using System.Collections.Generic;
using System.Text;

namespace PaveldejimasND
{
    internal class Dog:Animal
    {

        public string FurColor { get; set; }

        public Dog(int age, string name, int weightKg, string furColor) : base(age, name, weightKg)
        {
            FurColor = furColor;
        }

        

    }
}
