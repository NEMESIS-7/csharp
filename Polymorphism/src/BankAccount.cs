using System;

namespace Polymorphism
{
    public class BankAccount
    {
        public string AccountHolderName { get; set; }
        public string AccountNumber{ get; set; }
        public float Balance{ get; set; }

        public BankAccount(string accountHolderName, string accountNumber, float balance)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public string Deposit(float amount)
        {
            Balance += amount;
            return "Deposit successful. New balance is " + Balance;
        }

        public string Deposit(float amount, string note)
        {
            Balance += amount;
            return "New balance is " + Balance + "\nNote: " + note;
        }

        public virtual void Withdraw(float amount)
        {
            if (Balance - amount < 0)
            {
                throw new Exception("Insufficient balance");
            }
            Balance -= amount;
            Console.WriteLine("Withdraw successful. \nNew balance is: " + Balance);
        }

        public virtual string DisplayAccountDetails()
        {
            return "Account holder name: " + AccountHolderName +
                   "\nAccount number: " + AccountNumber + 
                   "\nBalance: " + Balance;
        }
    }
}