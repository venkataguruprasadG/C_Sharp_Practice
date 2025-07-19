using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class StudentManager
{
    string name="Ramesh";
    int age = 21;
    
    string course = "Btech";
    public void DisplayDefaultstudent()
    {
        Console.WriteLine("Name: "+name+"Age: "+age+"Course: "+course);
    }

    public string GenerateStudentSummary(string name, int age, string course)
    {
        return "Student "+name+"Age: "+age+"Course: "+course;
    }

    public string CalculateAverage(int m1, int m2, int m3)
    {
        float average=(m1+m2+m3)/3.0f;

        if(average >= 35)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }

    public void PrintDetails()
    {
        Console.WriteLine("end of the program");
    }

    public void PrintDetails(string message)
    {
        Console.WriteLine("Message: " + message + " || Time: " + DateTime.Now.ToShortTimeString());
    }
}