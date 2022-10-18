using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataToBeRepeated = Console.ReadLine();
            int numberForRepeated = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(numberForRepeated,dataToBeRepeated));
        }

        static string RepeatString(int numberForRepeated, string dataToBeRepeated)
        {
            string result = string.Empty;
            for (int i = 0; i < numberForRepeated; i++)
            {
                result += dataToBeRepeated;
            }
            return result;
        }
    }
}
