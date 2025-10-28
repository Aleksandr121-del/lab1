    using System;
public class Frige : Tech
{
    public double MinTemp { get; set; }
    public double Weight { get; set; }

    public Frige(string manufacturer, int year, int value, double price, double minTemp, double weight)
        : base(manufacturer, year, value, price)
    {
        MinTemp = minTemp;
        Weight = weight;
    }

    public Frige() : base()
    {
        MinTemp = -10;
        Weight = 50;
    }

    
    public override string GetManufacturer() => base.GetManufacturer();
    public override double GetPrice() => base.GetPrice();
    public override int GetYear() => base.GetYear();
    public override int GetVal() => base.GetVal();

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Minimal temperature: {MinTemp}");
        Console.WriteLine($"Weight: {Weight}");
    }
}