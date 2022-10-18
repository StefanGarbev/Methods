using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArguments = command
                    .Split(' ');

                string commandType = commandArguments[0];

                if (commandType == "exchange")
                {
                    int index = int.Parse(commandArguments[1]);
                    if (index < 0 || index >= inputArr.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    else
                    {
                        inputArr = subExchangeArr(inputArr, index);
                    }
                }
                else if (commandType == "max")
                {
                    string evenOrOddArgument = commandArguments[1];
                    maxEvenMaxOdd(inputArr, evenOrOddArgument);
                }
                else if (commandType == "min")
                {
                    string evenOddArgument = commandArguments[1];
                    minEvenOdd(inputArr, evenOddArgument);
                }
                else if (commandType == "first" || commandType == "last")
                { 
                    int count = int.Parse(commandArguments[1]);
                    string evenOddArg = commandArguments[2];

                    if (count > inputArr.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    int[] elements;
                    if (commandType == "first")
                    {
                        elements = firstCountEvenOdd(inputArr, count, evenOddArg);
                    }
                    else
                    {
                        elements = LastCountEvenOdd(inputArr, count, evenOddArg);
                    }
                    PrintArray(elements);
                }
            }
            PrintArray(inputArr); 
        }
        static int[] subExchangeArr(int[] inputArr, int index)
        {
            int[] outputArr =  new int [inputArr.Length];
            int outputArrIndex = 0;
            for (int i = index+1; i < inputArr.Length; i++)
            {
                outputArr[outputArrIndex] = inputArr[i];
                outputArrIndex++;
            }
            for (int j = 0; j <= index; j++)
            {
                outputArr[outputArrIndex] = inputArr[j];
                outputArrIndex++;
            }

            return outputArr;
        }

        static void maxEvenMaxOdd(int[] inputArr, string evenOrOddArgument)
        {
            int maxIndex = -1;
            if (evenOrOddArgument == "even")
            {
                
                int evenMaxNumber = 0;
                int valueOfArrIndexI = 0;
                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] % 2 == 0)
                    {
                        valueOfArrIndexI = inputArr[i];
                        if (valueOfArrIndexI >= evenMaxNumber)
                        {
                            evenMaxNumber = valueOfArrIndexI;
                            maxIndex = i;   
                        }
                        
                    }
                }
                if (maxIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(maxIndex);
                }
                
            }
            else if (evenOrOddArgument == "odd")
            {
                int oddMaxNumber = 0;
                int valueOfArrIndexI = 0;
                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] % 2 != 0)
                    {
                        valueOfArrIndexI = inputArr[i];
                        if (valueOfArrIndexI >= oddMaxNumber)
                        {
                            oddMaxNumber = valueOfArrIndexI;
                            maxIndex = i;
                            
                        }
                    }
                }
                if (maxIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(maxIndex);
                }
            }
        }

        static void minEvenOdd(int[] inputArr, string evenOddArgument)

        {
            int minIndex = -1;
            if (evenOddArgument == "even")
            {

                int evenMinNumber = int.MaxValue;
                int valueOfArrIndexI = 0;
                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] % 2 == 0)
                    {
                        valueOfArrIndexI = inputArr[i];
                        if (valueOfArrIndexI <= evenMinNumber)
                        {
                            evenMinNumber = valueOfArrIndexI;
                            minIndex = i;
                        }

                    }
                }
                if (minIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(minIndex);
                }

            }
            else if (evenOddArgument == "odd")
            {
                int oddMinNumber = int.MaxValue;
                int valueOfArrIndexI = 0;
                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] % 2 != 0)
                    {
                        valueOfArrIndexI = inputArr[i];
                        if (valueOfArrIndexI <= oddMinNumber)
                        {
                            oddMinNumber = valueOfArrIndexI;
                            minIndex = i;

                        }
                    }
                }
                if (minIndex == int.MaxValue)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(minIndex);
                }
            }
        }

        static int[] firstCountEvenOdd(int[] inputArr, int count, string evenOddArg)
        {
            int[] firstElementCount = new int[count];
            int firstElementCountIndex = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (firstElementCountIndex >= count)
                {
                    break;
                }

                int curNum = inputArr[i];
                if (evenOddArg == "even" && curNum % 2 == 0)
                {
                    firstElementCount[firstElementCountIndex++] = curNum;
                }
                else if (evenOddArg == "odd" && curNum % 2 != 0)
                {
                    firstElementCount[firstElementCountIndex++] = curNum;
                }
            }

            if (firstElementCountIndex < count)
            {
                firstElementCount = ResizeArr(firstElementCount, firstElementCountIndex);
            }
            
            return firstElementCount;
        }

        static int[] LastCountEvenOdd(int[] inputArr, int count, string evenOddArg)
        {
            int[] firstElementCount = new int[count];
            int firstElementCountIndex = 0;
            for (int i = inputArr.Length-1; i >= 0; i--)
            {
                if (firstElementCountIndex >= count)
                {
                    break;
                }

                int curNum = inputArr[i];
                if (evenOddArg == "even" && curNum % 2 == 0)
                {
                    firstElementCount[firstElementCountIndex++] = curNum;
                }
                else if (evenOddArg == "odd" && curNum % 2 != 0)
                {
                    firstElementCount[firstElementCountIndex++] = curNum;
                }
            }
            if (firstElementCountIndex < count)
            {
                firstElementCount = ResizeArr(firstElementCount, firstElementCountIndex);
            }
            firstElementCount = ReverseArray(firstElementCount);
            return firstElementCount;
        }

        static int[] ResizeArr (int[] inputArr, int count)
        {
            int[] modifiedArray = new int[count];
            for (int i = 0; i < count; i++)
            {
                modifiedArray[i] = inputArr[i];
            }

            return modifiedArray;
        }

        static void PrintArray(int[] inputArr)
        {
            Console.WriteLine($"[{String.Join(", ", inputArr)}]");
        }

        static int[] ReverseArray(int[] originalArr)
        {
            int[] reversed = new int[originalArr.Length];
            for (int i = originalArr.Length - 1; i >= 0; i--)
            {
                reversed[reversed.Length - i - 1] = originalArr[i];
            }

            return reversed;
        }
    }
}
