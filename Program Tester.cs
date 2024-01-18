using Xunit; 

namespace application.Tests
{
    public class PersonnummerVerifieraTests
    {
        [Fact]
        public void Verifiera_GiltigtPersonnummer_ReturnerarTrue()
        {
            //Given
            string personnummer = "880821-4855";

            // When
            bool result = Program.IsValidSwedishpersonnummer(personnummer);

            // Then
            Assert.True(result);
        }

        [Fact]
        public void Verifiera_OgiltigtPersonnummer_ReturnerarFalse()
        {
            // Given
            string personnummer = "9003994855";

            // When
            bool result = Program.IsValidSwedishpersonnummer(personnummer);

            // Then
            Assert.False(result);
        }

        [Fact]
        public void Verifiera_kön_ReturnTrue()
        {
            // Given
            string gender = "Man";
            string personnummer = "900399-4855";

            // When
            string result = Program.GetGender(personnummer);
            bool result_bool = (result == "Man");
            // Then
            Assert.True(result_bool);
        }

        [Fact]
        public void Verifiera_kön_ReturnFalse()
        {
            // Given
            string gender = "Kvinna";
            string personnummer = "900399-4855";

            // When
            string result = Program.GetGender(personnummer);
            bool result_bool = (result == "Kvinna");
            // Then
            Assert.False(result_bool);
        }

        [Fact]
        public void Verify_Age_ReturnTrue()
        {
            // Given
            string personnummer = "050105-4855";

            // When
            int result = Program.CheckAge(personnummer);
            bool result_bool = (result == 19);
            // Then
            Assert.True(result_bool);
        }

        [Fact]
        public void Verify_Age_ReturnFalse()
        {
            // Given
            string personnummer = "031205-4855";

            // When
            int result = Program.CheckAge(personnummer);
            bool result_bool = (result == 19);
            // Then
            Assert.False(result_bool);
        }
    }
}