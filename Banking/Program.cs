using System;

namespace Banking
{
    class Program
    {
        //static void Method1()
        //{
        //    try 
        //    { 

        //    Method2();
        //    }catch(Exception ex)
        //    {
        //        Console.WriteLine($"Exception occured: {ex.Message}");
        //    }
        //}
        //static void Method2()
        //{
        //    Method3();
        //}
        //static void Method3()
        //{
        //    var throwException = true;
        //    if(throwException)
        //    {
        //        throw new Exception("My ficticous exception");
        //    }
        //}
        static void Main(string[] args)
        {

            try
            {
                var sav2 = new Savings2(1098675740);
                sav2.Description = "Parth's savings";
                sav2.IntrestRate = 0.12m;
                sav2.Print();
                sav2.Deposit(5000);
                sav2.Withdraw(2000);
                sav2.CalculateAndPayIntrest(1);
                sav2.Print();
                sav2.Withdraw(10000);
                sav2.Print();
                sav2.Deposit(10);
            } catch (InsufficientFundsException ex)
            {
                Console.WriteLine("You do no thave enough money to withdraw this much money");
                Console.WriteLine($"Current balance is {ex.CurrentBalance}");
                Console.WriteLine($"Amount to withdraw is {ex.AmountToWithdraw}");
            }catch (AmountGreaterThanZeroException)
            {
                Console.WriteLine("You need to deposit something");
            }

            //var sav1 = new Savings()
            //{


            //    Id = 10,
            //    Description = "My first savings"
            //};
            //sav1.IntrestRate = 0.12m;
            //sav1.Print();
            //sav1.Deposit(5000);
            //sav1.Withdraw(2000);
            //sav1.CalculateAndPayIntrest(1);
            //sav1.Print();

            //var acct1 = new Account
            //{
            //    Id = 1, Description = "Test account"
            //};
            //acct1.Print();
            //acct1.Deposit(9500);
            //acct1.Print();
            //acct1.Withdraw(6000);
            //acct1.Print();
            //acct1.Withdraw(4000);
            //acct1.Print();
            //var acct2 = new Account
            //{
            //    Id = 2, Description = "New account"
            //};
            //acct1.Transfer(1500,acct2);
            //acct1.Print();
            //acct2.Print();

            //acct1.Withdraw(-1000);
            //acct1.Print();
            //acct1.Deposit(-500);
            
        }
    }
}
