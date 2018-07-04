using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Transactions
    {
        public decimal Amount { get; }

        public Transactions(decimal amount)
        {
            this.Amount = amount;
        }

        public decimal Balances
        {
            get { return balance; }
        }

    }
}
