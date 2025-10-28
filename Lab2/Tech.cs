public class Tech
{
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    public int Value { get; set; }
    public double Price { get; set; }

    public Tech(string manufacturer, int year, int value, double price)
    {
        Manufacturer = manufacturer;
        Year = (year > 1900 && year < 2026) ? year : 2020;
        Value = value > 0 ? value : 1000;
        Price = price > 0 ? price : 100;
    }

    public Tech()
    {
        Manufacturer = "";
        Year = 0;
        Value = 0;
        Price = 0;
    }

    
    public virtual string GetManufacturer() => Manufacturer;
    public virtual double GetPrice() => Price;
    public virtual int GetYear() => Year;
    public virtual int GetVal() => Value;

    public virtual void Print()
    {
        Console.WriteLine($"Manufacturer: {GetManufacturer()}");
        Console.WriteLine($"Price: {GetPrice()}");
        Console.WriteLine($"Year: {GetYear()}");
        Console.WriteLine($"Value: {GetVal()}");
    }
}