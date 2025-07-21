using System;

public class Laptop
{
    string? brand;
    int? price;
    int? ram;
    static Laptop()
    {
        Console.WriteLine("Welcome to the Laptop Store");
    }

    public Laptop()
    {
        Console.WriteLine("New Instance of Laptop is Created");
    }

    public Laptop(string brand,int price, int ram)
    {
        this.brand=brand;
        this.price=price;
        this.ram=ram;
        Console.WriteLine($"brand: {brand} | Price: {price} | RAM: {ram}");
    }
}

public class Movie
{
    string? title;
    string? director;
    double duration;

    public Movie(string title, string director, double duration)
    {
        this.title = title;
        this.director = director;
        this.duration = duration;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Movie: {title} \n Director: {director} \n Duration {duration} minutes");
    }
}

public class Rectangle
{
    int Length;
    int Breadth;
    public Rectangle(int length, int breadth)
    {
        Length=length;
        Breadth=breadth;
    }

    public int Calculateperimeter()
    {
        return 2*(Length+Breadth);
    }

    public int CalculateArea()
    {
        return Length*Breadth;
    }
}

public class Student
{
    string name;
    int roll_no;
    int marks;
    public Student(string name,int roll_no,int marks)
    {
        this.name=name;
        this.roll_no=roll_no;
        this.marks=marks;
    }

    public void Result()
    {
        if(marks>=40)
        {
            Console.WriteLine("passed");
        }
        else{
            
            Console.WriteLine("failed");
        }
    }
}

