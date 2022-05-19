using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.StackSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string input = string.Empty;

            while ((input = Console.ReadLine().ToUpper()) != "END")
            {
                string[] split = input.Split(' ');
                string command = split[0];

                if (command == "ADD")
                {
                    stack.Push(int.Parse(split[1]));
                    stack.Push(int.Parse(split[2]));
                }
                else if (command == "REMOVE")
                {
                    int value = int.Parse(split[1]);
                    if (value > stack.Count)
                    {
                        continue;
                    }
                    else
                    {
                        for (int i = 0; i < value; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
