using System;

namespace Refactor_Emp_Wage
{
    class Calculate
    {
        public void check()
        {
            Random emp_random = new Random();
            int empcheck = emp_random.Next(0, 2);
            if (empcheck == 1)
            {
                Console.WriteLine("Employee is Present ");
            }
            else
            {
                Console.WriteLine("Employee is Absent ");
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
