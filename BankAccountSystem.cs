using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class BankAccount
    {
        private string accountHolder;
        private int accountNumber;
        private double balance;

        public BankAccount(string name, int accNo, double initialBalance)
        {
            accountHolder = name;
            accountNumber = accNo;
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"{amount} deposited successfully.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"{amount} withdrawn successfully.");
            }
        }

        public void DisplayAccount()
        {
            Console.WriteLine("\n----- Account Details -----");
            Console.WriteLine("Account Holder : " + accountHolder);
            Console.WriteLine("Account Number : " + accountNumber);
            Console.WriteLine("Current Balance: " + balance);
        }
    }
    internal class BankAccountSystem
    {
        public static void Main(string[] args) {

            BankAccount account = new BankAccount("Sumit", 1001, 5000);

            account.DisplayAccount();

            account.Deposit(2000);
            account.Withdraw(1500);

            account.DisplayAccount();
        }
}}
