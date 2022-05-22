using System;
using System.Linq;

namespace T03.MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();

            int n = sizes[0];
            int m = sizes[1];

            int[,] matrix = new int[n, m];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = ReadArrayFromConsole();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int maxSum = int.MinValue;
            int maxRowIndex = -1;
            int maxColIndex = -1;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = 0;
                    
                    sum += matrix[row, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row, col + 2];

                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col + 1];
                    sum += matrix[row + 1, col + 2];

                    sum += matrix[row + 2, col];
                    sum += matrix[row + 2, col + 1];
                    sum += matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int row = maxRowIndex; row < maxRowIndex + 3; row++)
            {
                for (int col = maxColIndex; col < maxColIndex + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        private static int[] ReadArrayFromConsole()
        {
            return Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
        }
    }
}
