using System;

namespace UC2EmployeeWage
{
    class EmpWage
    {
        static void Main(string[] args)
        {
            int fullTime = 1;
            int empRate = 20;
            int empWage = 0;
            int hours = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == fullTime)
                hours = 8;
            else
                hours = 0;

            empWage = empRate * hours;
            Console.WriteLine("Employee Wage :" + empWage);

        }
    }

}
