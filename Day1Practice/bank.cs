using System;

class Bank
{
    private string? Acc_name;

    private double balance;

    public double Balance
{
    get { return balance; } // lets you READ the balance
    set
    {
        if (value >= 0)     // safe way to WRITE a new value
            balance = value;
        else
            Console.WriteLine("Balance cannot be negative.");
    }
}

    public Bank(string Acc_name, double balance)
    {
        this.Acc_name=Acc_name;
        this.balance=balance;
        Console.WriteLine($"Account created for {Acc_name} with initial balance {balance}");
    }

    public static void BankName()
    {
        Console.WriteLine("Hellow customer warm welcome to the ABC Bank");
    }

    public void Deposit(double amount)
    {
        if(amount > 0)
        {
            balance+=amount;
            Console.WriteLine($"Deposited amount: {amount}.New Balance: {balance} ");
        }
        else{
            Console.WriteLine("Invallid amount");
        }
    }

    public void Withdraw(double amount){
        if(amount>0 && amount <=balance)
        {
            balance-=amount;
            Console.WriteLine($"Withdraw amount: {amount}.New Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid withdraw amount");
        }
    }

    public void AccountDetailsShow()
    {
        Console.WriteLine($"Account Holder Name: {Acc_name} | Balance: {balance}");
    }
}