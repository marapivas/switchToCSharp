using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    internal class Sponsor : Person
    {
        private string _company;
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }
        private int _hiredStudents;
        public int HiredStudents
        {
            get { return _hiredStudents; }
            set { _hiredStudents = value;}
        }

        public Sponsor()
        {
            this.Company = "Google";
            this.HiredStudents = 0;
        }

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            this.Company = company;
            this.HiredStudents = 0;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Hi, I'm {Name}, a {Age} year old {Gender} who represents {Company} and hired {HiredStudents} students so far.");
        }

        public void Hire()
        {
            this._hiredStudents++;
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }
    }
}
