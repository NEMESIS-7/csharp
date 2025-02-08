namespace Abstraction
{
    public class FullTimeEmployee : Employee
    {
        private float Salary;

        public FullTimeEmployee(string Name, string EmployeeId, float Salary) : base(Name, EmployeeId)
        {
            this.Salary = Salary;
        }

        public float GetSalary()
        {
            return Salary;
        }

        public override string CalculatePay()
        {
            return "Full time employee pay: " + Salary;
        }
    }
}