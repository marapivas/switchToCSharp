using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Double all the values in the array

            int[] numbers = new int[5] { 3, 4, 5, 6, 7 };

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= 2;
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
