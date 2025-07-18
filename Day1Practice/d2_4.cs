using System;
using System.Diagnostics.Contracts;

class Pro4
{
    public void breaking()
    {
        for(int i=0;i<=10;i++)
        {
            if(i==5)
            continue;
            Console.WriteLine(i);
        }

        for(int j=0;j<=10;j++)
        {
            if(j==7)
            break;
            Console.WriteLine(j);
        }
    }
}