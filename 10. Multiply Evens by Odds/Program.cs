using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            int absNumber = Math.Abs(int.Parse(inputNumber));
            int evenSum = GetSumOfEvenDigits(absNumber.ToString());
            int oddSum = GetSumOfOddDigits(absNumber.ToString());
            GetMultipleOfEvenAndOdds(evenSum,oddSum);
        }

        static void GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            int resut = evenSum * oddSum;
            Console.WriteLine(resut);
        }
        static int GetSumOfEvenDigits(string inputNumber)
        {
            int sumEven = 0;
            
            for (int i = 0; i < inputNumber.Length; i++)
            {
                int currentNum = int.Parse(inputNumber[i].ToString());
                if (currentNum % 2 == 0)
                { 
                    sumEven += currentNum;
                }
            }
            return sumEven;
        }

        static int GetSumOfOddDigits(string inputNumber)
        {
            int sumOdd = 0;
            for (int i = 0; i < inputNumber.Length; i++)
            {
                int currentNum = int.Parse(inputNumber[i].ToString());
                if (currentNum % 2 == 1)
                {
                    sumOdd += currentNum;
                }
            }
            return sumOdd;
        }

    }
}
