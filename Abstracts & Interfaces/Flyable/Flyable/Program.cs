using System;

namespace Flyable
{
    class Program
    {
        public static void Main(string[] args)
        {
            Helicopter helicopter = new Helicopter(260, 2600, "save people");
            helicopter.TakeOff();
            helicopter.Fly();
            helicopter.Land();
        }
    }
}