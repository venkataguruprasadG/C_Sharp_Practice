using System;

public class Calculator
{
    public static int Add(int a, int b)
    {
        return a+b;
    }

    public int Multiply(int c, int d)
    {
        return c*d;
    }
}

public class Employee
{
    public required string name;
    public required string salary;
    public Employee(string name, string salary)
    {
        Console.WriteLine("Employee Created");
        this.name=name;
        this.salary=salary;
    }

    public void PrintDetails1()
    {
        Console.WriteLine($"Employee name: {name}");
        Console.WriteLine($"Salary: {salary}");
    }

    public class Account
    {
        private double _balance;

    // Public property with validation
    public double Balance
    {
        get { return _balance; }
        set
        {
            if (value >= 0)
            {
                _balance = value;
            }
            else
            {
                Console.WriteLine("❌ Error: Balance cannot be negative.");
            }
        }
    }
    }
}