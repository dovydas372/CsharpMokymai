using System;
using System.Collections.Generic;
using System.Text;

namespace Paveldejimas
{
    internal class Employee : Human
    {
        public Employee(string vardas, string pavarde, int birthYear, double salary) : base(vardas, pavarde, birthYear)
        {
            Salary = salary;
        }

        public double Salary { get; set; }
        //public Employee(string name, string lastName, int birthYear) : base(name, lastName, birthYear)
        //{
        //}
    }
}
