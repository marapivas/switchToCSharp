using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparable
{
    internal class Thing : IComparable<Thing>
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool completed;
        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }

        public Thing(bool completed, string name)
        {
            this.Name = name;
            this.Completed = completed;
        }

        public int CompareTo(Thing nextThing)
        {
            if (this.Completed == nextThing.Completed)
            {
                return Name.CompareTo(nextThing.Name);
            }
            else
            {
                return Completed.CompareTo(nextThing.Completed);
            }
        }
        
        public void Complete()
        {
            this.Completed = true;
        }
        /*
        public string getName()
        {
            return $"{Name}";
        }

        public string getCompleted()
        {
            return $"{Completed}";
        }
        
        public string toString()
        {
            return $"[{Completed}, \"{Name}\"";
        }
        */
    }
}
