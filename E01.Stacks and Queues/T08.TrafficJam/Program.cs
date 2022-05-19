﻿using System;
using System.Collections.Generic;

namespace T08.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            counter++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
