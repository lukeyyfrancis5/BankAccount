using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount
    {
        public string Name;
        public int ID;
        public int Age;
        public decimal Balance;
        private decimal balance;
        private double InterestRate;

        public BankAccount()
        {

        }

        public BankAccount(string name, int id, decimal balance)
        {
            this.Name = name;
            this.ID = id;
            this.Balance = balance;
        }

        public decimal Balances
        {
            get { return balance; }
        }

        public void AddInterests()
        {
            balance += balance * (Decimal)InterestRate;
        }

        public void Deposit(decimal amount)
        {
            balance -= amount;

        }

        public void Withdraw(decimal amount)
        {
            balance += amount;
        }
    }
}
