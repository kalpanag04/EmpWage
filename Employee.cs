using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    class Employee
    {
        public void AttendenceCheck()
        {
            //constants
            const int WAGE_PER_HR = 20;
            const int IS_FULL_TIME = 8;
            const int IS_PART_TIME = 4;

            //variables
            int dailyWage = 0;

            //random number generation
            Random rand = new Random();
            int isPresent = rand.Next(0, 3);

            if (isPresent == 1)
            {
                dailyWage = WAGE_PER_HR * IS_FULL_TIME;
                Console.WriteLine("Employee is present Fulltime");
                Console.WriteLine($"Daily wage is {dailyWage}");

            }
            else if (isPresent == 2)
            {
                dailyWage = WAGE_PER_HR * IS_PART_TIME;
                Console.WriteLine("Employee is present Parttime");
                Console.WriteLine($"Daily wage is {dailyWage}");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
                Console.WriteLine($"Daily wage is {dailyWage}");
            }

        }

    }

}
