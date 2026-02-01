using System;
using System.Collections.Generic;
using System.Text;

namespace Objektai__list_advance_7.ND._9_Anoniminių_objektų_kūrimas
{
    internal class Employee2
    {
        public int MonthlySalary { get; set; }
        public string Name { get; set; }

        public Employee2(int monthlySalary, string name)
        {
            MonthlySalary = monthlySalary;
            Name = name;
        }
    }
}
