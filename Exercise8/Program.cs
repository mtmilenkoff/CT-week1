using System;

namespace Exercise8
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReplaceWords("this_example", '_'));
            Console.WriteLine(ReplaceWords("another.thing", '.'));
        }

        static string ReplaceWords(string word, char separate)
        {
            int index = word.IndexOf(separate);
            string part1 = word.Substring(0, index);
            string part2 = word.Substring(index + 1);

            return (part2 + separate + part1);
        }
    }
}