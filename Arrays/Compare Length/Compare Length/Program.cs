using System;

namespace CompareLength
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `firstArrayOfNumbers`
            //   with the following content: `[1, 2, 3]`
            // - Create an array variable named `secondArrayOfNumbers`
            //   with the following content: `[4, 5]`
            // - Print "secondArrayOfNumbers is longer" if 
            //   `secondArrayOfNumbers` has more elements than
            //   `firstArrayOfNumbers`
            // - Otherwise print: "firstArrayOfNumbers is the longer one"

            int[] firstArrayOfNumbers = new int[3] { 1, 2, 3 };
            int[] secondArrayOfNumbers = new int[2] { 4, 5 };

            if (firstArrayOfNumbers.Length < secondArrayOfNumbers.Length)
            {
                Console.WriteLine("secondArrayOfNumbers is longer");
            }
            else
            {
                Console.WriteLine("firstArrayOfNumbers is the longer one");
            }

            Console.ReadLine();
        }
    }
}
