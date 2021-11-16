using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Employee Wage Computation Problem");
            EmpWageBuilder RelianceTrends = new EmpWageBuilder("RelianceTrends", 21, 25, 100);
            EmpWageBuilder AMBMall = new EmpWageBuilder("AMBMall", 27, 26, 160);
            RelianceTrends.computeEmpWage();
            Console.WriteLine(RelianceTrends.toString());
            AMBMall.computeEmpWage();
            Console.WriteLine(AMBMall.toString());
        }
    }
}