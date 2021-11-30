using System;

namespace MapIntroduction1
{
    public class MapIntroduction1
    {
        public static void Main(string[] args)
        {
            Dictionary<int, char> map = new Dictionary<int, char>();

            bool isEmpty = (map.Count == 0);

            Console.WriteLine(isEmpty);

            map.Add(97, 'a');
            map.Add(98, 'b');
            map.Add(99, 'c');
            map.Add(65, 'A');
            map.Add(66, 'B');
            map.Add(67, 'C');

            foreach (var kvp in map)
            {
                Console.Write(kvp.Key + " ");

            }
            Console.WriteLine();
            foreach (var kvp in map)
            {
                Console.Write(kvp.Value + " ");
            }
            map.Add(68, 'D');

            Console.WriteLine();
            Console.WriteLine(map.Count);
            Console.WriteLine(map[99]);
            map.Remove(97);
            Console.WriteLine(map.ContainsKey(100));
            map.Clear();
            Console.WriteLine(map.Count);

        }
    }
}