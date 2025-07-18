using System;

class D2
{
    public void Student()
    {
        
        Console.WriteLine("--if else and else if Problem--");
        
        int StuScore = Convert.ToInt32(Console.ReadLine());

        if (StuScore >= 90)
        {
            Console.WriteLine("A");
        }
        else if(StuScore >= 75)
        {
            Console.WriteLine("B");
        }
        else if(StuScore >= 60)
        {
            Console.WriteLine("C");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
}