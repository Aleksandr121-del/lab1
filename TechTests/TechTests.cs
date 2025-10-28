using Xunit;
using System;
using System.IO;

public class TechTests
{
    [Fact]
    public void Tech_GetMethods_ReturnCorrectValues()
    {
        var tech = new Tech("Samsung", 2020, 1000, 500.0);

        
        Assert.Equal("Samsung", tech.GetManufacturer());
        Assert.Equal(500.0, tech.GetPrice());
        Assert.Equal(2020, tech.GetYear());
        Assert.Equal(1000, tech.GetVal());
    }


    [Fact]
    public void Print_OutputsCorrectInformation()
    {
        var tech = new Tech("Test", 1800, 100, 50);
        using var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        tech.Print();
        var output = stringWriter.ToString();

        Assert.Contains("Manufacturer: Test", output);
        Assert.Contains("Price: 50", output);
        Assert.Contains("Year: 2020", output);
        Assert.Contains("Value: 100", output);
    }
}