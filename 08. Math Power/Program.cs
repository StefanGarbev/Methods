using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Result(baseNumber, powerNumber)); 
        }
        static double Result(double baseNumber, int powerNumber)
        {
            double result = 0d;

            result = Math.Pow(baseNumber, powerNumber);

            return result;
        }
    }
}
