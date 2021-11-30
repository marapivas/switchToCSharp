using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one

            Console.Write("Fill number a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fill number b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else {
                Console.WriteLine(b);
            }
        }
    }
}