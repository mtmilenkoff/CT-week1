using System;

namespace Exercise1
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("bill", 10);
            person.Greet();

            Student student = new Student("Mike", 20);
            student.SetAge(21);
            student.Greet();
            student.VerAge();
            student.Study();

            Teacher teacher = new Teacher("John", 30);
            teacher.SetAge(35);
            teacher.Greet();
            teacher.Explain();
        }
    }
}