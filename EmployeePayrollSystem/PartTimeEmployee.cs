using System;

namespace EmployeePayrollSystem
{
    class PartTimeEmployee : Employee, IPayable
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public PartTimeEmployee(string name, int id,
            double hourlyRate, int hoursWorked)
            : base(name, id)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public double CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Employee Type: Part-Time");
            Console.WriteLine("Salary: $" + CalculateSalary());
        }
    }
}