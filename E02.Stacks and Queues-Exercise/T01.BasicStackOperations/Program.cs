using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.BasicStackOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();

            int push = command[0];
            int pop = command[1];
            int check = command[2];

            for (int i = 0; i < push; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < pop; i++)
            {
                stack.Pop();
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (stack.Contains(check))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
