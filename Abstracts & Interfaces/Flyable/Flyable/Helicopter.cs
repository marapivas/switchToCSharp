using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyable
{
    internal class Helicopter : Vehicle, IFlyable
    {

        public Helicopter(int speed, int range, string purpose)
        {
            this.speed = speed;
            this.range = range;
            this.purpose = purpose;
        }
        public void Fly()
        {
            Console.WriteLine($"Helicopter fly with speed {speed}km/h and range {range}km with purpose {purpose}");
        }

        public void Land()
        {
            Console.WriteLine("Helicopter landing.");
        }

        public void TakeOff()
        {
            Console.WriteLine("Helicopter take off.");
        }
    }
}
