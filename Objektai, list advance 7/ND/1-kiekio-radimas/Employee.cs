using System;
using System.Collections.Generic;
using System.Text;

namespace Objektai__list_advance_7.ND._1_kiekio_radimas
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Employee(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;


        }
    }
}
