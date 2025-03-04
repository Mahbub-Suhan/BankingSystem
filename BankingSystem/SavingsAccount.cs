using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class SavingsAccount : Accounts
    {
        public int accNum;
        public string name;
        private double balance;
        public float interest;

        public SavingsAccount(int accNumber, string accName, double accBalance, float interest): base(accNumber,accName,accBalance)
        {
            this.accNum = accNumber;
            this.name = accName;
            this.balance = accBalance;
            this.interest = interest;
        }
    }
}
