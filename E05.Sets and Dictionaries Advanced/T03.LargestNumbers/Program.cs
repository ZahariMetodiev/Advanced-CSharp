using System;
using System.Linq;

namespace T03.LargestNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] sortedNumbers = numbers.OrderByDescending(x => x).ToArray();

            if (sortedNumbers.Length <= 3)
            {
                for (int i = 0; i < sortedNumbers.Length; i++)
                {
                    Console.Write(sortedNumbers[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(sortedNumbers[i] + " ");
                }
            }

        }
    }
}
