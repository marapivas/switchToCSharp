using System;

namespace Comparable
{
    class Program
    {
        public static void Main(string[] args)
        {
            var dominoes = InitializeDominoes();

            foreach (Domino domino in dominoes)
            {
                Console.Write(domino.GetValues()[0] + ":" + domino.GetValues()[1] + "; ");
            }

            static List<Domino> InitializeDominoes()
            {
                var dominoes = new List<Domino>();
                dominoes.Add(new Domino(5, 2));
                dominoes.Add(new Domino(4, 6));
                dominoes.Add(new Domino(1, 5));
                dominoes.Add(new Domino(6, 7));
                dominoes.Add(new Domino(2, 4));
                dominoes.Add(new Domino(7, 1));
                dominoes.Add(new Domino(6, 1));

                dominoes.Sort();
                return dominoes;
            }
            Console.WriteLine();

            List<Thing> things = InitializeThings();

            foreach (Thing thing in things)
            {
                Console.WriteLine($"[{thing.Completed}, {thing.Name}]");
            }

            static List<Thing> InitializeThings()
            {
                List<Thing> things = new List<Thing>();
                things.Add(new Thing(true, "Get milk"));
                things.Add(new Thing(false, "Vacuum the house"));
                things.Add(new Thing(true, "Pay the bills"));
                things.Add(new Thing(false, "Preorder new PS"));

                things.Sort();

                return things;
            }
        }
    }
}
