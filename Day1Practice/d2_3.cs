using System;

class pro3
{
    public void looping()
    {
        Console.WriteLine("----Looping Problems----");
        for(int i=1;i<=10;i++)
        {
            Console.WriteLine(i);
        }

        int j=2;
        while(j<=20)
        {
            Console.WriteLine(j);
            j+=2;
        }

        int z=5;
        do
        {
            Console.WriteLine(z);
            z--;
        } while (z>=1);
    }
}