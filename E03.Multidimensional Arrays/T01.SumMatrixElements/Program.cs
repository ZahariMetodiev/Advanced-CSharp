using System;
using System.Linq;

namespace T01.SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = ReadInputFromConsole();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int row = 0; row < sizes[0]; row++)
            {
                int[] arr = ReadInputFromConsole();
                
                for (int col = 0; col < sizes[1]; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int sum = 0;

            foreach (int item in matrix)
            {
                sum += item;
            }
            
            Console.WriteLine(sizes[0]);
            Console.WriteLine(sizes[1]);
            Console.WriteLine(sum);
        }

        private static int[] ReadInputFromConsole()
        {
            return Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
