using System;
using System.Net.Mail;

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

        StudentManager stm = new StudentManager();
        stm.DisplayDefaultstudent();
        
        string summary = stm.GenerateStudentSummary("Ramu",30,"Btech");
        Console.WriteLine(summary);

        string result = stm.CalculateAverage(70,80,100);
        Console.WriteLine(result);

        stm.PrintDetails();
        stm.PrintDetails("Data saved successfully");

        StudentGradeProcessor s = new StudentGradeProcessor();
        s.Displayresult();

        Laptop lp = new Laptop("XYM",000000,16);
        
        Movie mv = new Movie("Interstellar", "Christopher Nolan", 169);
        mv.DisplayDetails();

        Rectangle rc = new Rectangle(20,20);
        rc.CalculateArea();
        rc.Calculateperimeter();
        Console.WriteLine("Area: " + rc.CalculateArea());
        Console.WriteLine("Perimeter: " + rc.Calculateperimeter());


        Student stu = new Student("XYZ",98,90);
        stu.Result();
    }
}