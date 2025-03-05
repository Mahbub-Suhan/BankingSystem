using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Accounts
    {
        
        public int accNum { get; }
        public string name { get; }
        protected double balance;

        public double Balance => balance;
        //It provides encapsulation, allowing external code to read the balance but not modify it directly.

        public Accounts(int accNumber, string accName, double accBalance) 
        {
            this.accNum = accNumber;
            this.name = accName;
            this.balance = accBalance;

        }
        public virtual void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited ${amount:F2}. New balance: ${balance:F2}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew ${amount:F2}. Remaining balance: ${balance:F2}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
    }
}
