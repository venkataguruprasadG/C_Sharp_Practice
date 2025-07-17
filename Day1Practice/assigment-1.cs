using System;

class Assignment1
{
    // Class-level variables so both methods can access them
    string name = "Guru";
    int roll_no = 201;
    float math = 87, science = 95, english = 70;

    public void StudentDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll Number: " + roll_no);
        Console.WriteLine("Math Marks: " + math);
        Console.WriteLine("Science Marks: " + science);
        Console.WriteLine("English Marks: " + english);
    }

    public void MarksCalculation()
    {
        float total_marks = math + science + english;
        float avg_marks = total_marks / 3.0f;

        string result = (math >= 35 && science >= 35 && english >= 35) ? "Pass" : "Fail";

        Console.WriteLine("Total Marks: " + total_marks);
        Console.WriteLine("Average Marks: " + avg_marks);
        Console.WriteLine("Result: " + result);
    }
}
