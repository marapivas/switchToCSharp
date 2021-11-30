using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[4, 5, 6, 7]`
            // - Print the third element of `numbers`

            int[] numbers = new int[4] { 4, 5, 6, 7 };

            Console.WriteLine(numbers[2]);

            Console.ReadLine();
        }
    }
}