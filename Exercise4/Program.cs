using System;

namespace Exercise4
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write text");
            string text = Console.ReadLine();

            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            File.AppendAllText(path + "\\Text.txt", text);
        }
    }
}