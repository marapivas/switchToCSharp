using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Modify this program to greet the User instead of the World!
            // The program should ask for the name of the User

            Console.WriteLine("Fill your name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);

        }
    }
}
