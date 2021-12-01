using System;

namespace Garden_Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Flower yellowFlower = new Flower("yellow");
            Flower blueFlower = new Flower("blue");
            Tree purpleTree = new Tree("purple");
            Tree orangeTree = new Tree("orange");

            Garden garden = new Garden();
            garden.addFlower(yellowFlower);
            garden.addFlower(blueFlower);
            garden.addTree(purpleTree);
            garden.addTree(orangeTree);

            garden.gardenLook();
            Console.WriteLine();
            garden.water(40);
            Console.WriteLine();
            garden.water(70);
        }
    }
}