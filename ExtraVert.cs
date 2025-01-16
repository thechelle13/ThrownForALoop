using System;
using System.Collections.Generic;

class Program
{
    // Create a list of plants
    static List<Plant> plants = new List<Plant>()
    {
        new Plant() { Species = "Fern", LightNeeds = 3, AskingPrice = 10.00M, City = "Nashville", ZIP = "37203", Sold = false },
        new Plant() { Species = "Cactus", LightNeeds = 5, AskingPrice = 8.00M, City = "Knoxville", ZIP = "37922", Sold = false },
        new Plant() { Species = "Spider Plant", LightNeeds = 2, AskingPrice = 5.00M, City = "Chattanooga", ZIP = "37421", Sold = true },
        new Plant() { Species = "Aloe Vera", LightNeeds = 4, AskingPrice = 12.00M, City = "Memphis", ZIP = "38018", Sold = false },
        new Plant() { Species = "Succulent", LightNeeds = 3, AskingPrice = 7.50M, City = "Murfreesboro", ZIP = "37130", Sold = true }
    };

    static Random random = new Random();

    static void Main()
    {
        // Greeting Message
        Console.WriteLine("Welcome to ExtraVert! Your go-to place for secondhand plants!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        // Main Menu Logic
        string choice = null;
        while (choice != "0")
        {
            Console.Clear();
            Console.WriteLine(@"Choose an option:
0. Exit
1. Display all plants
2. Post a plant to be adopted
3. Adopt a plant
4. Delist a plant
5. View Plant of the Day
6. Search for plants by light needs");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    Console.WriteLine("Goodbye!");
                    break;
                case "1":
                    DisplayAllPlants();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "2":
                    PostPlantToBeAdopted();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    AdoptAPlant();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "4":
                    DelistAPlant();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "5":
                    ViewPlantOfTheDay();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "6":
                    SearchForPlantsByLightNeeds();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void DisplayAllPlants()
    {
        Console.WriteLine("Available Plants:");
        for (int i = 0; i < plants.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {plants[i].Species} in {plants[i].City} {(plants[i].Sold ? "was sold" : "is available")} for {plants[i].AskingPrice} dollars");
        }
    }

    static void PostPlantToBeAdopted()
    {
        Console.Write("Enter the species of the plant: ");
        string species = Console.ReadLine();

        Console.Write("Enter the light needs of the plant (1-5): ");
        int lightNeeds = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the asking price of the plant: ");
        decimal askingPrice = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter the city where the plant is located: ");
        string city = Console.ReadLine();

        Console.Write("Enter the zip code where the plant is located: ");
        string zip = Console.ReadLine();

        Plant newPlant = new Plant()
        {
            Species = species,
            LightNeeds = lightNeeds,
            AskingPrice = askingPrice,
            City = city,
            ZIP = zip,
            Sold = false
        };

        plants.Add(newPlant);
        Console.WriteLine("Plant added successfully!");
    }

    static void AdoptAPlant()
    {
        List<Plant> availablePlants = plants.FindAll(p => !p.Sold);

        if (availablePlants.Count == 0)
        {
            Console.WriteLine("No plants available for adoption.");
            return;
        }

        Console.WriteLine("Available Plants:");
        for (int i = 0; i < availablePlants.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {availablePlants[i].Species} in {availablePlants[i].City} is available for {availablePlants[i].AskingPrice} dollars");
        }

        Console.Write("Enter the number of the plant you want to adopt: ");
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= availablePlants.Count)
        {
            Console.WriteLine("Invalid choice. Please choose a valid option.");
            return;
        }

        availablePlants[choice].Sold = true;
        Console.WriteLine("Plant adopted successfully!");
    }

    static void DelistAPlant()
    {
        if (plants.Count == 0)
        {
            Console.WriteLine("No plants to delist.");
            return;
        }

        Console.WriteLine("All Plants:");
        for (int i = 0; i < plants.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {plants[i].Species} in {plants[i].City} {(plants[i].Sold ? "was sold" : "is available")} for {plants[i].AskingPrice} dollars");
        }

        Console.Write("Enter the number of the plant you want to delist: ");
        int choice = Convert.ToInt32(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= plants.Count)
        {
            Console.WriteLine("Invalid choice. Please choose a valid option.");
            return;
        }

        plants.RemoveAt(choice);
        Console.WriteLine("Plant delisted successfully!");
    }

    static void ViewPlantOfTheDay()
    {
        Plant plantOfTheDay = null;
        while (plantOfTheDay == null)
        {
            int randomIndex = random.Next(0, plants.Count);
            if (!plants[randomIndex].Sold)
            {
                plantOfTheDay = plants[randomIndex];
            }
        }

        Console.WriteLine($"Plant of the Day: {plantOfTheDay.Species} in {plantOfTheDay.City}");
        Console.WriteLine($"Light Needs: {plantOfTheDay.LightNeeds}/5");
        Console.WriteLine($"Asking Price: ${plantOfTheDay.AskingPrice}");
    }

    static void SearchForPlantsByLightNeeds()
    {
        Console.Write("Enter the maximum light needs (1-5): ");
        int maxLightNeeds = Convert.ToInt32(Console.ReadLine());

        List<Plant> matchingPlants = new List<Plant>();

        foreach (Plant plant in plants)
        {
            if (plant.LightNeeds <= maxLightNeeds && !plant.Sold)
            {
                matchingPlants.Add(plant);
            }
        }

        if (matchingPlants.Count == 0)
        {
            Console.WriteLine("No plants found with the specified light needs.");
            return;
        }

        Console.WriteLine("Plants with the specified light needs:");
        for (int i = 0; i < matchingPlants.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {matchingPlants[i].Species} in {matchingPlants[i].City} is available for {matchingPlants[i].AskingPrice} dollars");
        }
    }
}
