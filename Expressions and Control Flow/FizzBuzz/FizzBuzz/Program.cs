﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints the numbers from 1 to 100
            // but for multiples of three print “Fizz” instead of the number
            // and for the multiples of five print “Buzz”
            // For numbers which are multiples of both three and five print “FizzBuzz”

            int a = 1;

            while (a <= 100)
            {
                if (a % 3 == 0 && a % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (a % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (a % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(a);
                }
                a++;
            }
        }
    }
}