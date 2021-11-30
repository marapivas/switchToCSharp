using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that writes this line 100 times:
            // "I won't cheat on the exam!"

            int a = 0;
            while (a < 100) 
            {
                Console.WriteLine("I won't cheat on the exam!");
                a++;
            }
        }
    }
}
