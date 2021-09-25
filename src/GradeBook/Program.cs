using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        static void Main(string[] args)
        {
            var book = new Book("Jude");
            book.AddGrade(89.1);
            book.AddGrade(56.7);
            book.AddGrade(27.7);
            book.AddGrade(78.98);

            var stats = book.GetStatistics();


            Console.WriteLine($"This is my average {stats.Average:N1}");
            Console.WriteLine($"This is the lowest grade {stats.Low:N1}");
            Console.WriteLine($"This is the highest grade {stats.High:N1}");

            //var grades = new List<double>() { 12.4, 56.8, 56.3, 67.8, 21.9 };
            //grades.Add(56.1);

            //var numbers = new double[] {12.4, 56.8, 56.3, 67.8, 21.9 };
        }
    }
}
