using System; 
using static System.Console; 
using Xunit; 

public class PersonnummerTest 
{
    
    [Fact]
    public void TestLength()
    {
        //Arrange
        var validator = new PersonnummerValidator();
        string validPersonnummer = "910101-1234";
        string invalidPersonnummer = "12345678901"; 

        // Act
        var validResult = validator.Validate(validPersonnummer);
        var invalidResult = validator.Validate(invalidPersonnummer);

        // Assert
        Assert.True(validResult); // Kontrollera att giltiga personnummer accepteras

        // Kontrollera att ogiltiga personnummer (för långa) inte accepteras
        Assert.False(invalidResult, "Personnummer längre än 10 tecken borde vara ogiltiga.");
    }
    
    [Fact]
    public void TestControlNum()
    {
        // Arrange
        var validator = new PersonnummerValidator();
        string validPersonnummer = "910101-1234";
        string invalidPersonnummer = "910101-5678";

        // Act
        var validResult = validator.ValidateControlNum(validPersonnummer);
        var invalidResult = validator.ValidateControlNum(invalidPersonnummer);

        // Assert
        Assert.True(validResult); // Kontrollera att giltiga kontrollsiffror accepteras

        // Kontrollera att ogiltiga kontrollsiffror inte accepteras
        Assert.False(invalidResult, "Ogiltig kontrollsiffra borde inte accepteras.");
    }

    [Fact]
    public void TestBirthPlace()
    {
        // Arrange
        var validator = new PersonnummerValidator();
        string validPersonnummer = "910101-1234";
        string invalidPersonnummer = "920202-5678";

        // Act
        var validResult = validator.ValidateBirthPlace(validPersonnummer);
        var invalidResult = validator.ValidateBirthPlace(invalidPersonnummer);

        // Assert
        Assert.True(validResult); // Kontrollera att giltigt födelseort accepteras

        // Kontrollera att ogiltigt födelseort inte accepteras
        Assert.False(invalidResult, "Ogiltig födelseort borde inte accepteras.");
    }

    [Fact]
    public void TestGender()
    {
        // Arrange
        var validator = new PersonnummerValidator();
        string malePersonnummer = "910101-1234";
        string femalePersonnummer = "910101-5678";

        // Act
        var maleResult = validator.ValidateGender(malePersonnummer, Gender.Male);
        var femaleResult = validator.ValidateGender(femalePersonnummer, Gender.Female);

        // Assert
        Assert.True(maleResult); // Kontrollera att manliga personnummer accepteras
        Assert.True(femaleResult); // Kontrollera att kvinnliga personnummer accepteras
    }
}

