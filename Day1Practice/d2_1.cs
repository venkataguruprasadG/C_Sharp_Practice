using System;

class D2_1{
    public void WeekDays(){
        
        Console.WriteLine("---Switch Statement Problem---");

        int day = Convert.ToInt32(Console.ReadLine());

        switch(day)
        {
            case 1:
            Console.WriteLine("Sunday");
            break;

            case 2:
            Console.WriteLine("Monday");
            break;

            case 3:
            Console.WriteLine("Tuesday");
            break;

            case 4:
            Console.WriteLine("Wednesday");
            break;

            case 5:
            Console.WriteLine("Thursday");
            break;

            case 6:
            Console.WriteLine("Friday");
            break;

            case 7:
            Console.WriteLine("Saturday");
            break;

            default:
            Console.WriteLine("Enter the valid day");
            break;
        }
    }
}