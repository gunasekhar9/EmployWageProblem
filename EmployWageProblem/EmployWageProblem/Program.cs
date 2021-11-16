using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Problem");
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("RelianceTrends", 21, 25, 123);
            empWageBuilder.addCompanyEmpWage("AMBMall", 28, 26, 160);
            empWageBuilder.computeEmpWage();
        }
    }
}

