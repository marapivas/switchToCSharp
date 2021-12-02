using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments_to_Stringed_Instruments
{
    internal class Violin : StringedInstrument
    {
        public Violin()
        {
            this.name = "Violin";
            this.numOfString = 4;
        }

        public Violin(int numOfString)
        {
            this.name = "Violin";
            this.numOfString = numOfString;
        }

        public override string Sound()
        {
            return "Twang";
        }
    }
}
