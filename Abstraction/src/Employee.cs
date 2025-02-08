using System.Runtime.InteropServices;

namespace Abstraction
{
    public abstract class Employee
    {
        private string Name;
        private string EmployeeId;

        public Employee(string name,
            string employeeId)
        {
            Name = name;
            EmployeeId = employeeId;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetEmployeeId()
        {
            return EmployeeId;
        }

        public abstract string CalculatePay();
    }
}