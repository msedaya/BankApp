using BankApp;
//using System.Globalization;

//CultureInfo.CurrentCulture = new CultureInfo("en-US");
Console.WriteLine("\n====== Bank App ======\n");

Console.WriteLine("What is your name?");
string name = Console.ReadLine() ?? "Unknown";

BankAccount account = new BankAccount(name, 100m);

decimal balance = 100m;
bool running = true;

while (running)
{
    Console.WriteLine($"\nWelcome, {account.Owner}! Balance: ₱{account.Balance:N2}");
    Console.WriteLine("==========================================");
    Console.WriteLine("1. Check Balance");
    Console.WriteLine("2. Deposit");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Exit");
    Console.WriteLine("5. Transaction History");

    Console.Write("Choose an option: ");
    string choice = Console.ReadLine() ?? string.Empty;

    if (choice == "1")
    {
        account.PrintBalance();
    }
    else if (choice == "2") 
    {
        Console.Write("How much you want to deposit: ");
        string input = Console.ReadLine() ?? "0";
        //decimal amount = decimal.Parse(input);
        if (!decimal.TryParse(input, out decimal amount) || amount <= 0)
        {
            Console.WriteLine("Invalid amount. Please enter a positive number.");
            continue;
        }
        account.Deposit(amount);
    }
    else if (choice == "3") 
    { 
        Console.WriteLine("How much you want to withdraw");
        string input = Console.ReadLine() ?? "0";
        if (!decimal.TryParse(input, out decimal amount) || amount <= 0)
        {
            Console.WriteLine("Invalid amount. Please enter a positive number.");
            continue;
        }
        account.Withdraw(amount);
    }
    else if (choice == "4")
    {
        Console.WriteLine("Thank you for using the Bank App. Goodbye!");
        running = false;
    }
    else if (choice == "5")
    {
        account.PrintHistory();
    }
    else
    {
        Console.WriteLine("Invalid option. Please try again.");
    }
}