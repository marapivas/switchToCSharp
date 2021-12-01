using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    internal class Mentor : Person
    {
        private string _level;
        public string Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.Level = level;
        }

        public Mentor()
        {
            this.Level = "intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} {Level} mentor.");
        }

    }
}
