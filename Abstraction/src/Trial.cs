using System;

namespace Abstraction
{
    public class Trial
    {
        public static void Main(string[] args)
        {
            FullTimeEmployee employee = new FullTimeEmployee(
                "Future",
                "Hendrix",
                50000
            );
            Console.WriteLine("Employee name: " + employee.GetName() + 
                              "\nEmployee ID: " + employee.GetEmployeeId() + 
                              "\nEmployee Salary: " + employee.GetSalary());
            
        }
    }
}