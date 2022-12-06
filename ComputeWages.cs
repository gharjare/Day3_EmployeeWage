using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class ComputeWages
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_working_Days = 3;
        public const int Max_Hrs_In_Month = 100;
        public static void CheckComputeWages()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalempWage = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_working_Days)
            {
                Random random = new Random();
                int empcheck = random.Next(3);
                switch (empcheck)
                {
                    case Is_Full_Time:
                        Console.WriteLine("Employee is full time");
                        empHrs = 8;
                        break;
                    case Is_Part_Time:
                        Console.WriteLine("Employee is part time");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is absent");
                        empHrs = 0;
                        break;
                }
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + "Emp Hrs: " + empHrs);

            }
            totalempWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Total Emp Wage for a Month: " + totalempWage);
        }
    }
    
}
