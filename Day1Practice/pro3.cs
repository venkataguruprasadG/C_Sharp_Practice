using System;

class Program3
{
    public void logic()
    {
        int x = 10, y = 20;

        Console.WriteLine("Program 3 [Relational and logical operators use]")
        Console.WriteLine("x == y: " + (x == y));
        Console.WriteLine("x != y: " + (x != y));
        Console.WriteLine("x > y: " + (x > y));

        bool isAdult = (x >= 18);
        Console.WriteLine("Is Adult: " + isAdult);
    }
}
