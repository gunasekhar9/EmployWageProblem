using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    public class EmployeeWageProblem
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2, EMP_RATE_PER_HOUR = 20;
        int empHrs = 0, empWage = 0;
        public void DailyEmployeeWage()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee Wage : " + empWage);
        }
    }
}