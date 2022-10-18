using System;

namespace _02._Grades
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double grades = double.Parse(Console.ReadLine());
            gradeResult(grades);

        }

        private static void gradeResult (double grades)
        {
            string gradeInWords = string.Empty;
            if (grades >= 2.00 && grades <= 2.99)
            {
                gradeInWords = "Fail";
            }
            else if (grades >= 3.00 && grades <= 3.49)
            {
                gradeInWords = "Poor";
            }
            else if (grades >= 3.50 && grades <= 4.49)
            {
                gradeInWords = "Good";
            }
            else if (grades >= 4.50 && grades <= 5.49)
            {
                gradeInWords = "Very good";
            }
            else if (grades >= 5.50 && grades <= 6.00)
            {
                gradeInWords = "Excellent";
            }
            Console.WriteLine(gradeInWords);
        }
    }
}
