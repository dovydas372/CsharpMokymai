using System;
using System.Collections.Generic;
using System.Text;

namespace Pamoka5_object_programavimas
{
    internal class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; }

        public Student(string name, List<int> grades)
        {
            Name = name;
            Grades = grades;
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
        }

        public double AverageLast(int n)
        {
            double average = 0;
            if (Grades.Count >= n)
            {
                average = Grades.TakeLast(n).Average();
                return average;
            }
            average = Grades.Average();
            return average;


        }

        public bool IsAtRisk()
        {
            int count = 0;
            foreach (int grade in Grades)
            {

                if (grade < 5)
                {
                    count++;
                    if (count == 3)
                    {
                        return true;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            return false;
        }

        public int RiskStreak()
        {
            int count = 0;
            int max = 0;
            foreach (int grade in Grades)
            {

                if (grade < 5)
                {
                    count++;
                    if (count > max)
                    {
                        max = count;
                    }
                }
                else
                {
                   
                    count = 0;
                }
            }


            return max;
        }
    }
}