using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Unit1
{
    /// <summary>
    /// This class calculates the average and final
    /// mark for the course
    /// 
    /// CO452 Unit 1: Task 1.4
    /// 04/12/2018 by Derek Peacock
    /// </summary>
    public class T14_Salary
    {
        private static decimal weeklySalary;
        private static decimal monthlySalary;
        private static decimal annualSalary;

        public static void Calculate()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            UserLib.WriteTitle("Salary Calculator");

            weeklySalary = UserLib.GetDecimal("Enter your weekly Salary (£) > ");

            monthlySalary = weeklySalary * 4;
            annualSalary = monthlySalary * 12;

            Console.WriteLine();
            Console.WriteLine("Weekly  Salary = " + weeklySalary.ToString("£###.00"));
            Console.WriteLine("Monthly Salary = " + monthlySalary.ToString("£###.00"));
            Console.WriteLine("Annual  Salary = " + annualSalary.ToString("c"));
        }
    }
}
