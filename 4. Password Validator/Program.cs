using System;

namespace _4._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool passwordLenght = passwordValidLenght(password);
            bool passwordLettersAndDigit = passwordHaveLettersAndDigit(password);
            bool passwordContainTwoDigit = passwordHaveTwoDigit(password);

            if (!passwordLenght)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!passwordLettersAndDigit)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!passwordContainTwoDigit)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (passwordLenght && passwordLettersAndDigit && passwordContainTwoDigit)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool passwordValidLenght(string password)
        {
            bool result = true;
            if (password.Length >= 6 && password.Length <= 10)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        static bool passwordHaveLettersAndDigit(string password)
        {
           

            foreach (char ch in password)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return false;
                }
               
            }
            return true;
        }

        static bool passwordHaveTwoDigit(string password)
        {
            int digitCnt = 0;
            bool result = true;
            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digitCnt++;
                }
            }
            if (digitCnt < 2)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }
    }
}
