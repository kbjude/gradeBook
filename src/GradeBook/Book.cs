using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public delegate void GradeAddDelegate(object sender, EventArgs args);


        public Book(string name)
        {
            Name = name;
            grades = new List<double>();
        }

        public void AddLetterGrade(char letter)
        {
            switch(letter)
            {
                case 'A':

                    break;

                case 'B':

                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                        AddGrade(60);
                        break;

                default:
                    
                       AddGrade(0);
                       break;
                    
            }
        }

        public void AddGrade(double grade)
        {
            if (grade <=100 && grade >= 0)
            {
                grades.Add(grade);
                if(GradeAdded !=null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new ArgumentException($"Invalid Grade {nameof(grade)}");
            }
        }

        //Adding a new memeber which is just a field
        public event GradeAddDelegate GradeAdded;

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (var grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                result.Average += grade;
            }

            result.Average /= grades.Count;

            switch(result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;

                case var d when d >= 60.0:
                    result.Letter = 'C';
                    break;

                case var d when d >= 90.0:
                    result.Letter = 'D';
                    break;
                default:
                    result.Letter = 'F';
                    break;
            }

            return result;
        }
        List <double> grades;

        /*
        public string Name
        {
            
                this is the same as get; set;
                Check on the book for some thing like this
                get;
                private set;
            
            get

            {
                return name;
            }
            set
            {
                //This value comes from the programm value
                if(!String.IsNullOrEmpty(value))
                {
                    name = value;
                }
            }
        }
        private string name;
         */

        public string Name
        {
            get;

            //Encapsuation happening with the word private. It is being made a read only.
            set;
        }

        //Cant be changes apart from in the constructor.
        //readonly string category = "Science";

        //This cant even be changed in the constructor;
        public const string CATEGORY = "Science";

    }

}