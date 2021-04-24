using System;
using System.Collections.Generic;
using System.Text;








namespace MySuperBank
{
    class Transaction
    {
        private List<Transaction> allTransactions = new List<Transaction>();
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

    }
}
