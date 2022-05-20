using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.FastFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> orders = new Queue<int>(input);

            int biggestOrder = orders.Max();
            Console.WriteLine(biggestOrder);

            while (orders.Count > 0)
            {
                if (orders.Peek() > foodQuantity)
                {
                    break;
                }
                
                foodQuantity -= orders.Dequeue();
            }

            if (orders.Count > 0)
            {
                Console.WriteLine($"Orders left: {string.Join(' ', orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
