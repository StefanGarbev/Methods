using System;

namespace _2._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
           
            int vowelCnt = VowelsCount(word.ToLower());
            Console.WriteLine(vowelCnt);
        }
        static int VowelsCount(string word)
        { 
            char[] chars = word.ToCharArray();
            int vowelCnt = 0;
            for (int i = 0; i < chars.Length; i++)
                if (chars[i] == 'a' || chars[i] == 'e' || chars[i] == 'i' || chars[i] == 'o' || chars[i] == 'u' || chars[i] == 'y' 
                    /*chars[i] == 'A' || chars[i] == 'E' || chars[i] == 'I' || chars[i] == 'O' || chars[i] == 'U' || chars[i] == 'Y'*/)
                {
                    vowelCnt++;
                }
            return vowelCnt;
        }
    }
}
