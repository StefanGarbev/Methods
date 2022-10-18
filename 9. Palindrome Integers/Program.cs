using System;
using System.Linq;

namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string positiveNumber = Console.ReadLine();
          
            while (positiveNumber != "END")
            {
               bool polindome = PalindromeIntegers(positiveNumber);
                Console.WriteLine(polindome);
                positiveNumber = Console.ReadLine();
            }
        }
        static bool PalindromeIntegers(string num)
        {
            
            //bool polindrome = false;
            char[] ch = new char[num.Length];   
            string polindromeForward = string.Empty;
            string polindomeBackward = string.Empty;

            for (int i = 0; i < num.Length; i++)
            {
                ch[i] = num[i]; 
            }
            for (int i = 0; i < num.Length; i++)
            {
                polindromeForward = ch[i].ToString();    
            }
            for (int j = num.Length-1; j >= 0; j--)
            { 
                polindomeBackward = ch[j].ToString();
            }
            if (polindromeForward == polindomeBackward)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
