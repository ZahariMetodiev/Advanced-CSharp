using System;
using System.Collections.Generic;

namespace T08.BalancedParenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            bool isBalanced = true;

            for (int i = 0; i < input.Length; i++)
            {
                char currSymbol = input[i];

                if (currSymbol == '(' || currSymbol == '{' || currSymbol == '[')
                {
                    stack.Push(currSymbol);
                }
                else if (currSymbol == ')')
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
                else if (currSymbol == '}')
                {
                    if (stack.Count>0)
                    {
                        if (stack.Peek() == '{')
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
                else if (currSymbol == ']')
                {
                    if (stack.Count > 0)
                    {
                        if (stack.Peek() == '[')
                        {
                            stack.Pop();
                        }
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }
            }

            if(stack.Count == 0 && isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
