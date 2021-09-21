using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() { 12.4, 56.8, 56.3, 67.8, 21.9 };
            grades.Add(56.1);

            //var numbers = new double[] {12.4, 56.8, 56.3, 67.8, 21.9 };

            var total = 0.0;

            foreach(var number in grades)
            {
                total += number;
            }

            var result = total / grades.Count;


            Console.WriteLine($"This is my average {result:N1}");
        }
    }
}
