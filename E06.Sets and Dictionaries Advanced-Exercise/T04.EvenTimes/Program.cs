using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(input))
                {
                    numbers.Add(input, 0);
                }

                numbers[input]++;
            }

            Dictionary<int, int> Evennumbers = numbers.Where(x => x.Value % 2 == 0).ToDictionary(x => x.Key, v => v.Value);

            Console.WriteLine(Evennumbers);
        }
    }
}
