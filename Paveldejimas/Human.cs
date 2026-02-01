using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Paveldejimas
{
    internal class Human
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }

        public Human(string name, string lastName, int birthYear)
        {
            Name = name;
            LastName = lastName;
            BirthYear = birthYear;

        }

        public int GetAge() { return DateTime.Now.Year - BirthYear; }
        public virtual void PrintDetails() // virtual vaikai/anukai/pronukiai... gali perrasyti sita metoda pagal save
        {
            Console.WriteLine("I am a human named " + Name);
        }
    }
}
