using System;

namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double Area = RectangleArea(width, height);
            Console.WriteLine(Area);
        }
        static double RectangleArea(double widht, double height)
        { 
            return widht * height;
        }
    }
}
