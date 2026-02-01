using System;
using System.Collections.Generic;
using System.Text;

namespace Objektai__list_advance_7.ND._8_Grupavimas
{
    internal class Student
    {
        public string CourseYear { get; set; }
        public string Name { get; set; }

        public Student(string courseYear, string name)
        {
            CourseYear = courseYear ;
            Name = name;
        }
    }
}
