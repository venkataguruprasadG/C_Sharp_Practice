using System;

public class StudentGradeProcessor
{
    public double Entermarks()
    {
        int [] marks = new int[5];

        int total1 = 0;

        for(int i=0;i<marks.Length;i++)
        {
            marks[i]=Convert.ToInt32(Console.ReadLine());
            total1+=marks[i];
        }

        double average1 = (double)total1 / marks.Length;

        Console.WriteLine($"\nTotal Marks: {total1}");
        Console.WriteLine($"Average Marks: {average1}");
        
        return average1;
    }

    public string GetGrade(double average1)
    {
        if(average1 >= 90)
        {
            return "A";
        }
        else if(average1 >=75)
        {
            return "B";
        }
        else if(average1 >= 60)
        {
            return "C";
        }
        else if(average1 >= 35)
        {
            return "D";
        }
        else{
            return "F";
        }
    }

    public void Displayresult()
    {
        double avg = Entermarks();
        string grade = GetGrade(avg);

        Console.WriteLine($"Grade: {grade}");
    }
}