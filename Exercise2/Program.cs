using System;

namespace Exercise2
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Person[] PersonArray = new Person[3];
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Input name {0}", i+1);
                String name = Console.ReadLine();
                PersonArray[i] = new Person(String.IsNullOrEmpty(name)? "Unknown" : name);
            }

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Person {0} is {1}", i+1, PersonArray[i].Name);
            }
        }
    }
}