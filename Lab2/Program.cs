using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var objectsList = new List<Tech>();

        while (true)
        {
            Console.Write("Choose object type (T - Tech, F - Frige, M - MicroWave, E - Exit): ");
            var choice = Console.ReadLine()?.ToUpper();

            if (choice == "E") break;

            try
            {
                switch (choice)
                {
                    case "T":
                        objectsList.Add(CreateTech());
                        break;
                    case "F":
                        objectsList.Add(CreateFrige());
                        break;
                    case "M":
                        objectsList.Add(CreateMicroWave());
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        Console.WriteLine("\nObjects in the list:");
        Console.WriteLine("----------------------");
        foreach (var obj in objectsList)
        {
            obj.Print();
            Console.WriteLine("----------------------");
        }
    }

    static Tech CreateTech()
    {
        Console.Write("Enter manufacturer: ");
        var manufacturer = Console.ReadLine();
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Enter value: ");
        int value = int.Parse(Console.ReadLine());
        Console.Write("Enter price: ");
        double price = double.Parse(Console.ReadLine());
        return new Tech(manufacturer, year, value, price);
    }

    static Frige CreateFrige()
    {
        var tech = CreateTech();
        Console.Write("Enter minimal temperature: ");
        double minTemp = double.Parse(Console.ReadLine());
        Console.Write("Enter weight: ");
        double weight = double.Parse(Console.ReadLine());
        return new Frige(tech.Manufacturer, tech.Year, tech.Value, tech.Price, minTemp, weight);
    }

    static MicroWave CreateMicroWave()
    {
        var tech = CreateTech();
        Console.Write("Enter maximal temperature: ");
        double maxTemp = double.Parse(Console.ReadLine());
        Console.Write("Enter power: ");
        double power = double.Parse(Console.ReadLine());
        return new MicroWave(tech.Manufacturer, tech.Year, tech.Value, tech.Price, maxTemp, power);
    }
}