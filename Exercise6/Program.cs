using System;

namespace Exercise6
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First date");
            DateTime date1 = DateTime.Parse(InputDate());

            Console.WriteLine("Second date");
            DateTime date2 = DateTime.Parse(InputDate());

            Console.WriteLine(date1.Subtract(date2).Days);
        }

        public static string InputDate()
        {
            Console.Write("Input year: ");
            string year = Console.ReadLine();
            Console.Write("Input month: ");
            string month = Console.ReadLine();
            Console.Write("Input day: ");
            string day = Console.ReadLine();

            return year + "-" + month + "-" + day;
        }
    }
}