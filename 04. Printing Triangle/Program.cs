using System;

namespace _04._Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int start = 1;
            int end = number;
            commonAlgoritum(start, end);
        }
        static void commonAlgoritum(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            for (int m = end; m >= start; m--)
            {
                for (int n = 1; n <= m - 1; n++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
