using System;

namespace _8._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            facotialDivision(firstNum, secondNum);
        }
        static void facotialDivision(int num1, int num2)
        {
            double firstFactorialResult = 1;
            double secondFactorialResult = 1;
            double result = 0;
            for (int i = 1; i <= num1; i++)
            { 
                firstFactorialResult *= i;
            }
            for (int i = 1; i <= num2; i++)
            { 
                secondFactorialResult *= i;
            }
            result = firstFactorialResult / secondFactorialResult;
            Console.WriteLine($"{result:f2}"); 
        }
    }
}
