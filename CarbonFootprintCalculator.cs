using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Carbon Footprint Calculator");

        Console.WriteLine("This program calculates your carbon footprint based on your daily activities.");

        Console.WriteLine("Please provide the following information:");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter kilometers traveled per day: ");
        double kilometersPerDay = double.Parse(Console.ReadLine());

        Console.Write("Enter hours of electronic device usage per day: ");
        int hoursOfElectronics = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of meals containing meat per day: ");
        int mealsWithMeat = int.Parse(Console.ReadLine());

        double carbonFootprint = CalculateCarbonFootprint(kilometersPerDay, hoursOfElectronics, mealsWithMeat);

        Console.WriteLine();
        Console.WriteLine($"Dear {name}, based on the information provided, your estimated carbon footprint is {carbonFootprint} tons of CO2 per year.");

        Console.WriteLine("Remember, every small change can make a big difference!");
        
        Console.ReadLine();
    }

    static double CalculateCarbonFootprint(double kilometersPerDay, int hoursOfElectronics, int mealsWithMeat)
    {
        double totalKilometers = kilometersPerDay * 365 * 0.2;
        double totalHoursOfElectronics = hoursOfElectronics * 0.1;
        double totalMealsWithMeat = mealsWithMeat * 0.5;

        return totalKilometers + totalHoursOfElectronics + totalMealsWithMeat;
    }
}
