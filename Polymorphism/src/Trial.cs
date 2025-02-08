using System;

namespace Polymorphism
{
    public class Trial
    {
        public static void Main(string[] args)
        {
            SavingsAccount account = new SavingsAccount(
                "Alice",
                "SA123456",
                500,
                0.03f
                );
            //Depositing without a note
            Console.WriteLine(account.Deposit(500));
            //Account details after first deposit(without note)
            Console.WriteLine(account.DisplayAccountDetails());
            //Depositing with a note
            Console.WriteLine("\n" + account.Deposit(500, "Surprise Motherfucker"));
            //Account details after depositing with note
            Console.WriteLine("\n" + account.DisplayAccountDetails());
            //Trying to withdraw past the limit which will throw an exception
            try
            {
                account.Withdraw(1550);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
    }
}