using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 45.9;
            int t = 4;
            var result = x + t;

            var numbers = new double[] {12.4, 56.8, 56.3, 67.8, 21.9 };

            var total = 0.0;

            foreach(var number in numbers)
            {
                total += number;
            }

            //numbers[0] = 24.90;
            //numbers[1] = 56.5;
            //numbers[2] = 77.9;
            //var total = numbers[0] + numbers[1] + numbers[2];

            Console.WriteLine($"This is my total {total}");

            Console.WriteLine(result);

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
