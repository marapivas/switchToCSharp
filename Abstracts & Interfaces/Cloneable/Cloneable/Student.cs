using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloneable
{
    internal class Student : Person, ICloneable
    {
        private string _previousOrganization;
        public string PreviousOrganization
        {
            get { return _previousOrganization; }
            set { _previousOrganization = value; }
        }
        private int _skippedDays;
        public int SkippedDays
        {
            get { return _skippedDays; }
            set { _skippedDays = value; }
        }

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.PreviousOrganization = previousOrganization;
            this.SkippedDays = 0;
        }
        public Student()
        {
            this.PreviousOrganization = "The School of Life";
            this.SkippedDays = 0;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} from {PreviousOrganization} who skipped {SkippedDays} days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays;
        }

        public object Clone()
        {
            return new Student(Name, Age, Gender, PreviousOrganization);
        }
    }
}
