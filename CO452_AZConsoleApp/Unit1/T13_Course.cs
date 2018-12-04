using System;

namespace CO452_AZConsoleApp.Unit1
{
    /// <summary>
    /// This class calculates the average and final
    /// mark for the course
    /// 
    /// CO452 Unit 1: Task 1.3
    /// 04/12/2018 by Ana Zorro
    /// </summary>
    class T13_Course
    {
        private static double classMark, isMark, projectMark, totalMark;
        private static double averageMark;

        public const int CLASS_PERCENTAGE = 65;
        public const int IS_PERCENTAGE = 25;
        public const int PROJECT_PERCENTAGE = 15;
        
        public static void CalulateMarks()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(" Ana's Marks Calculator ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            classMark = GetInt("Enter the class mark > ");
            isMark = GetInt("Enter the IS Mark > ");
            projectMark = GetInt("Enter the Project Mark > ");


            totalMark = (classMark * CLASS_PERCENTAGE / 100) + 
                        (isMark * IS_PERCENTAGE / 100) + 
                        (projectMark * PROJECT_PERCENTAGE / 100);

            averageMark = (classMark + isMark + projectMark) / 3;

            Console.WriteLine("\nThe total of " + classMark + " and " + isMark + " is " + totalMark);
            Console.WriteLine("\nThe average mark is {0:##.00}", averageMark);
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
