using System;

namespace Refactor_Emp_Wage
{
    //Creating Calculate class to calculate Employee Wages
    class Calculate
    {
        //declare method for calculate monthly wage
        public void monthlyPay(int oneDay_Sal,int days)
        {
            int total_Sal = 0;
            total_Sal = oneDay_Sal * days;
            Console.WriteLine("Total Work-Days Salary is : {0}", total_Sal);         
        }
        //method to check hours and days condition i.e.(100 hours and 20 days)
        public void hours(int work_Hours, int days)
        {
            if (work_Hours > 100 || days >= 20)
            {
                Console.WriteLine("Working hours are {0} And Work Days are {1}", work_Hours, days);
            }
            else
            {
                Console.WriteLine("Working Hours Are less than 100 ");
            }
        }
        //declare this method for use of Random function and Switch-case
        public void check()
        {
            //Random Function
            Random emp_random = new Random();
            int check = emp_random.Next(0, 3);
            //variables declaration
            int oneDay_Sal = 0, full_Time = 8, perHour_Pay = 20, part_Time = 4, Work_days = 20, total_WorkHour = 0;
            //Switch Case Logic
            switch (check)
            {
                case 1:
                    Console.WriteLine("It's Work-Type is : Full-Time");
                    oneDay_Sal = full_Time * perHour_Pay;
                    Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
                    total_WorkHour = full_Time * Work_days;
                    //Calling methods for MonthlyPay and Day-Hours Condition(Use-Case)
                    //No need to create class object BCoz, methods are in same class itself
                    monthlyPay(oneDay_Sal, Work_days);
                    hours(total_WorkHour, Work_days);
                    break;
                case 2:
                    Console.WriteLine("It's Work-Type is : Part-Time");
                    oneDay_Sal = part_Time * perHour_Pay;                   
                    Console.WriteLine("One Day Salary is : {0}", oneDay_Sal);
                    total_WorkHour = part_Time * Work_days;
                    //It aslo follow the Dry Principle
                    monthlyPay(oneDay_Sal, Work_days);
                    hours(total_WorkHour, Work_days);
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
            //Creating Object for the Calculate Class 
            Calculate cal = new Calculate();
            cal.check();//Calling check method...

        }
    }
}
