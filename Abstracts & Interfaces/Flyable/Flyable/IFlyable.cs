using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyable
{
    internal interface IFlyable
    {
        protected void Land();
        protected void Fly();
        protected void TakeOff();
    }
}
