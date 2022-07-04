using System;

namespace Exercise10
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string name;
            List<string> nameList = new List<string>();

            while (true)
            {
                Console.WriteLine("Input name: ");
                name = Console.ReadLine();

                if (!String.IsNullOrEmpty(name))
                {
                    nameList.Add(name);
                }
                else
                {
                    break;
                }
            }

            switch (nameList.Count)
            {
                case 0:
                    Console.WriteLine("nothing");
                    break;
                case 1:
                    Console.WriteLine("{0} liked your post", nameList.ElementAt(0));
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} liked your post", nameList.ElementAt(0), nameList.ElementAt(1));
                    break;
                default:
                    Console.WriteLine("{0} and {1} and {2} others liked your post", nameList.ElementAt(0), nameList.ElementAt(1), nameList.Count - 2);
                    break;
            }
        }
    }
}