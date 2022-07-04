using System;

namespace Exercise5
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;

            Console.WriteLine("Today {0} of {1} is {2} ", today.Day, today.Month, today.DayOfWeek);

            DateTime nextDate = today.AddDays(40);

            Console.WriteLine("in 40 days {0} of {1} is {2} ", nextDate.Day, nextDate.Month, nextDate.DayOfWeek);
        }
    }
}