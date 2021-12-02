using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments_to_Stringed_Instruments
{
    internal class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            this.name = "BassGuitar";
            this.numOfString = 4;
        }

        public BassGuitar(int numOfString)
        {
            this.numOfString = numOfString; 
        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }
    }
}
