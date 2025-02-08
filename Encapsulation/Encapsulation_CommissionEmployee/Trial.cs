using System;

namespace _201_Assignment.Encapsulation_CommissionEmployee
{
    public class Trial
    {
        public static void Main(String[] args)
        {
            try
            {
                var employee = new CommissionEmployee(
                    "Future",
                    "Hendrix",
                    "220333666",
                    0.55,
                    500000
                );
                Console.WriteLine(employee);
                employee.setGrossSales(600000);
                employee.setCommissionRate(0.6);
                Console.WriteLine("\nUpdated details: \n" + employee);
                Console.WriteLine("\nThis employee earns: $" + employee.Earnings());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
    }
}