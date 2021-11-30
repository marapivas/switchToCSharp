using System;

namespace ProductDatabase
{
    public class ProductDatabase
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();

            map.Add("Eggs", 200);
            map.Add("Milk", 200);
            map.Add("Fish", 400);
            map.Add("Apples", 150);
            map.Add("Bread", 50);
            map.Add("Chicken", 550);

            Console.WriteLine(map["Fish"]);

            int mostExpensive = 0;
            String item = "";
            int counter = 0;
            String isAnythingToBuy = "no";
            int cheapest = map.Values.Max();

            foreach (var kvp in map)
            {
                if (mostExpensive < kvp.Value)
                {
                    mostExpensive = kvp.Value;
                    item = kvp.Key;
                }
            }
            Console.WriteLine(item);
            Console.WriteLine(map.Values.Average());

            foreach (var kvp in map)
            {
                if (kvp.Value < 300)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);

            foreach (var kvp in map)
            {
                if (kvp.Value == 125)
                {
                    isAnythingToBuy = "yes";
                }
            }
            Console.WriteLine(isAnythingToBuy);

            foreach (var kvp in map)
            {
                if (cheapest > kvp.Value)
                {
                    cheapest = kvp.Value;
                    item = kvp.Key;
                }
            }
            Console.WriteLine(item);
        }
    }
}