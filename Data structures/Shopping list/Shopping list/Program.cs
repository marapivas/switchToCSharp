using System;

namespace ShoppingList
{
    public class ShoppingList
    {
        public static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            shoppingList.Add("eggs");
            shoppingList.Add("milk");
            shoppingList.Add("fish");
            shoppingList.Add("apples");
            shoppingList.Add("bread");
            shoppingList.Add("chicken");

            string result = "no";

            if (shoppingList.Contains("milk"))
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }

            Console.WriteLine(result);

            if (shoppingList.Contains("bananas"))
            {
                result = "yes";
            }
            else
            {
                result = "no";
            }

            Console.WriteLine(result);
        }
    }
}
