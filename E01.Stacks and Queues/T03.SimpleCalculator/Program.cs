using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] reverseInput = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            Stack<string> stack = new Stack<string>(reverseInput);

            while (stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                string operat = stack.Pop();
                int secondNum = int.Parse(stack.Pop());

                if (operat == "+")
                {
                    stack.Push((firstNum + secondNum).ToString());
                }
                else if (operat == "-")
                {
                    stack.Push((firstNum - secondNum).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
