using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeCheck

    {
        public static void CheckAttendence()
        {
            int IS_Full_Time = 1;

            Random random = new Random();
            int empcheck = random.Next(2);

            if(empcheck == IS_Full_Time)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }

        }
       
    }
}
