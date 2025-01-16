// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Welcome to Thrown for a Loop!");
// Console.WriteLine("Please choose an option:");


// string greeting = @"Welcome to Thrown For a Loop
// Your one-stop shop for used sporting equipment";

// Console.WriteLine(greeting);

// // Console.WriteLine("Please enter a product name: ");
// Console.WriteLine(@"Products:
// 1. Football
// 2. Hockey Stick
// 3. Boomerang
// 4. Frisbee
// 5. Golf Putter");
// Console.WriteLine("Please enter a product number: ");


// string response = Console.ReadLine().Trim();
// int response = int.Parse(Console.ReadLine().Trim());

// while (response > 5 || response < 1)
// {
//     Console.WriteLine("Choose a number between 1 and 5!");
//     response = int.Parse(Console.ReadLine().Trim());
// }

// Console.WriteLine($"You chose: {response}");


// List<string> names = new List<string>();
// let names = [];
// List<int> years = new List<int>()
// {
//     1985, 
//     2022,
//     1999,
//     1976
// };

// List<string> products = new List<string>()
// {
//     "Football",
//     "Hockey Stick",
//     "Boomerang",
//     "Frisbee",
//     "Golf Putter"
// };

// Console.WriteLine("Products:");
// for (int i = 0; i < products.Count; i++)
// {
//     Console.WriteLine($"{i + 1}. {products[i]}");
// }

// Console.WriteLine("Please enter a product number: ");

// using System;
// using System.Collections.Generic;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Create a list of products
//         List<Product> products = new List<Product>()
//         {
//             new Product() { Name = "Football", Price = 15, Sold = false },
//             new Product() { Name = "Hockey Stick", Price = 12, Sold = false },
//             new Product() { Name = "Tennis Racket", Price = 20, Sold = true },
//             new Product() { Name = "Baseball Glove", Price = 10, Sold = false },
//             new Product() { Name = "Soccer Ball", Price = 8, Sold = true },
//             new Product() { Name = "Basketball", Price = 18, Sold = false },
//             new Product() { Name = "Golf Clubs", Price = 35, Sold = true },
//             new Product() { Name = "Skateboard", Price = 25, Sold = false }
//         };

//         // Display available products
//         Console.WriteLine("Available products:");
//         for (int i = 0; i < products.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {products[i].Name}");
//         }

//         // Ask user to select a product
//         Console.Write("Enter the number of the product you'd like to view: ");
//         int response = int.Parse(Console.ReadLine());

//         // Access the chosen product and display details
//         Product chosenProduct = products[response - 1];
//         Console.WriteLine($"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price} dollars and is {(chosenProduct.Sold ? "" : "not ")}sold.");
//     }
// }
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>()
        {
            new Product() 
            { 
                Name = "Football", 
                Price = 15, 
                Sold = false,
                StockDate = new DateTime(2022, 10, 20),
                ManufactureYear = 2010
            },
            new Product() 
            { 
                Name = "Hockey Stick", 
                Price = 12, 
                Sold = false,
                StockDate = new DateTime(2023, 1, 15),
                ManufactureYear = 2018
            },
            new Product() 
            { 
                Name = "Tennis Racket", 
                Price = 20, 
                Sold = true,
                StockDate = new DateTime(2021, 5, 10),
                ManufactureYear = 2015
            },
            new Product() 
            { 
                Name = "Baseball Glove", 
                Price = 25, 
                Sold = false,
                StockDate = new DateTime(2023, 3, 5),
                ManufactureYear = 2020
            },
            new Product() 
            { 
                Name = "Soccer Ball", 
                Price = 18, 
                Sold = true,
                StockDate = new DateTime(2020, 7, 15),
                ManufactureYear = 2017
            }
        };

        // Display product details
        Console.WriteLine("Available Products:");
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {products[i].Name}");
        }

        Console.Write("Enter the number of the product you want to view: ");
        int response = Convert.ToInt32(Console.ReadLine());

        Product chosenProduct = products[response - 1];
        DateTime now = DateTime.Now;

        // Calculate time in stock and age of the product
        TimeSpan timeInStock = now - chosenProduct.StockDate;
        Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");
    }
}

