using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Fox_Organization
{
    internal class Cohort
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private List<Student> _students;
        public List<Student> Students
        {
            get { return _students; }
            set { _students = value; }
        }

        private List<Mentor> _mentors;
        public List<Mentor> Mentors
        {
            get { return _mentors; }
            set { _mentors = value; }
        }

        public Cohort(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
            this.Mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine($"The {Name} cohort has {Students.Count} students and {Mentors.Count} mentors.");
        }
    }
}
