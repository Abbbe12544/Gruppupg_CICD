using System;
using static System.Console; 
using Xunit; 


class Program
{
    private const int PersonalNumberLength = 11;
    private const string DateFormat = "yyMMdd";
    private const int SequencePartLength = 4;

    private static readonly string[] Cities = { "Stockholm", "Göteborg", "Malmö", "Uppsala", "Linköping" };

    static void Main()
    {
        Console.WriteLine("\nVälkommen till personnummerkontrollen!");

        while (true)
        {
            string input = GetUserInput();

            if (IsValidSwedishPersonalNumber(input))
            {
                Console.WriteLine($"Personnumret är giltigt. Könet är: {GetGender(input)}");
                CheckAgeAndCity(input);
            }
            else
            {
                Console.WriteLine("Ogiltigt personnummer. Försök igen.\n");
            }
        }
    }

    private static string GetUserInput()
    {
        Console.Write("\nAnge ett svenskt personnummer (ÅÅMMDD-XXXX eller ÅÅMMDD+XXXX): ");
        return Console.ReadLine() ?? "";
    }

    private static bool IsValidSwedishPersonalNumber(string personalNumber)
    {
        if (personalNumber.Length != PersonalNumberLength ||
            (personalNumber[6] != '-' && personalNumber[6] != '+'))
        {
            return false;
        }

        string datePart = personalNumber.Substring(0, 6);
        string sequencePart = personalNumber.Substring(7, SequencePartLength);

        return DateTime.TryParseExact(datePart, DateFormat, null, System.Globalization.DateTimeStyles.None, out _) &&
               int.TryParse(sequencePart, out _);
    }

    private static string GetGender(string personalNumber)
    {
        int genderDigit = int.Parse(personalNumber.Substring(9, 1));
        return genderDigit % 2 == 0 ? "Kvinna" : "Man";
    }

    private static void CheckAgeAndCity(string personalNumber)
    {
        int birthYear = int.Parse(personalNumber.Substring(0, 2)) + 2000;
        int currentYear = DateTime.Now.Year;

        int age = currentYear - birthYear;

        if (age < 0 || personalNumber[6] == '+')
        {
            birthYear -= 100;
            age = currentYear - birthYear;
        }

        Console.WriteLine($"Ålder: {age} år");

        if (age >= 100)
        {
            Console.WriteLine("Personen är över 100 år gammal.");
        }
        else
        {
            Console.WriteLine("Personen är under 100 år gammal.");
        }

        string cityOfBirth = GetCityOfBirth();
        Console.WriteLine($"Född i: {cityOfBirth}");
    }

    private static string GetCityOfBirth()
    {
        Random random = new Random();
        int randomIndex = random.Next(Cities.Length);

        return Cities[randomIndex];
    }
}
