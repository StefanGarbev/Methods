using System;

namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            CharactersInRange(firstChar,secondChar);
         
        }
        static char CharactersInRange(char firstChar,char secondChar)
        {
            int translator = 0;
            char result = '\0' ;
            if (firstChar < secondChar)
            {

                for (int i = firstChar + 1; i < secondChar; i++)
                {
                    translator = i;
                    result = (char)translator;
                    Console.Write(result + " ");
                }
            }
            else
            {
                for (int i = secondChar +1; i < firstChar; i++)
                {
                    translator = i;
                    result = (char)translator;
                    Console.Write(result + " ");
                } 
            }
            return result;
        }
    }
}
