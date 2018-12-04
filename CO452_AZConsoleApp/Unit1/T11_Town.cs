using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Unit1
{
    /// <summary>
    /// This class prompts the user to enter their
    /// name and town, and then comments on their entries
    /// 
    /// CO452 Unit 1: Task 1.1
    /// 04/12/2018 by Ana Zorro
    /// </summary>
    class T11_Town
    {
        private static string town;
        private static string name;

        public static void Check()
        {
            Console.Clear();

            Console.WriteLine("--------------------------");
            Console.WriteLine(" Ana's Town Checker     ");
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("What is your name >");
            name = Console.ReadLine();

            Console.WriteLine("Task 1: Hello There " + name + " !");
            Console.Write("Enter the town you live in >");

            town = Console.ReadLine();
            Console.WriteLine(town + " is a nice town!");
        }
    }
}
