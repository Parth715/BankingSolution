using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var acct1 = new Account
            {
                Id = 1, Description = "Test account"
            };
            acct1.Print();
            acct1.Deposit(9500);
            acct1.Print();
            acct1.Withdraw(6000);
            acct1.Print();
            acct1.Withdraw(4000);
            acct1.Print();
            var acct2 = new Account
            {
                Id = 2, Description = "New account"
            };
            acct1.Transfer(1500,acct2);
            acct1.Print();
            acct2.Print();

            acct1.Withdraw(-1000);
            acct1.Print();
            //if amount to deposit or withdraw is negative it will be wrong fix that so you cant withdraw or deposit
        }
    }
}
