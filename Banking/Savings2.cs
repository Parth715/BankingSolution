using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Savings2
    {
        public Savings2(int id)
        {
            this.account = new Account();
            this.account.Id = id;
            this.account.Description = "New Savings 2";
        }
        private Account account { get; set; }//composition/Abstraction

        public int Id => account.Id;
        public decimal Balance => account.Balance = 0;
        public string Description
        {
            get { return account.Description; }
            set { account.Description = value; }
        }
        public decimal IntrestRate { get; set; } = 0.01m;

        public decimal CalculateAndPayIntrest(int months)
        {
            var intrest = this.account.Balance * (IntrestRate / 12) * months;
            this.account.Deposit(intrest);
            return intrest;
        }
        public bool Deposit(decimal amount)
        {
            return this.account.Deposit(amount);
        }
        public bool Withdraw(decimal amount)
        {
            return this.account.Withdraw(amount);
        }
        public bool Transfer(decimal amount, Account ToAccount)
        {
            return this.account.Transfer(amount, ToAccount);
        }
        public void Print()
        {
            this.account.Print();
        }
    }
}
