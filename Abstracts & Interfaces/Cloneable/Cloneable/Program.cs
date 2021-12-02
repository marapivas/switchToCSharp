using System;

namespace Cloneable
{
    class Program
    { 
        public static void Main(string[] args)
        {
            Student john = new Student("John", 20, "male", "BME");
            Student johnTheClone = (Student) john.Clone();

            john.Introduce();
            johnTheClone.Introduce();
        }
    }
}
