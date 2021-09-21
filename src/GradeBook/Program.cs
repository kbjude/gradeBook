using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 45.9;
            int t = 4;
            var result = x + t;

            var grades = new List<double>() { 12.4, 56.8, 56.3, 67.8, 21.9 };
            grades.Add(56.1);

            //var numbers = new double[] {12.4, 56.8, 56.3, 67.8, 21.9 };

            var total = 0.0;

            foreach(var number in grades)
            {
                total += number;
            }

            result = total / grades.Count;


            Console.WriteLine($"This is my average {result:N1}");


            if(args.Length > 0)
            {
                Console.WriteLine($"Hello World {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello no Name!");
            }
        }
    }
}
