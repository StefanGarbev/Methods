using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            numbersDigitDevideByEight(inputNumber);
            
        }
        static void numbersDigitDevideByEight(int number)
        {
            
            for (int i = 1; i <= number; i++)
            {
                string NumberDigits = i.ToString();
                int sumOfDigits = 0;
                int oddDigit = 0;
                int intDigit = int.Parse(NumberDigits);
                int digitOdd = int.Parse(NumberDigits);
                for (int j = 1; j <= NumberDigits.Length; j++)
                {
                    int digit = intDigit % 10;
                    sumOfDigits += digit;
                    intDigit = intDigit / 10;
                }

                for (int k = 1; k <= NumberDigits.Length; k++)
                {
                    int digitNumber = digitOdd % 10;
                    oddDigit = digitNumber;
                    if (oddDigit % 2 == 1)
                    {
                        break;
                    }
                    digitOdd = digitOdd / 10;
                }

                if (sumOfDigits % 8 == 0 && oddDigit % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
