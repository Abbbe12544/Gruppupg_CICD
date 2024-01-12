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
        //Jag tappar det på Git
    }
    
    [Fact]
    public void TestBirthPlace()
    {

    }

    [Fact]
    public void TestGender()
    {

    } 
}

