﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
        public abstract class AttendenceCheck
        {
            public abstract void Attendence();
        }
        class Employee : AttendenceCheck
        {
            public override void Attendence()
            {
                //random number generation
                Random rand = new Random();
                int isPresent = rand.Next(2);

                if (isPresent == 1)
                    Console.WriteLine("Employee is Present.");
                if (isPresent == 0)
                    Console.WriteLine("Employee is Absent");
            }
        }
    
}
