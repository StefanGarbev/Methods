using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            char operatorMath = char.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (operatorMath == '*')
            {
                Multiply(num1, num2);
            }
            else if (operatorMath == '/')
            {
                Devide(num1, num2);
            }
            else if (operatorMath == '-')
            {
                Minus(num1, num2);
            }
            else
            { 
                Sum(num1, num2);
            }
        }
        static void Multiply(int num1, int num2)
        { 
            int result  = num1 * num2;
            Console.WriteLine(result);
        }
        static void Devide(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine(result);
        }
        static void Sum(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);
        }
        static void Minus(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);
        }
    }
}
