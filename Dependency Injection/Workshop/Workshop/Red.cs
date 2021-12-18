using System;

namespace Workshop
{
    public class Red : IColor
    {

        public Printer Printer { get; set; }
        public void PrintColor()
        {
            Console.WriteLine("Red");
        }
    }
}
