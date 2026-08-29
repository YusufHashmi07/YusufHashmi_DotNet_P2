using System;

namespace EmployeePayrollSystem
{
    class Employee
    {
        public string Name { get; set; }
        public int EmployeeId { get; set; }

        public Employee(string name, int id)
        {
            Name = name;
            EmployeeId = id;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Employee ID: " + EmployeeId);
            Console.WriteLine("Employee Name: " + Name);
        }
    }
}