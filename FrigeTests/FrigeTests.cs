using Xunit;
using System;
using System.IO;

public class FrigeTests
{
    [Fact]
    public void Frige_Constructor_SetsPropertiesCorrectly()
    {
        
        var frige = new Frige("Brand", 2021, 300, 199.99, -20, 60);

        
        Assert.Equal(-20, frige.MinTemp);
        Assert.Equal(60, frige.Weight);
        Assert.Equal("Brand", frige.GetManufacturer());
    }

    [Fact]
    public void Print_OutputsAdditionalInformation()
    {
        var frige = new Frige("Frige", 2022, 300, 200, -20, 70);
        using var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        frige.Print();
        var output = stringWriter.ToString();

        Assert.Contains("Minimal temperature: -20", output);
        Assert.Contains("Weight: 70", output);
    }

    [Fact]
    public void GetMethods_OverrideBaseMethods()
    {
        Tech frige = new Frige("Brand", 2021, 300, 199.99, -20, 60);
        Assert.Equal("Brand", frige.GetManufacturer());
        Assert.Equal(199.99, frige.GetPrice());
        Assert.Equal(2021, frige.GetYear());
        Assert.Equal(300, frige.GetVal());
    }
    [Fact]
    public void Frige_PolymorphicPrint_CallsOverriddenMethod()
    {
        
        Tech tech = new Frige("FrigeBrand", 2022, 300, 200, -25, 65);
        using var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        
        tech.Print();
        var output = stringWriter.ToString();

        
        Assert.Contains("Minimal temperature: -25", output);
        Assert.Contains("Weight: 65", output);
        Assert.Contains("Manufacturer: FrigeBrand", output);
    }
}