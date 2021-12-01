using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garden_Application
{
    internal class Flower : Plant
    {
        public Flower(string color) : base(color)
        {
        }

        public void printStatus()
        {
            if (base.WaterAmount < 5)
            {
                Console.WriteLine("The " + Color + " flower needs water.");
            }
            else
            {
                Console.WriteLine("The " + Color + " flower doesn't need water.");
            }
        }

        public bool needsWater()
        {
            return base.WaterAmount < 5;
        }
    }
}
