using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Accounts
    {
        
        public int accNum;
        public string name;
        public double balance;

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
                balance = balance + amount;
                Console.WriteLine("Deposited " + amount);
                Console.WriteLine("New balance: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }
    }
}
