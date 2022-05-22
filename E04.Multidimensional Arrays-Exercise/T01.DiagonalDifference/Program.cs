using System;
using System.Linq;

namespace Т01.DiagonalDifference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = ReadInputFromConsole();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int firstSum = 0;
            int secondSum = 0;
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                firstSum += matrix[row, row];
            }
            
            for (int row = 0, col = size - 1; row < size; row++, col--)
            {
                secondSum += matrix[row, col];
            }




            Console.WriteLine(Math.Abs(firstSum - secondSum));
        }

        private static int[] ReadInputFromConsole()
        {
            return Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
