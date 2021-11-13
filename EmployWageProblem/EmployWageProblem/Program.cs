using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Problem");
            EmployeeWageProblem.MonthlyEmployeeWage("Reliance Trends", 22, 25, 126);
            EmployeeWageProblem.MonthlyEmployeeWage("AMB Mall", 29, 27, 153);
        }
    }
}