using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class BankAccount
    {
        public string? AccountNumber { get; }
        public string? AccountHolderName { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Invalid withdraw amount.");
            }
        }
    }
}
