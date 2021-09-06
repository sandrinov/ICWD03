using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class BankAccount
    {
        public string AccountNumber { get; }
        private double balance;
        public BankAccount(string accountNumber, double initialBalance)
        {
            AccountNumber = accountNumber;
            balance = initialBalance;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Deposit(double amount)
        {
            balance = balance + amount;
        }
        public bool Withdraw(double amount)
        {
            bool result = true;
            if(balance >= amount)
            {
                balance = balance - amount;
            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
