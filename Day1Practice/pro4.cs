using System;
using System.IO;

public class pro4
{
    public void StudentMarksShow()
    {
    int [] StudentMarks = new int[5];

    int total = 0;

    Console.WriteLine("Enter marks for 5 students");

    for(int i=0;i<StudentMarks.Length;i++)
    {
        Console.Write($"Student marks {i+1} marks: ");
        StudentMarks[i]=Convert.ToInt32(Console.ReadLine());
        total+=StudentMarks[i];
    }

    double average = (double)total / StudentMarks.Length;

    Console.WriteLine($"\nTotal Marks: {total}");
    Console.WriteLine($"Average Marks: {average:F2}");
    }

    public void TimeTable()
    {
        string[,] timetable = new string[5, 4]
        {
            { "Math", "English", "Physics", "Chemistry" },
            { "Biology", "Math", "Geography", "English" },
            { "History", "Chemistry", "Math", "Computer" },
            { "English", "Physics", "Art", "Math" },
            { "Computer", "Biology", "English", "Physical Ed." }
        };

        string[] days = { "Mon", "Tue", "Wed", "Thu", "Fri" };

        Console.WriteLine("📚 Weekly School Timetable:\n");

        for (int i = 0; i < timetable.GetLength(0); i++)
        {
            Console.Write(days[i] + ":\t");

            for (int j = 0; j < timetable.GetLength(1); j++)
            {
                Console.Write(timetable[i, j] + "\t");
            }

            Console.WriteLine();  // Newline after each day
        }
    }

    public void StringFunctions()
    {
        
        Console.WriteLine("Enter a sentece or a word");
        string? user = Console.ReadLine();

        Console.WriteLine("String to upper: "+ user.ToUpper());
        Console.WriteLine("String to upper: "+ user.ToLower());
        Console.WriteLine("String to upper: "+ user.Length);
        Console.WriteLine("String to upper: "+ user.Contains("a"));
        Console.WriteLine("String to upper: "+ user.Trim());
    }

    public void DivisionHandler()
    {
        try{
            int numerator = Convert.ToInt32(Console.ReadLine());
            int demoninator = Convert.ToInt32(Console.ReadLine());

            int result = numerator / demoninator;
            Console.WriteLine($"Result: {result}");
        }
        catch (DivideByZeroException)
        {
         Console.WriteLine("❌ Error: Division by zero is not allowed.");
        }
    }
}