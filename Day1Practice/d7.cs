using System;

internal class Employe
{
    private string? name;
    private double salary;

    public string? Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Salary
    {
        get { return salary; }
        set
        {
            if (value > 0)
                salary = value;
            else
                Console.WriteLine("Salary must be positive.");
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Employee Name: {Name} | Salary: {Salary}");
    }
}

public class Product
{
    public string? ProductName {get; set; }
    public double Price {get; set; }

    public void ShowProductDetails()
    {
        Console.WriteLine($"Product: {ProductName} | Price: {Price}");
    }
}

public class Vehicle
{
    public string Brand;
    public int Year;

    static Vehicle()
    {
        Console.WriteLine("Welcome to the Vehicle Inventory System");
    }

    public Vehicle()
    {
        Console.WriteLine("Default Vehicle created");
    }

    public Vehicle(string brand)
    {
        this.Brand = brand;
        Console.WriteLine($"Brand set to {Brand}");
    }

    public Vehicle(string brand, int year)
    {
        this.Brand = brand;
        this.Year = year;
        Console.WriteLine($"Brand: {Brand} | Year: {Year}");
    }

    public void Display()
    {
        Console.WriteLine($"Vehicle Brand: {Brand} | Manufacturing Year: {Year}");
    }
}

