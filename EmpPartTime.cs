using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpPartTime
    {
       public static void CheckPartTime()
       {
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
            int Emp_Rate_Per_Hour = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            if (empCheck == Is_Full_Time)
            {
                empHrs = 8;
            }else if(empCheck == Is_Part_Time)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage:"+empWage);
       }

        
    }
}
