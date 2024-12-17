using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Simple Calculator!");

            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            double number1 = Convert.ToDouble(input1);

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();
            double number2 = Convert.ToDouble(input2);

            double result = number1 + number2;

            Console.WriteLine($"The result of adding {number1} and {number2} is {result}.");
        }
    }
}