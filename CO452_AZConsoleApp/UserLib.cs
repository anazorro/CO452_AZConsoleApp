using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp
{
    /// <summary>
    /// This class contains useful methods that can be used 
    /// in a variety of other Console programs
    /// 
    /// Author: Derek Peacock
    /// </summary>
    class UserLib
    {
        public static void WriteTitle(string title)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(" Ana's " + title);
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter a integer value which is
        /// input as a string and converted to an int
        /// </summary>
        public static int GetInt(string prompt)
        {
            int mark;
            string input;

            Console.WriteLine();
            Console.Write(prompt);
            input = Console.ReadLine();
            mark = Convert.ToInt32(input);

            return mark;
        }

        public static int GetInt(string prompt, int min, int max1)
        {
            bool valid = false;
            int value;
            do
            {
                value = GetInt(prompt);
                if(value < min)
                {
                    Console.WriteLine("Bad value");
                }

            } while (!valid);

            return 0;
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter a integer value which is
        /// input as a string and converted to an int
        /// </summary>
        public static decimal GetDecimal(string prompt)
        {
            decimal amount;
            string input;

            Console.WriteLine();
            Console.Write(prompt);
            input = Console.ReadLine();
            amount = Convert.ToDecimal(input);

            return amount;
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter a integer value which is
        /// input as a string and converted to an int
        /// </summary>
        public static double GetDouble(string prompt)
        {
            double amount;
            string input;

            Console.WriteLine();
            Console.Write(prompt);
            input = Console.ReadLine();
            amount = Convert.ToDouble(input);

            return amount;
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter their name
        /// </summary>
        public static string GetString(string prompt)
        {
            string input;

            Console.WriteLine();
            Console.Write(prompt);

            input = Console.ReadLine();

            return input;
        }
    }
}
