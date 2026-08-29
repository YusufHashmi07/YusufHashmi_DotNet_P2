using System;

namespace EmployeePayrollSystem
{
    class FullTimeEmployee : Employee, IPayable
    {
        public double MonthlySalary { get; set; }

        public FullTimeEmployee(string name, int id, double salary)
            : base(name, id)
        {
            MonthlySalary = salary;
        }

        public double CalculateSalary()
        {
            return MonthlySalary;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Employee Type: Full-Time");
            Console.WriteLine("Salary: $" + CalculateSalary());
        }
    }
}