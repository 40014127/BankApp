using System;





namespace MySuperBank
{
    class Program
    {
      //  BankAccount bankaccounts = new BankAccount();
        static void Main(string[] args)
        {
            var account = new BankAccount("SBI", 100000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeDeposit(10000, DateTime.Now, "Friend paid me back");
            Console.WriteLine(account.Balance);
            account.MakeWithdrawal(100, DateTime.Now, "AAAA");
            account.MakeWithdrawal(100, DateTime.Now, "BBB");
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);
           
            Console.WriteLine(account.GetaccountHistory());
            try
            {
                account.MakeWithdrawal(50, DateTime.Now, "Attempt to overdraw");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }
           
        }

       
    }
}
