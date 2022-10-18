using System;

namespace _5._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            
            int resultOfSum = SumOfFirstAndSecondNumber(firstNumber, secondNumber);
            int total =  SubstractSumAndThirdNumber(resultOfSum,thirdNumber);
            Console.WriteLine(total);
        }

        static int SumOfFirstAndSecondNumber(int num1, int num2)
        { 
            int result = 0;
            result = num1 + num2;
            return result;
        }
        static int SubstractSumAndThirdNumber(int resultOfSum, int num3)
        {
            int result = 0;
            result = resultOfSum - num3;
            return result;
        }
    }
}
