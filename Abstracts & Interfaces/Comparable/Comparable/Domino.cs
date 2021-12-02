using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable
{
    internal class Domino : IComparable<Domino>
    {
        private readonly int[] Values;

        public Domino(int valueA, int valueB)
        {
            this.Values = new int[] { valueA, valueB };
        }
               

        public int CompareTo(Domino nextDomino)
        {
            if (this.Values[0] != nextDomino.Values[0])
            {
                return this.Values[0] - nextDomino.Values[0];
            }
            else
            {
                return this.Values[1] - (nextDomino.Values[1]);
            }
        } 
        public int[] GetValues()
        {
            return Values;
        }
    }
}
