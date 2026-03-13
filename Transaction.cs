using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    public class Transaction
    {
        public string Type { get; }
        public decimal Amount { get; }
        public DateTime Date { get; }

        public Transaction(string type, decimal amount)
        {
            Type = type;
            Amount = amount;
            Date = DateTime.Now;
        }
    }
}
