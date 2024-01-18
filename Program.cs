namespace application
{
    public class Program
    {

    
        public const int personnummerLength = 11;
        public const string DateFormat = "yyMMdd";
        public const int SequencePartLength = 4;

        public static readonly string[] Cities = { "Stockholm", "Göteborg", "Malmö", "Uppsala", "Linköping" };

        public static string GetUserInput()
        {
            Console.Write("\nAnge ett svenskt personnummer (ÅÅMMDD-XXXX eller ÅÅMMDD+XXXX): ");
            return Console.ReadLine() ?? "";
        }

        public static bool IsValidSwedishpersonnummer(string personnummer)
        {
            if (personnummer.Length != personnummerLength ||
                (personnummer[6] != '-' && personnummer[6] != '+'))
            {
                return false;
            }

            string datePart = personnummer.Substring(0, 6);
            string sequencePart = personnummer.Substring(7, SequencePartLength);

            return DateTime.TryParseExact(datePart, DateFormat, null, System.Globalization.DateTimeStyles.None, out _) &&
                int.TryParse(sequencePart, out _);
        }

        public static string GetGender(string personnummer)
        {
            int genderDigit = int.Parse(personnummer.Substring(9, 1));
            return genderDigit % 2 == 0 ? "Kvinna" : "Man";
        }

        public static int§ CheckAge(string personnummer)
        {
            int birthYear = int.Parse(personnummer.Substring(0, 2)) + 2000;
            int currentYear = DateTime.Now.Year;

            int age = currentYear - birthYear;

            if (age < 0 || personnummer[6] == '+')
            {
                birthYear -= 100;
                age = currentYear - birthYear;
            }

            if (age >= 100)
            {
                return age;
            }
            else
            {
                return age;
            }
        }

        /*public static string GetCityOfBirth()
        {
            Random random = new Random();
            int randomIndex = random.Next(Cities.Length);

            return Cities[randomIndex];
        }*/
    }

}
