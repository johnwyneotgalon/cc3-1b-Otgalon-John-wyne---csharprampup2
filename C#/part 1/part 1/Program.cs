using System;
using System.Threading;

class LoveStory
{
    static void Main()
    {
        // Part 1 - Weight conversion
        Console.Write("Enter weight in Pounds (lbs): ");
        double weightPounds = ConvertToDoubleWithValidation();
        double weightKilograms = weightPounds * 0.453592;
        DisplayConversionResult("Weight in Pounds (lbs)", weightPounds, "Weight converted to Kilograms (kg)", weightKilograms);

        // Part 2 - Distance conversion
        Console.Write("Enter length in Miles (mi): ");
        double lengthMiles = ConvertToDoubleWithValidation();
        double lengthKilometers = lengthMiles * 1.60934;
        DisplayConversionResult("Length in Miles (mi)", lengthMiles, "Length in Kilometers (km)", lengthKilometers);

        // Part 3 - Temperature conversion
        Console.Write("Enter temperature in Fahrenheit (F): ");
        double temperatureFahrenheit = ConvertToDoubleWithValidation();
        double temperatureCelsius = (temperatureFahrenheit - 32) * 5.0 / 9.0;
        DisplayConversionResult("Temperature in Fahrenheit (F)", temperatureFahrenheit, "Temperature in Celsius (C)", temperatureCelsius);

        // Part 4 - Average age calculation
        int totalAge = 0;
        const int numberOfStudents = 10;
        for (int i = 1; i <= numberOfStudents; i++)
        {
            Console.Write($"Enter age of Student {i}: ");
            totalAge += ConvertToIntWithValidation();
        }
        double averageAge = (double)totalAge / numberOfStudents;
        DisplayAgesAndAverage(totalAge, averageAge);

        // Introduce a 10-second delay before showing the epic love story
        Console.WriteLine("\nPreparing the epic love story...");
        Thread.Sleep(10000); // 10 seconds

        // Part 5 - Love story
        string knightName = "The Real";
        string damselName = "Princess KAila";
        string villainName = "Darklord Malgrim";
        string enchantedPlace = "within the mystical Crystal Grove";
        string heroicGesture = "defeating the villain with a mighty swing of his enchanted sword";
        string romanticGesture1 = "saving the day, Sir Valor and Princess Seraphina locked eyes";
        string romanticGesture2 = "and love blossomed amidst the enchanting glow of the Crystal Grove";

        string loveStory = $@"
Once upon a time, in a magical land filled with both ordinary and extraordinary, our adventure begins...

{GenerateConversionOutput("Weight", weightPounds, weightKilograms)}
{GenerateConversionOutput("Length", lengthMiles, lengthKilometers)}
{GenerateConversionOutput("Temperature", temperatureFahrenheit, temperatureCelsius)}
{GenerateAgesOutput(totalAge, averageAge)}

Story Time!

In the realm of Eldoria, a legendary knight named {knightName} was renowned for his unmatched strength.
One day, the evil {villainName} captured the beautiful {damselName} and imprisoned her {enchantedPlace}.

The entire kingdom trembled, but fear not, for Sir Valor, with his trusty sword 'Soulcleaver,' embarked on a perilous journey.
Battling mythical creatures and overcoming magical barriers, he finally confronted Darklord Malgrim, {heroicGesture}.

With the villain defeated, {romanticGesture1}. As the stars aligned, {romanticGesture2}.

And so, in the radiant glow of the Crystal Grove, Sir Valor and Princess Seraphina began their journey of love, laughter, and eternal happiness.";

        Console.WriteLine(loveStory);
    }

    static string GenerateConversionOutput(string unit, double value1, double value2)
    {
        return $"{unit}: {value1}\nConverted: {value2}\n========================================";
    }

    static string GenerateAgesOutput(int totalAge, double averageAge)
    {
        return $"Ages of students: {totalAge}\nAverage age: {averageAge}\n=========================================";
    }

    static double ConvertToDoubleWithValidation()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result) || result <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
            Console.Write("Try again: ");
        }
        return result;
    }

    static int ConvertToIntWithValidation()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
            Console.Write("Try again: ");
        }
        return result;
    }

    static void DisplayConversionResult(string unit1, double value1, string unit2, double value2)
    {
        Console.WriteLine($"{unit1}: {value1}");
        Console.WriteLine($"{unit2}: {value2}");
        Console.WriteLine("========================================");
    }

    static void DisplayAgesAndAverage(int totalAge, double averageAge)
    {
        Console.WriteLine($"The ages of the students are: {totalAge}");
        Console.WriteLine($"The average age of the students is: {averageAge}");
        Console.WriteLine("=========================================");
    }
}
