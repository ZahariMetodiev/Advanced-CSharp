using System;
using System.Linq;

namespace T04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadArrayFromConsole();

            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] splitedInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (splitedInput[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    int firstRowIndex = int.Parse(splitedInput[1]);
                    int firstColIndex = int.Parse(splitedInput[2]);
                    int secondRowIndex = int.Parse(splitedInput[3]);
                    int secondColIndex = int.Parse(splitedInput[4]);

                    if (firstRowIndex < 0 || firstRowIndex >= matrix.GetLength(0) ||
                        firstColIndex < 0 || firstColIndex >= matrix.GetLength(1) ||
                        secondColIndex < 0 || secondColIndex >= matrix.GetLength(1) ||
                        secondRowIndex < 0 || secondRowIndex >= matrix.GetLength(0))
                    {
                        Console.WriteLine("Invalid input!");
                        input = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        string oldElement = matrix[firstRowIndex, firstColIndex];
                        matrix[firstRowIndex, firstColIndex] = matrix[secondRowIndex, secondColIndex];
                        matrix[secondRowIndex, secondColIndex] = oldElement;

                        PrintMatrix(matrix);
                    }
                }

                input = Console.ReadLine();
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
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
