using System;

namespace EmployeePayrollSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== EMPLOYEE PAYROLL SYSTEM =====\n");

            // Creating Full-Time Employee Object
            Employee employee1 = new FullTimeEmployee(
                "Yusuf",
                101,
                50000
            );

            // Creating Part-Time Employee Object
            Employee employee2 = new PartTimeEmployee(
                "Rahul",
                102,
                500,
                80
            );

            // Polymorphism
            employee1.DisplayDetails();

            Console.WriteLine("------------------------");

            employee2.DisplayDetails();

            Console.WriteLine("\n===== Payroll Generated Successfully =====");

            Console.ReadKey();
        }
    }
}