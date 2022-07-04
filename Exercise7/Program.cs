using System;

namespace Exercise7
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            string input = Console.ReadLine();

            int num1, num2;

            while (!int.TryParse(input, out num1))
            {
                Console.WriteLine("Input invalid");
                Console.WriteLine("Input first number");
                input = Console.ReadLine();
            }


            Console.WriteLine("Input second number");
            input = Console.ReadLine();

            while (!int.TryParse(input, out num2))
            {
                Console.WriteLine("Input invalid");
                Console.WriteLine("Input second number");
                input = Console.ReadLine();
            }

            Console.WriteLine(DivisibleBy2Or3(num1, num2));

        }

        static int DivisibleBy2Or3(int num1, int num2)
        {
            if ((num1 % 2 == 0 || num1 % 3 == 0) && (num2 % 2 == 0 || num2 % 3 == 0))
            {
                return num1 * num2;
            }
            return num1 + num2;
        }
    }
}