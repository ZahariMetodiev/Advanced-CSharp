using System;
using System.Collections.Generic;

namespace T04.ProductShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> products = new SortedDictionary<string, Dictionary<string, double>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string shop = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!products.ContainsKey(shop))
                {
                    products.Add(shop, new Dictionary<string, double>());
                }
                products[shop].Add(product, price);
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Key}->");

                foreach (var item in product.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
