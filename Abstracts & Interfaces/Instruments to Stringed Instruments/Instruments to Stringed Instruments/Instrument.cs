using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instruments_to_Stringed_Instruments
{
    abstract class Instrument
    {
        protected string name;
        abstract public void Play();
    }
}
