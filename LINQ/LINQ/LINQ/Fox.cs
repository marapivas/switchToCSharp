using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class Fox
    {
        public string name { get; }
        public int age { get; }
        public string color { get; }

        public Fox (string name, string color, int age)
        {
            this.name = name;
            this.color = color;
            this.age = age;
        }
    }
}
