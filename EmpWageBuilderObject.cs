using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmpWageBuilderObject
    {
        public const int Is_Full_Time = 1;
        public const int Is_Part_Time = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalEmpWage = totalEmpWage;
        }

        public void computeEmpWage()
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;
            while (totalEmpHrs <= this. maxHoursPerMonth && totalWorkingDays <this. numOfWorkingDays)
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
                totalEmpHrs = +empHrs;
                Console.WriteLine("Day : " + totalWorkingDays + "Emp Hrs: " + empHrs);
            }
            int totalEmpWage = totalEmpHrs *this. empRatePerHour;
            Console.WriteLine("Total Emp Wage for Company:" + company + "Is:" + totalEmpWage);
            
        }
        public string toString()
        {
            return "Total Emp Wage for Company:" + this.company + "Is:" + this.totalEmpWage;
        }
    }
    
}
