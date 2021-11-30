using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `animals`
            //   with the following content:
            //   `["koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill",
            //     "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn"]`
            //
            // - Add all elements an `"a"` at the end

            string[] animals = new string[15] { "koal", "pand", "zebr", "anacond", "bo", "chinchill", "cobr", "gorill", "hyen", "hydr", "iguan", "impal", "pum", "tarantul", "pirahn" };

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = animals[i] + "a";
            }

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.ReadLine();
        }
    }
}
