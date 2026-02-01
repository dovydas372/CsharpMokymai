using System;
using System.Collections.Generic;
using System.Text;

namespace PaveldejimasND
{
    internal class Cat : Animal
    {

        public int LivesLeft { get; set; }
        public Cat( int age, string name, int weightKg, int livesLeft): base(age, name, weightKg)
        {
        

          LivesLeft = livesLeft;
         
        
        }



    }
}
