using System;

namespace IncrementElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Create an array variable named `numbers`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            numbers[2]++;

            Console.WriteLine(numbers[2]);

            Console.ReadLine();
        }
    }
}
