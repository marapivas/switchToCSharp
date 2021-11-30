using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // then prints "Odd" if the number is odd, or "Even" if it is even.

            Console.Write("Fill number: ");

            double number = Convert.ToDouble(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else {
                Console.WriteLine("Odd");
            }

        }
    }
}