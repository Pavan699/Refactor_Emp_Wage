﻿using System;

namespace Refactor_Emp_Wage
{
    class Calculate
    {
        public void check()
        {
            Random emp_random = new Random();
            int empcheck = emp_random.Next(0, 3);
            int oneDay_Sal = 0, full_Time = 8, perHour_Pay = 20, part_Time = 4;
            switch (empcheck)
            {
                case 1:
                    Console.WriteLine("It's Work-Type is : Full-Time");
                    oneDay_Sal = full_Time * perHour_Pay;
                    Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
                    break;
                case 2:
                    Console.WriteLine("It's Work-Type is : Part-Time");
                    oneDay_Sal = part_Time * perHour_Pay;
                    Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
                    break;
                default:
                    Console.WriteLine(" Wrong Input :)");
                    break;
            }

        }
    }
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages");
            Calculate cal = new Calculate();
            cal.check();

        }
    }
}
