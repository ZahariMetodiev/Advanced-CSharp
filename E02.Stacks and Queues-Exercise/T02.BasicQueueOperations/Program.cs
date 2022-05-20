using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.BasicQueueOperations
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

            Queue<int> queue = new Queue<int>();
            int add = command[0];
            int remove = command[1];
            int check = command[2];

            for (int i = 0; i < add; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < remove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else if (queue.Contains(check))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
