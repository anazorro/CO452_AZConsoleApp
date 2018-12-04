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
    /// CO452 Unit 1: Task 1.2
    /// 02/12/2018 by Derek Peacock
    /// </summary>
    class T13_Course
    {
        private static int classMark, isMark, total;
        private static double average;

        public static void CalulateMarks()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(" Derek's Marks Calculator ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            classMark = GetInt("Enter the class mark > ");
            isMark = GetInt("Enter the IS Mark > ");

            total = classMark + isMark;
            average = total / 2;

            Console.WriteLine("\nThe total of " + classMark + " and " + isMark + " is " + total);
            Console.WriteLine("\nThe average mark is {0:##.00}", average);
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter a integer value which is
        /// input as a string and converted to an int
        /// </summary>
        private static int GetInt(string prompt)
        {
            int mark;
            string input;

            Console.Write(prompt);
            input = Console.ReadLine();
            mark = Convert.ToInt32(input);

            return mark;
        }
    }
}
