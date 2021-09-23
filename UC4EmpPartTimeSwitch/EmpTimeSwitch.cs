﻿using System;

namespace UC4EmpPartTimeSwitch
{
    class EmpTimeSwitch
    {
        static void Main(string[] args)
        {
            const int fullTime = 2;
            const int partTime = 1;
            const int empRate = 20;

            int empWage = 0;
            int hours = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case fullTime:
                    hours = 12;
                    break;
                case partTime:
                    hours = 8;
                    break;
                default:
                    hours = 0;
                    break;


            }

            empWage = empRate * hours;
            Console.WriteLine("Employee Wage new:" + empWage);

        }
    }
 }
