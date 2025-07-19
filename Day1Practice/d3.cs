using System;
using System.IO;

class D3
{
    public void Welcome(){
        string Name = "guru";
        int Age = 21;
        string Country = "India";

        Console.WriteLine("Name: "+Name +"Age: "+Age +"Country: "+Country);
    }

    string StudentName = "Ram";
    string rollno = "21";
    string marks = "98";
    public string DisplayStudent(string StudentName, string rollno, string marks){
        return StudentName + rollno + marks;
    }

    public int Add(int a, int b)
    {
        return a+b;
    }

    public void PrintInfo()
    {
        Console.WriteLine("Method with no paramerters");
    }
    public void PrintInfo(string info)
    {
        Console.WriteLine("Method with one parameter: "+info);
    }

    public void PrintInfo(string information, int date)
    {
        Console.WriteLine("String: "+information+"date: "+date);
    }
}