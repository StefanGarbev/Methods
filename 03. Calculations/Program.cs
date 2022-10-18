using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mathMoves = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            if (mathMoves == "add")
            {
                addition(firstNumber, secondNumber);
            }
            else if (mathMoves == "multiply")
            {
                multiplication(firstNumber, secondNumber);
            }
            else if (mathMoves == "subtract")
            {
                subtraction(firstNumber, secondNumber);
            }
            else
            {
                devides(firstNumber, secondNumber);
            }


        }
        static void addition(int firstNumber, int secondNumber)
        { 
            Console.WriteLine($"{firstNumber+secondNumber}");
        }
        static void subtraction(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"{firstNumber - secondNumber}");
        }
        static void multiplication(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"{firstNumber * secondNumber}");
        }
        static void devides(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"{firstNumber / secondNumber}");
        }
    }
}
