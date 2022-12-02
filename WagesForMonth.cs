using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WagesForMonth
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int Num_Of_working_Days = 3;

        public static void CalculateWageForMonth()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalempWage = 0;
            for (int day = 0; day < Num_Of_working_Days; day++)
            {
               

                Random random = new Random();
                int empCheck = random.Next(3);

                switch (empCheck)
                {
                    case Is_Full_Time:
                        Console.WriteLine("Employee is full time");
                        empHrs = 8;
                        break;

                    case Is_Part_Time:
                        Console.WriteLine("Employee is part time ");
                        empHrs = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        break;


                }
                empWage = empHrs * Emp_Rate_Per_Hour;
                totalempWage += empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("Total EmpWage:" + totalempWage);
        }
        
    }
}
