using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments_to_Stringed_Instruments
{
    abstract class StringedInstrument : Instrument
    {
        protected int numOfString;

        public StringedInstrument()
        {

        }
        protected StringedInstrument(int numOfString)
        {
            this.numOfString = numOfString;
        }
        abstract public string Sound();

        public override void Play()
        {
            Console.WriteLine($"{name},a {numOfString}-stringed instrument that {Sound()}");
        }

    }
}
