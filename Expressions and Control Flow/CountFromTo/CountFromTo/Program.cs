using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5

            Console.Write("Fill first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Fill second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                while (a < b)
                {
                    Console.WriteLine(a);
                    a++;
                }
            }
        }
    }
}