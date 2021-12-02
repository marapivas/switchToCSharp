using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments_to_Stringed_Instruments
{
    internal class ElectricGuitar : StringedInstrument
    {

        public ElectricGuitar()
        {
            this.name = "Electric Guitar";
            this.numOfString = 6;
        }
        public ElectricGuitar(int numOfString)
        {
            this.name = "Electric Guitar";
            this.numOfString = numOfString;
        }
        public override string Sound()
        {
            return "Twang";
        }
    }
}
