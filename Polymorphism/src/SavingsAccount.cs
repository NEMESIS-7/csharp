using System;

namespace Polymorphism
{
    public class SavingsAccount : BankAccount
    {
        private float InterestRate;

        public SavingsAccount(string AccountHolderName,
            string AccountNumber,
            float Balance,
            float InterestRate) : base(AccountHolderName,
            AccountNumber,
            Balance)
        {
            this.InterestRate = InterestRate;
        }

        public override void Withdraw(float amount)
        {
            if (Balance - amount < 100)
            {
                double possible = Balance - 100;
                Console.WriteLine("Insufficient balance. Minimum balance of $100 required. \nYou can withdraw $" + possible);
                return;
            }
            Balance -= amount;
            Console.WriteLine("Withdrawal Successful.\nNew balance: $" + Balance);
        }

        public string CalculateInterest()
        {
            double rate = (InterestRate * Balance * 12) / 100;
            return "Annual interest is: " + rate;
        }

        public override string DisplayAccountDetails()
        {
            return base.DisplayAccountDetails() + "\nInterest rate: " + InterestRate;
        }
    }
}