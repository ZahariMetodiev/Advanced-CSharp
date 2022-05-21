using System;
using System.Linq;

namespace T06.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int row = 0; row < n; row++)
            {
                jagged[row] = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] splitedInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = splitedInput[0];
                int rowIndex = int.Parse(splitedInput[1]);
                int colIndex = int.Parse(splitedInput[2]);
                int value = int.Parse(splitedInput[3]);

                if (rowIndex < 0 || rowIndex >= n || colIndex < 0 || colIndex >= jagged[rowIndex].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                
                if (command == "Add")
                {
                    jagged[rowIndex][colIndex] += value;
                }
                else if (command == "Subtract")
                {
                    jagged[rowIndex][colIndex] -= value;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(String.Join(' ', jagged[i]));
            }
        }
    }
}
