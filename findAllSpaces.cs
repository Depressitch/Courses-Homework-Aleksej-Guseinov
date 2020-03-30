using System;

namespace findAllSpaces
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input your line: ");
            string input = Console.ReadLine();
            Console.WriteLine("Indexes of spaces:");
            int lastIndex = input.LastIndexOf(" ");
            for (int i = 0; i <= lastIndex; i++)
            {
                int index = input.IndexOf(" ", i);
                Console.WriteLine(index);
                i = index;
            }
            Console.ReadKey();
        }
    }
}
