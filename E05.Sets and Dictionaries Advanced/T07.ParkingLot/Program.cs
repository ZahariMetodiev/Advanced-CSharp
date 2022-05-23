using System;
using System.Collections.Generic;

namespace T07.ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string command = tokens[0];
                string number = tokens[1];

                if (command == "IN")
                {
                    carNumbers.Add(number);
                }
                else if (command == "OUT")
                {
                    carNumbers.Remove(number);
                }
            }

            if (carNumbers.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                Console.WriteLine(string.Join(Environment.NewLine, carNumbers));
            }
        }
    }
}
