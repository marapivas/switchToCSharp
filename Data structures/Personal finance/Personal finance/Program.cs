using System;

namespace PersonalFinance
{
    public class PersonalFinance
    {
        public static void Main(string[] args)
        {
            List<int> expenses = new List<int>();

            expenses.Add(500);
            expenses.Add(1000);
            expenses.Add(1250);
            expenses.Add(175);
            expenses.Add(800);
            expenses.Add(120);

            int totalEx;

            totalEx = expenses.Sum();
            Console.WriteLine(totalEx);
            Console.WriteLine(expenses.Max());
            Console.WriteLine(expenses.Min());
            Console.WriteLine(expenses.Average());

        }
    }
}
