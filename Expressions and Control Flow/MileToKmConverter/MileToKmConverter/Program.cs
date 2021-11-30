using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for a double that is a distance in miles,
            // then it converts that value to kilometers and prints it

            Console.WriteLine("Fill distance in miles: ");

            double distanceInMile = Convert.ToDouble(Console.ReadLine());
            double distanceInKm = distanceInMile * 1.609;

            Console.WriteLine(distanceInKm);
        }
    }
}
