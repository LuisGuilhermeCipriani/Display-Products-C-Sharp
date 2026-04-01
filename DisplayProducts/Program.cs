using DisplayProducts.Entities;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace DisplayProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char option = char.Parse(Console.ReadLine().ToLower());
                string name;
                double price;
                DateTime manufactureDate;
                double customsFee;

                bool validOption = false;

                while (!validOption)
                {
                    switch (option)
                    {
                        case 'c':
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            Console.Write("Price: ");
                            price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            products.Add(new Product(name, price));
                            validOption = true;
                            break;
                        case 'u':
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            Console.Write("Price: ");
                            price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Manufacture date (DD/MM/YYYY): ");
                            manufactureDate = DateTime.Parse(Console.ReadLine());
                            products.Add(new UsedProduct(name, price, manufactureDate));
                            validOption = true;
                            break;
                        case 'i':
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            Console.Write("Price: ");
                            price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Customs fee: ");
                            customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            products.Add(new ImportedProduct(name, price, customsFee));
                            validOption = true;
                            break;
                        default:
                            Console.Write("Por favor, digite uma opção válida (c/u/i): ");
                            option = char.Parse(Console.ReadLine().ToLower());
                            break;
                    }
                }
            }
            Console.WriteLine("\nPRICE TAGS:");
            foreach (Product product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}