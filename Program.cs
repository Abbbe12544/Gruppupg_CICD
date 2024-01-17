namespace PersonnummerKontroll
{
    public static class PersonnummerVerifiera
    {
        public static bool Verifiera(string personnummer)
        {
            // Kontrollera att personnumret har rätt längd.
            if (personnummer.Length != 10 && personnummer.Length != 11 && personnummer.Length != 12)
            {
                return false;
            }

            // Kontrollera att alla tecken är siffror (förutom eventuell bindestreck eller plus).
            foreach (char c in personnummer)
            {
                if (!char.IsDigit(c) && c != '-' && c != '+')
                {
                    return false;
                }
            }

            // Om personnumret är i formatet "ÅÅMMDDXXXX" eller "ÅÅMMDD-XXXX"
            if (personnummer.Length == 10 || personnummer.Length == 12)
            {
                int year = int.Parse(personnummer.Substring(0, 2));
                int month = int.Parse(personnummer.Substring(2, 2));
                int day = int.Parse(personnummer.Substring(4, 2));

                // En enkel kontroll för året, månaden och dagen.
                if (year < 0 || month < 1 || month > 12 || day < 1 || day > 31)
                {
                    return false;
                }
            }

            // Här kan vi lägga in fler kontroller av personnummer

            return true;
        }
    }
}



/*namespace application
{
    public class Program
    {

    
        public const int PersonalNumberLength = 11;
        public const string DateFormat = "yyMMdd";
        public const int SequencePartLength = 4;

        public static readonly string[] Cities = { "Stockholm", "Göteborg", "Malmö", "Uppsala", "Linköping" };

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

        public static string GetUserInput()
        {
            Console.Write("\nAnge ett svenskt personnummer (ÅÅMMDD-XXXX eller ÅÅMMDD+XXXX): ");
            return Console.ReadLine() ?? "";
        }

        public static bool IsValidSwedishPersonalNumber(string personalNumber)
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

        public static string GetGender(string personalNumber)
        {
            int genderDigit = int.Parse(personalNumber.Substring(9, 1));
            return genderDigit % 2 == 0 ? "Kvinna" : "Man";
        }

        public static void CheckAgeAndCity(string personalNumber)
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

        public static string GetCityOfBirth()
        {
            Random random = new Random();
            int randomIndex = random.Next(Cities.Length);

            return Cities[randomIndex];
        }
    }

}*/
