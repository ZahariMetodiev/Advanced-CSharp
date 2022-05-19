using System;
using System.Collections.Generic;

namespace T04.MatchingBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if(input[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    string output = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(output);
                }
            }
        }
    }
}
