using LINQ;
using System;
using System.Linq;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        //Exercise 1

        int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

        var evenNumbers = n.Where(x => x % 2 == 0).ToArray();
        foreach (int i in evenNumbers)
        {
            Console.Write(i + "' ");
        }

        Console.WriteLine();
        Console.WriteLine();
        //Exercise 2

        var average = n.Average();
        Console.WriteLine(average);
        Console.WriteLine();

        //Exercise 3

        var positiveNumber = n.Where(x => x > 0).Select(x => x * x).ToArray();

        foreach (int i in positiveNumber)
        {
            Console.Write(i + "' ");
        }

        Console.WriteLine();
        Console.WriteLine();

        //Exercise 4

        int[] a = new[] { 3, 9, 2, 8, 6, 5 };

        //var moreThan20 = a.Select(x => x * x).Where(x => x > 20).ToArray();
        var moreThan20 = a.Where(x => (x * x) > 20).ToArray();

        foreach(int i in moreThan20)
        {
            Console.Write(i + ", ");
        }

        Console.WriteLine();
        Console.WriteLine();

        //Exercise 5

        int[] b = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

        var numberFrequency = b.OrderBy(b => b).GroupBy(b => b).ToDictionary(b => b.Key, b => b.Count());

        foreach (var i in numberFrequency)
        {
            Console.WriteLine(i.Key + " frequency: " + i.Value);
        }

        Console.WriteLine();

        //Exercise 6

        string loremIpsum = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.";

        var letterFrequency = loremIpsum.OrderBy(t => t).GroupBy(t => t).ToDictionary(t => t.Key, t => t.Count());

        foreach(var letter in letterFrequency)
        {
            Console.WriteLine(letter.Key + " frequency: " + letter.Value);
        }

        Console.WriteLine();

        //Exercise 7

        string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

        var findCity = cities.Where(c => c[0] == 'A' && c[c.Length - 1] == 'I').ToList();

        foreach (var city in findCity)
        {
            Console.WriteLine(city);
        }

        Console.WriteLine();

        //Exercise 8

        string text = "Test tESt tesT";

        var findUppercase = text.Where(char.IsUpper).ToList();

        foreach (var uppercase in findUppercase)
        {
            Console.Write(uppercase);
        }

        Console.WriteLine();
        Console.WriteLine();

        //Exercise 9

        var chars = new char[] { 's', 't', 'a', 'r', 't' };

        var start = chars.Aggregate(new StringBuilder(), (a, b) =>
        {
            a.Append(b);
            return a;
        });
        Console.WriteLine(start);
        Console.WriteLine();

        //Exercise 10

        List<Fox> foxes = new List<Fox>();
        Fox fox1 = new Fox("Scarlet", "red", 14);
        Fox fox2 = new Fox("Luna", "white", 2);
        Fox fox3 = new Fox("Dexter", "green", 3);
        Fox fox4 = new Fox("Frankie", "green", 6);
        Fox fox5 = new Fox("Ginger", "red", 9);

        foxes.Add(fox1);
        foxes.Add(fox2);
        foxes.Add(fox3);
        foxes.Add(fox4);
        foxes.Add(fox5);

        var greenFox = foxes.Where(x => x.color == "green").ToList();

        foreach (var fox in greenFox)
        {
            Console.WriteLine($"{fox.name} is {fox.age} years old {fox.color} fox.");
        }

        Console.WriteLine();

        var green3YaerFox = foxes.Where(x => x.color == "green" && x.age == 3).ToList();

        foreach (var fox in green3YaerFox)
        {
            Console.WriteLine($"{fox.name} is {fox.age} years old {fox.color} fox.");
        }

    }
}
