using System;
using System.Collections.Generic;
using System.Text;

namespace Paveldejimas
{
    internal class Customer : Human
    {
        public Customer(string name, string lastName, int birthYear) : base(name, lastName, birthYear)
        {
        }

        public int OrderCount { get; set; }

        public override void PrintDetails()
        {
            base.PrintDetails();
            Console.WriteLine("I am actually a Customer, don't you know I ordered " + OrderCount);
        }
    }
}
