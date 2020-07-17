using System;
using DivisionServices;

namespace DivisionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.WriteLine("Introduce first number:");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduce first number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Result:");
            Console.WriteLine(Division.Divide(num1,num2));
        }
    }
}
