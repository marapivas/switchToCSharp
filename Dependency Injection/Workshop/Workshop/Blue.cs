using System;

namespace Workshop
{
    public class Blue : IColor
    {

        public Printer printer { get; set; }
        public void PrintColor()
        {
            Console.WriteLine("Green");
            
        }

        public Blue(Printer printer)
        {
            this.printer = printer;
        }
    }
}
