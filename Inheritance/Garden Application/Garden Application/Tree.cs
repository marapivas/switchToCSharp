using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    internal class Tree : Plant
    {
        public Tree(String color) : base(color)
        {
        }

        public void printStatus()
        {
            if (base.WaterAmount < 10)
            {
                Console.WriteLine("The " + Color + " Tree needs water.");
            }
            else
            {
                Console.WriteLine("The " + Color + " Tree doesn't need water.");
            }
        }

        public bool needsWater()
        { return base.WaterAmount < 10;}
    }
}
