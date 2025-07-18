using System;

class ATM
{
    static void Main()
    {
        int pin = 1234;
        int balance = 10000;
        bool isAuthenticated=false;

        Console.Write("Enter PIN: ");
        int enteredPin = Convert.ToInt32(Console.ReadLine());

        if (enteredPin == pin)
        {
            isAuthenticated = true;
            Console.WriteLine("Login successful!");
        }
        else
        {
            Console.WriteLine("Incorrect PIN. Access denied.");
            return; // Exit the program
        }

        while (true)
        {
            Console.WriteLine("\n----- ATM MENU -----");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your current balance is: ₹{balance}");
                    break;

                case 2:
                    Console.Write("Enter amount to deposit: ");
                    int depositAmount = Convert.ToInt32(Console.ReadLine());
                    balance += depositAmount;
                    Console.WriteLine($"₹{depositAmount} deposited successfully.");
                    break;

                case 3:
                    Console.Write("Enter amount to withdraw: ");
                    int withdrawAmount = Convert.ToInt32(Console.ReadLine());
                    if (withdrawAmount <= balance)
                    {
                        balance -= withdrawAmount;
                        Console.WriteLine($"₹{withdrawAmount} withdrawn successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient balance.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    return; // Exit the program

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            continue; // Go back to menu
        }
    }
}
