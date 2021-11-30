using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was

            Console.WriteLine("Fill number:");
            int number = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            
            for (int i = 1; i <= number; i++)
            { 
                for (int j = 1; j <= a; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
                a++;
            }
        }
    }
}