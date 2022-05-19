using System;
using System.Collections.Generic;

namespace T06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else
                {
                    names.Enqueue(input);
                }
            }
            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
