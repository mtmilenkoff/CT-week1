namespace Exercise1
{
    class Person
    {
        public string Name;
        public short Age;

        public void Greet() { Console.WriteLine("Hello, i'm {0}",this.Name); }
        public void SetAge(short age) { this.Age = age; }
        public void VerAge() { Console.WriteLine("My age is {0}", this.Age); }

        public Person(string name, short age)
        {
            Name = name;
            Age = age;
        }
    }
}