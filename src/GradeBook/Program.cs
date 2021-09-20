using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 45.9;
            int t = 4;

            var result = x + t;

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
