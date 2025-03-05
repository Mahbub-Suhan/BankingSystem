using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class SavingsAccount : Accounts
    {
       
        public float intRate { get; }

        public SavingsAccount(int accNumber, string accName, double accBalance, float interest): base(accNumber,accName,accBalance)
        {
            this.intRate = interest;
        }

        public void ApplyInterest()
        {
            double interest = balance * (intRate / 100);
            balance += interest;
            Console.WriteLine($"Interest applied: ${interest:F2}. New balance: ${balance:F2}");
        }
    }
}
