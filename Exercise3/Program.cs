using System;

namespace Exercise3
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            File.Copy(path + "\\Text1.txt", path + "\\Random Folder\\Text2.txt", true);
            Console.WriteLine(path);
        }
    }
}