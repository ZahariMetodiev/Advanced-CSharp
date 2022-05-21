using System;
using System.Linq;

namespace T05.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes= ReadArrayFromConsole();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = ReadArrayFromConsole();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[row,cols] = input[cols];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) -1; cols++)
                {
                    int sum = matrix[row,cols] + matrix[row,cols + 1] + matrix[row + 1,cols] + matrix[row + 1, cols + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxCol = cols;
                        maxRow = row;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow +1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }

        private static int[] ReadArrayFromConsole()
        {
             return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
