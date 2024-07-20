// Student.cs
namespace MyConsoleApp
{
    public class Student : Person
    {
        public string School { get; set; }

        public Student(string name, int age, string school) : base(name, age)
        {
            School = school;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying at {School}.");
        }
    }
}
