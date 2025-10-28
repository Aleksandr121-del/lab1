using System;

public class MicroWave : Tech
{
    public double MaxTemp { get; set; }
    public double Power { get; set; }

    public MicroWave(string manufacturer, int year, int value, double price, double maxTemp, double power)
        : base(manufacturer, year, value, price)
    {
        MaxTemp = maxTemp;
        Power = power;
    }

    public MicroWave() : base()
    {
        MaxTemp = 50;
        Power = 500;
    }

    
    public override string GetManufacturer() => base.GetManufacturer();
    public override double GetPrice() => base.GetPrice();
    public override int GetYear() => base.GetYear();
    public override int GetVal() => base.GetVal();

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Maximal temperature: {MaxTemp}");
        Console.WriteLine($"Power: {Power}");
    }
}