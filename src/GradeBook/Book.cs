using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
            {
            this.name = name;
            grades = new List<double>();
            }
        public void AddGrade(double grade)
        {
            grades.Add(grade); 
        }

        public void ShowStatistics()
        {
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            var total = 0.0;

            foreach (var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);

                total += number;
            }

            var result = total / grades.Count;


            Console.WriteLine($"This is my average {result:N1}");
            Console.WriteLine($"This is the lowest grade {lowGrade:N1}");
            Console.WriteLine($"This is the highest grade {highGrade:N1}");
        }
        List <double> grades;
        string name;
    }

}