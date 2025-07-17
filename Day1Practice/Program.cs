using System;

class Program
{
    static void Main()
    {
        string name = "guru";
        int age = 21;
        float height = 6.0f;

        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine("Height: "+height);

        Program1 obj = new Program1();
        obj.operations();

        Program3 obj2 = new Program3();
        obj2.logic();

        Assignment1 obj3 = new Assignment1();
        obj3.StudentDetails();
        obj3.MarksCalculation();
    }
}