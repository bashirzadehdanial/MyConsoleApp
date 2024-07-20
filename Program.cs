// Program.cs
using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Alice", 30);
            person.Introduce();

            Student student = new Student("Bob", 20, "University of Example");
            student.Introduce();
            student.Study();
        }
    }
}
