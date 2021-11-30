using System;

namespace ListIntroduction1
{
    public class ListIntroduction1
    {
        public static void Main(string[] args)
        {
            List<String> names = new List<String>();

            Console.WriteLine(names.Count);

            names.Add("William");

            bool isNullOrEmpty = names?.Any() != true;
            Console.WriteLine(isNullOrEmpty);

            names.Add("John");
            names.Add("Amanda");

            Console.WriteLine(names.Count);
            Console.WriteLine(names[2]);
            Console.WriteLine();

            foreach (String name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            int i = 1;
            foreach(String name in names)
            {
                
                Console.WriteLine(i + ". " + name);
                i++;
            }

            names.RemoveAt(1);

            foreach (String name in names)
            {
                Console.WriteLine(name);
            }
            
            names.Clear();

            Console.WriteLine(names.Count);

        }
    }
}
