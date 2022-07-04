namespace Exercise1
{
    internal class Teacher : Person
    {
        public Teacher(string name, short age) : base(name, age)
        {
        }

        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
}
