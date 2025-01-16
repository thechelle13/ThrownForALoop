// using System;
// using System.Collections.Generic;

// class Program
// {
//     // Create a list of products
//     static List<Product> products = new List<Product>()
//     {
//         new Product() 
//         { 
//             Name = "Football", 
//             Price = 15.00M, 
//             Sold = false,
//             StockDate = new DateTime(2022, 10, 20),
//             ManufactureYear = 2010,
//             Condition = 4.2
//         },
//         new Product() 
//         { 
//             Name = "Hockey Stick", 
//             Price = 12.00M, 
//             Sold = false,
//             StockDate = new DateTime(2023, 1, 15),
//             ManufactureYear = 2018,
//             Condition = 4.2
//         },
//         new Product() 
//         { 
//             Name = "Tennis Racket", 
//             Price = 20.00M, 
//             Sold = true,
//             StockDate = new DateTime(2021, 5, 10),
//             ManufactureYear = 2015,
//             Condition = 4.2
//         },
//         new Product() 
//         { 
//             Name = "Baseball Glove", 
//             Price = 25.00M, 
//             Sold = false,
//             StockDate = new DateTime(2023, 3, 5),
//             ManufactureYear = 2020,
//             Condition = 4.2
//         },
//         new Product() 
//         { 
//             Name = "Soccer Ball", 
//             Price = 18.00M, 
//             Sold = true,
//             StockDate = new DateTime(2020, 7, 15),
//             ManufactureYear = 2017,
//             Condition = 4.2
//         }
//     };

//     static void Main()
//     {
//         // Greeting Message
//         Console.WriteLine("Welcome to the Store Inventory Management System!");
        
//         // Main Menu Logic
//         string choice = null;
//         while (choice != "0")
//         {
//             Console.WriteLine(@"Choose an option:
//                                 0. Exit
//                                 1. View All Products
//                                 2. View Product Details
//                                 3. View Latest Products");
//             choice = Console.ReadLine();
//             if (choice == "0")
//             {
//                 Console.WriteLine("Goodbye!");
//             }
//             else if (choice == "1")
//             {
//                 ListProducts();
//             }
//             else if (choice == "2")
//             {
//                 ViewProductDetails();
//             }
//             else if (choice == "3")
//             {
//                 ViewLatestProducts();
//             }
//         }
//     }

//     // Method to display all products
//     static void ListProducts()
//     {
//         decimal totalValue = 0.0M;
//         foreach (Product product in products)
//         {
//             if (!product.Sold)  // Only include items that are not sold
//             {
//                 totalValue += product.Price;
//             }
//         }

//         // Display the total value of inventory
//         Console.WriteLine($"Total Inventory Value: ${totalValue}\n");

//         // Display product details
//         Console.WriteLine("Available Products:");
//         for (int i = 0; i < products.Count; i++)
//         {
//             Console.WriteLine($"{i + 1}. {products[i].Name} - Price: ${products[i].Price} - Condition: {products[i].Condition}/5");
//         }
//     }

//     // Method to display product details
//     static void ViewProductDetails()
//     {
//         ListProducts();  // Use the ListProducts method to show products
        
//         // Ask for user input to choose a product with exception handling
//         Product chosenProduct = null;
//         while (chosenProduct == null)
//         {
//             Console.Write("\nEnter the number of the product you want to view: ");
//             try
//             {
//                 int response = int.Parse(Console.ReadLine().Trim());
//                 chosenProduct = products[response - 1];
//             }
//             catch (FormatException)
//             {
//                 Console.WriteLine("Please enter a valid integer!");
//             }
//             catch (ArgumentOutOfRangeException)
//             {
//                 Console.WriteLine("Please choose an existing item only!");
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine($"An error occurred: {ex.Message}");
//                 Console.WriteLine("Do Better! Please try again.");
//             }
//         }

//         // Access the chosen product and display its details
//         DateTime now = DateTime.Now;
//         TimeSpan timeInStock = now - chosenProduct.StockDate;
//         Console.WriteLine(@$"
// You chose: {chosenProduct.Name}, 
// Price: ${chosenProduct.Price}, 
// Condition: {chosenProduct.Condition}/5,
// It is {now.Year - chosenProduct.ManufactureYear} years old. 
// It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")}");
//     }

//     // Method to display the latest products added in the last 90 days
//     static void ViewLatestProducts()
//     {
//         // Create a new empty List to store the latest products
//         List<Product> latestProducts = new List<Product>();
//         // Calculate a DateTime 90 days in the past
//         DateTime threeMonthsAgo = DateTime.Now - TimeSpan.FromDays(90);
        
//         // Loop through the products
//         foreach (Product product in products)
//         {
//             // Add a product to latestProducts if it fits the criteria
//             if (product.StockDate > threeMonthsAgo && !product.Sold)
//             {
//                 latestProducts.Add(product);
//             }
//         }

//         // Print out the latest products to the console
//         if (latestProducts.Count > 0)
//         {
//             Console.WriteLine("Latest Products Added in the Last 90 Days:");
//             for (int i = 0; i < latestProducts.Count; i++)
//             {
//                 Console.WriteLine($"{i + 1}. {latestProducts[i].Name}");
//             }
//         }
//         else
//         {
//             Console.WriteLine("No new products available in the last 90 days.");
//         }
//     }
// }



// new
using System;
using System.Collections.Generic;

class Program
{
    // Create a list of plants
    static List<Plant> plants = new List<Plant>()
    {
        new Plant() 
        { 
            Species = "Fern", 
            LightNeeds = 3, 
            AskingPrice = 10.00M, 
            City = "Nashville", 
            ZIP = "37203", 
            Sold = false
        },
        new Plant() 
        { 
            Species = "Cactus", 
            LightNeeds = 5, 
            AskingPrice = 8.00M, 
            City = "Knoxville", 
            ZIP = "37922", 
            Sold = false
        },
        new Plant() 
        { 
            Species = "Spider Plant", 
            LightNeeds = 2, 
            AskingPrice = 5.00M, 
            City = "Chattanooga", 
            ZIP = "37421", 
            Sold = true
        },
        new Plant() 
        { 
            Species = "Aloe Vera", 
            LightNeeds = 4, 
            AskingPrice = 12.00M, 
            City = "Memphis", 
            ZIP = "38018", 
            Sold = false
        },
        new Plant() 
        { 
            Species = "Succulent", 
            LightNeeds = 3, 
            AskingPrice = 7.50M, 
            City = "Murfreesboro", 
            ZIP = "37130", 
            Sold = true
        }
    };

    static void Main()
    {
        // Greeting Message
        Console.WriteLine("Welcome to ExtraVert! Your go-to place for secondhand plants!");
        
        // Main Menu Logic
        string choice = null;
        while (choice != "0")
        {
            Console.WriteLine(@"Choose an option:
                                0. Exit
                                1. View All Plants
                                2. View Plant Details
                                3. View Latest Plants Added");
            choice = Console.ReadLine();
            if (choice == "0")
            {
                Console.WriteLine("Goodbye!");
            }
            else if (choice == "1")
            {
                ListPlants();
            }
            else if (choice == "2")
            {
                ViewPlantDetails();
            }
            else if (choice == "3")
            {
                ViewLatestPlants();
            }
        }
    }

    // Method to display all plants
    static void ListPlants()
    {
        decimal totalValue = 0.0M;
        foreach (Plant plant in plants)
        {
            if (!plant.Sold)  // Only include plants that are not sold
            {
                totalValue += plant.AskingPrice;
            }
        }

        // Display the total value of plants
        Console.WriteLine($"Total Plant Inventory Value: ${totalValue}\n");

        // Display plant details
        Console.WriteLine("Available Plants:");
        for (int i = 0; i < plants.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {plants[i].Species} - Price: ${plants[i].AskingPrice} - Light Needs: {plants[i].LightNeeds}/5");
        }
    }

    // Method to display plant details
    static void ViewPlantDetails()
    {
        ListPlants();  // Use the ListPlants method to show plants
        
        // Ask for user input to choose a plant with exception handling
        Plant chosenPlant = null;
        while (chosenPlant == null)
        {
            Console.Write("\nEnter the number of the plant you want to view: ");
            try
            {
                int response = int.Parse(Console.ReadLine().Trim());
                chosenPlant = plants[response - 1];
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid integer!");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Please choose an existing item only!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine("Do Better! Please try again.");
            }
        }

        // Access the chosen plant and display its details
        Console.WriteLine(@$"
You chose: {chosenPlant.Species}, 
Price: ${chosenPlant.AskingPrice}, 
Light Needs: {chosenPlant.LightNeeds}/5,
Located in: {chosenPlant.City} - {chosenPlant.ZIP},
This plant is {(chosenPlant.Sold ? "no longer available." : "still available.")}");
    }

    // Method to display the latest plants added in the last 90 days
    static void ViewLatestPlants()
    {
        // Create a new empty List to store the latest plants
        List<Plant> latestPlants = new List<Plant>();
        // Calculate a DateTime 90 days in the past
        DateTime threeMonthsAgo = DateTime.Now - TimeSpan.FromDays(90);
        
        // Loop through the plants
        foreach (Plant plant in plants)
        {
            // Add a plant to latestPlants if it fits the criteria
            if (plant.Sold == false) // Only unsold plants are considered for latest additions
            {
                latestPlants.Add(plant);
            }
        }

        // Print out the latest plants to the console
        if (latestPlants.Count > 0)
        {
            Console.WriteLine("Latest Plants Added:");
            for (int i = 0; i < latestPlants.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {latestPlants[i].Species}");
            }
        }
        else
        {
            Console.WriteLine("No new plants available.");
        }
    }
}


