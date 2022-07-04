using System;

namespace Exercise9
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int num = 321321;

            string s = num.ToString();

            double total = 0;

            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
                total += char.GetNumericValue(s[i]);
            }
            Console.WriteLine(total);
        }

    }
}