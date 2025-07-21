using System;

public class Car{
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

            Console.WriteLine($"")
        }
    }
}