using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.FashionBoutique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int currCapacity = capacity;

            Stack<int> clothes = new Stack<int>(input);

            while (clothes.Count > 0)
            {
                int currClothes = clothes.Peek();

                if (currCapacity >= currClothes)
                {
                    currCapacity -= currClothes;
                    clothes.Pop();
                }
                else
                {
                    racks++;
                    currCapacity = capacity;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
