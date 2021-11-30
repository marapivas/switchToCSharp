using System;

namespace ChangeElement
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `numbers`
            //   with the following content: `[1, 2, 3, 8, 5, 6]`
            // - Change the value of the fourth element (8) to 4
            // - Print the fourth element

            int[] numbers = new int[6] { 1, 2, 3, 8, 5, 6 };

            numbers[3] = 4;

            foreach (int number in numbers)
            {
                Console.Write(number + ", ");
            }

            Console.ReadLine();
        }
    }
}