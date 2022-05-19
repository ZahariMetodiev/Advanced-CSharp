using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.PrintEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Queue<int> numbersQueue = new Queue<int>(numbers);
            Queue<int> evenNumbers= new Queue<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                if (currentNumber % 2 == 0)
                {
                    evenNumbers.Enqueue(currentNumber);
                }
            }

            Console.WriteLine(String.Join(", ", evenNumbers));
        }
    }
}
