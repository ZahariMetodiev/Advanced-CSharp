using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MaximumAndMinimumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int command = input[0];

                if (command == 1)
                {
                    int number = input[1];
                    numbers.Push(number);
                }
                else if (command == 2)
                {
                    numbers.Pop();
                }
                else if (command == 3)
                {
                    if (numbers.Count != 0)
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (command == 4)
                {
                    if (numbers.Count != 0)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
