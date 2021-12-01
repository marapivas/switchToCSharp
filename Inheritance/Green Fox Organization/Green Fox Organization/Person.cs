using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    internal class Person
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        private int _age;
        public int Age
        {
            get => _age;
            set => _age = value;
        }
        private string _gender;
        public string Gender
        {
            get => _gender;
            set => _gender = value;
        }

        public Person()
        {
            this.Name = "Jane Doe";
            this.Age = 30;
            this.Gender = "female";
        }

        public Person(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hi, I'm {this.Name}, a {this.Age} year old {this.Gender}.");
        }
    }
}
