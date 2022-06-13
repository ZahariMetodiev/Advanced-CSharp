using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstSetLenght = input[0];
            int secontSetLenght = input[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            int totalLenghts = firstSetLenght + secontSetLenght;

            for (int i = 0; i < totalLenghts; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i <= firstSetLenght)
                {
                    firstSet.Add(currentNumber);
                }
                else
                {
                    secondSet.Add(currentNumber);
                }
            }

            int maxLenght = Math.Max(firstSet.Count, secondSet.Count);

            for (int i = 0; i < maxLenght; i++)
            {
                if ()
                {

                }
            }
        }
    }
}
