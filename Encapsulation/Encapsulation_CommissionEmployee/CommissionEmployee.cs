using System;

namespace _201_Assignment
{
    public class CommissionEmployee
    {
        private string FirstName{get;set;}
        private string LastName{get;set;}
        private string SocialSecurityNumber{get;set;}
        private double CommissionRate{get;set;}
        private double GrossSales{get;set;}

        public CommissionEmployee(
            string FirstName,
            string LastName,
            string SocialSecurityNumber,
            double CommissionRate,
            double GrossSales
            )
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.SocialSecurityNumber = SocialSecurityNumber;

            if (CommissionRate >= 0 && CommissionRate <= 1)
            {
                this.CommissionRate = CommissionRate;
            }
            else
            {
                throw new Exception("Commission rate must be between 0 and 1.");
            }

            if (GrossSales >= 0.0)
            {
                this.GrossSales = GrossSales;
            }
            else
            {
                throw new Exception("Gross sales must be greater than 0.");
            }
        }

        public double Earnings()
        {
            return GrossSales * CommissionRate;
        }

        public override string ToString()
        {
            return "FirstName: " + FirstName +
                   "\nLastName: " + LastName +
                   "\nSocial Security Number: " + SocialSecurityNumber +
                   "\nCommission rate: " + CommissionRate +
                   "\nGross Sales: " + GrossSales;


        }

        public void setFirstName(string FirstName)
        {
            this.FirstName = FirstName;
        }

        public void setLastName(string LastName)
        {
            this.LastName = LastName;
        }

        public void setSocialSecurityNumber(string SocialSecurityNumber)
        {
            this.SocialSecurityNumber = SocialSecurityNumber;
        }

        public void setCommissionRate(double CommissionRate)
        {
            this.CommissionRate = CommissionRate;
        }

        public void setGrossSales(double GrossSales)
        {
            this.GrossSales = GrossSales;
        }
        
    }
}