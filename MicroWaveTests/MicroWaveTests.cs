using Xunit;
using System;
using System.IO;

public class MicroWaveTests
{
    [Fact]
    public void MicroWave_Constructor_SetsPropertiesCorrectly()
    {
        
        var microwave = new MicroWave("Brand", 2020, 500, 99.99, 200, 800);

        
        Assert.Equal(200, microwave.MaxTemp);
        Assert.Equal(800, microwave.Power);
    }


    [Fact]
    public void Print_OutputsAdditionalInformation()
    {
        var microwave = new MicroWave("Micro", 2021, 200, 100, 300, 900);
        using var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        microwave.Print();
        var output = stringWriter.ToString();

        Assert.Contains("Maximal temperature: 300", output);
        Assert.Contains("Power: 900", output);
    }

    [Fact]
    public void GetMethods_OverrideBaseMethods()
    {
        Tech microwave = new MicroWave("Brand", 2020, 500, 99.99, 200, 800);
        Assert.Equal("Brand", microwave.GetManufacturer());
        Assert.Equal(99.99, microwave.GetPrice());
        Assert.Equal(2020, microwave.GetYear());
        Assert.Equal(500, microwave.GetVal());
    }

    [Fact]
    public void MicroWave_PolymorphicPrint_CallsOverriddenMethod()
    {
        Tech tech = new MicroWave("MicroBrand", 2021, 200, 100, 350, 950);
        using var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        tech.Print();
        var output = stringWriter.ToString();

        Assert.Contains("Maximal temperature: 350", output);
        Assert.Contains("Power: 950", output);
        Assert.Contains("Manufacturer: MicroBrand", output);
    }
}