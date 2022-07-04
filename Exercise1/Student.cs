namespace Exercise1
{
    internal class Student : Person
    {
        public Student(string name, short age) : base(name, age)
        {
        }

        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
    }
}
