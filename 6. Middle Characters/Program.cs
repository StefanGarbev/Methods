using System;

namespace _6._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputInfo = Console.ReadLine();
            MidOfString(inputInfo);
        }

        static void MidOfString(string input)
        {
            int lenght = input.Length;
            if (lenght % 2 == 0)
            {
                int mid = input.Length / 2;
                
                for (int i = 0; i <= input.Length; i++)
                {
                    if (i == mid)
                    { 
                        char c = input[i];
                        char c1 = input[i-1];
                        Console.WriteLine($"{c1}{c}");
                    }
                }

            }
            else 
            {
                double mid = input.Length / 2;
                double midIndex = Math.Ceiling(mid);
                
                for (int i = 0; i < input.Length; i++)
                {
                    if (i == (int) midIndex) 
                    {
                        char c = input[i];
                        Console.WriteLine(c);
                    }

                }
            }
        }
    }
}
