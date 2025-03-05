using System;
using System.Collections.Concurrent;
using System.Collections.Generic;


namespace BankingSystem
{
    class Program
    {
        static List<Accounts> accounts = new List<Accounts>();

        static void Main()
        {

            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Simple Banking System");
                Console.WriteLine("Options are below \n");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Apply Interest (Savings Account)");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string selected = Console.ReadLine();
                //Console.WriteLine("the value you gave is " + selected);
                switch (selected)
                {
                    case "1": CreateAccount(); break;
                    case "2": Deposit(); break;
                    case "3": Withdraw(); break;
                    case "4": CheckBalance(); break;
                    case "5": ApplyInterest(); break;
                    case "6": return;
                    default: Console.WriteLine("Invalid option. Try again."); break;
                }
            }
        }

        static void CreateAccount()
        {
            
            int type;
            Console.Write("Enter account type:\nType 1 for Regular Account \nType 2 for Savings Account  ");
            type = int.Parse(Console.ReadLine());

            

            //kichu common factors
            Console.Write("Enter Account Number: ");
            int accNumber = int.Parse(Console.ReadLine());

            Accounts account = FindAccount(accNumber);
            if (accounts.Exists(acc => acc.accNum == accNumber))
            {
                Console.WriteLine("Error: Account number already exists. Please use a different number.");
                return;
            }


            Console.Write("Enter Account Holder Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());

            if (type == 2)
            {
                Console.Write("Enter Interest Rate (%): ");
                float interestRate = float.Parse(Console.ReadLine());
                accounts.Add(new SavingsAccount(accNumber, name, balance, interestRate));
                Console.WriteLine("Savings account created successfully.");
            }
            else
            {
                accounts.Add(new Accounts(accNumber, name, balance));
                Console.WriteLine("Regular account created successfully.");
            }
        }


        static void Deposit()
        {
            try
            {
                Console.Write("Enter Account Number: ");

                int accNumber = int.Parse(Console.ReadLine());
                Accounts account = FindAccount(accNumber);

                if (account != null)
                {
                    Console.Write("Enter Deposit Amount: ");
                    double dpAmount = double.Parse(Console.ReadLine());
                    if (dpAmount <= 0)
                        throw new Exception("Deposit amount must be positive.");

                    account.Deposit(dpAmount);

                }
                else
                {
                    Console.WriteLine("AccountNumber is not valid.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
      
        static Accounts FindAccount(int accNumber)
        {
            return accounts.Find(acc => acc.accNum == accNumber);
        }
        static void Withdraw()
        {

            try
            {
                Console.WriteLine("Enter a account number : ");
                int accNumber = int.Parse(Console.ReadLine());

                Accounts account = FindAccount(accNumber);

                if (account != null)
                {
                    Console.WriteLine("Enter a withdraw amount : ");
                    int wdAmount = int.Parse(Console.ReadLine());
                    if (wdAmount <= 0)
                        throw new Exception("Withdrawal amount must be positive.");

                    if (wdAmount > account.Balance)
                        throw new Exception("Insufficient funds.");
                    account.Withdraw(wdAmount);

                }
                else
                {
                    Console.WriteLine("AccountNumber is not valid ");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter numbers only.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }     

            
        }

        static void CheckBalance()
        {
            Console.WriteLine("Enter a account number : ");
            int accNumber = int.Parse(Console.ReadLine());

            Accounts account = FindAccount(accNumber);

            if (account != null)
            {
                Console.WriteLine("The balance is : " + account.Balance);
            }
            else
            {
                Console.WriteLine("AccountNumber is not valid ");
            }
         
            
        }

        static void ApplyInterest()
        {
            Console.Write("Enter Account Number: ");
            int accNumber = int.Parse(Console.ReadLine());
            Accounts account = FindAccount(accNumber);

            if (account is SavingsAccount savingsAccount)
            {
                savingsAccount.ApplyInterest();
            }
            else
            {
                Console.WriteLine("Interest can only be applied to Savings Accounts.");
            }
        }

    }
}