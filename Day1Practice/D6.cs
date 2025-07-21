using System;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

public class Car
{
    static Car()
    {
        Console.WriteLine("Welcome to car showroom");
    }

    public Car()
    {
        Console.WriteLine("New car is created");
    }

    public Car(string brand, int price)
    {
        Console.WriteLine($"Car Brand: {brand}. Price of the car: {price}");
    }
}
    public class Book
    {
        public string? title;
        public string? author;
        public int? price;
        public Book(string title, string author, int price)
        {
            this.title=title;
            this.author=author;
            this.price=price;

            Console.WriteLine($"Title of the book: {title}.Author of the book: {author}.Price of the book: {price}");
        }
    }

    public class Circle
{
    double radius;
    
    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}
