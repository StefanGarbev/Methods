using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();


            if (type == "int")
            {
                int comparingNumber1 = int.Parse(Console.ReadLine());
                int comparingNumber2 = int.Parse(Console.ReadLine());
                getMax(comparingNumber1, comparingNumber2);
            }
            else if (type == "char")
            {
                char comparingSymbol1 = char.Parse(Console.ReadLine());
                char comparingSymbol2 = char.Parse(Console.ReadLine());
                getMax(comparingSymbol1, comparingSymbol2);
            }
            else
            { 
                string comparingString1 = Console.ReadLine();
                string comparingString2 = Console.ReadLine();
                getMax(comparingString1, comparingString2);
            }

        }
        static void getMax(int comparingNumber1, int comparingNumber2)
        { 
            int result  = 0;
            if (comparingNumber1 > comparingNumber2)
            {
                result = comparingNumber1;
                Console.WriteLine(result);
            }
            else
            {
                result = comparingNumber2;
                Console.WriteLine(result);
            }
        }
        static void getMax(char comparingSymbol1, char comparingSymbol2)
        {
            if (comparingSymbol1 > comparingSymbol2)
            {
                char result = comparingSymbol1;
                Console.WriteLine(result);
            }
            else
            {
                char result = comparingSymbol2;
                Console.WriteLine(result);
            }
        }
        static void getMax(string comparingString1, string comparingString2)
        {
            int result = string.Compare(comparingString1, comparingString2);
            if (result == 1)
            {
                Console.WriteLine(comparingString1);
            }
            else
            {
                Console.WriteLine(comparingString2);
            }
        }
    }
}
