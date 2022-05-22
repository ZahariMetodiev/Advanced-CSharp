using System;
using System.Linq;

namespace T02.SquaresInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[row, cols] = input[cols];
                }
            }

            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0) -1; row++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) -1; cols++)
                {
                    if (matrix[row, cols] == matrix[row, cols + 1] && matrix[row + 1, cols] == matrix[row + 1, cols + 1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
