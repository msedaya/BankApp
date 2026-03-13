using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    public class BankAccount
    {
        public string Owner {  get; set; }
        public decimal Balance { get; set; }

        private List<Transaction> _history = new();

        public BankAccount(string owner, decimal startingBalance)
        {
            Owner = owner;
            Balance = startingBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            _history.Add(new Transaction("Deposit", amount));
            Console.WriteLine($"Deposit successfull! New Balance: ₱{Balance:N2}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                Balance -= amount;
                _history.Add(new Transaction("Withdrawal", amount));
                Console.WriteLine($"Withdrawal successfull! New Balance: ₱{Balance:N2}");
            }
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Your balance is ₱{Balance:N2}");
        }
        public void PrintHistory()
        {
            if (_history.Count == 0)
            {
                Console.WriteLine("No transactions yet.");
                return;
            }

            Console.WriteLine("\n--- Transaction History ---");
            foreach (Transaction t in _history)
            {
                Console.WriteLine($"{t.Date:MM/dd/yyyy HH:mm} | {t.Type,-12} | ₱{t.Amount:N2}");
            }
            Console.WriteLine("---------------------------");
        }
    }
}
