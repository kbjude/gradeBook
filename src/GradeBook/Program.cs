using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        static void Main(string[] args)
        {
            IBook book = new DiskBook("Jude");
            book.GradeAdded += OnGradeAdded;

            var done = false;

            done = EnterGrade(book, done);

            var stats = book.GetStatistics();
            // book.Name = ""; This will be used when the setter is not set to private for the user to change it. This field has been made readonly

            Console.WriteLine($"For the book named {book.Name}");
            Console.WriteLine($"Category for the book is {InMemoryBook.CATEGORY}");
            Console.WriteLine($"This is my average {stats.Average:N1}");
            Console.WriteLine($"This is the lowest grade {stats.Low:N1}");
            Console.WriteLine($"This is the highest grade {stats.High:N1}");
            Console.WriteLine($"This is Your grade {stats.Letter}");

            //var grades = new List<double>() { 12.4, 56.8, 56.3, 67.8, 21.9 };
            //grades.Add(56.1);

            //var numbers = new double[] {12.4, 56.8, 56.3, 67.8, 21.9 };
        }

        //By moving to the book encapsulation is at work.
        private static bool EnterGrade(IBook book, bool done)
        {
            while (!done)
            {
                Console.WriteLine("Enter Grade or letter 'q' to exit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    done = true;
                    continue;
                }

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return done;
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
            Console.WriteLine("Grade was added");
        }
    }
}
