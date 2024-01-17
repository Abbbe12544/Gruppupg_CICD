using Xunit; 

namespace PersonnummerKontroll.Tests
{
    public class PersonnummerVerifieraTests
    {
        [Fact]
        public void Verifiera_GiltigtPersonnummer_ReturnerarTrue()
        {
            //Given
            string personnummer = "8808214855";

            // When
            bool result = PersonnummerVerifiera.Verifiera(personnummer);

            // Then
            Assert.True(result);
        }

        [Fact]
        public void Verifiera_OgiltigtPersonnummer_ReturnerarFalse()
        {
            // Given
            string personnummer = "9003994855";

            // When
            bool result = PersonnummerVerifiera.Verifiera(personnummer);

            // Then
            Assert.False(result);
        }
    }
}