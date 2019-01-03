using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Independent_Study.Nuclear_Control
{
    class NuclearStation
    {
        private const string SYSTEMCODE = "NUKEME";

        public void display()
        {
                Console.WriteLine("Nuclear WinterLand Station");
                Console.WriteLine("=======================================");
            Console.WriteLine("      Main menu");
            Console.WriteLine("      ==============");
            Console.WriteLine("      1: Lower Fuel Rods");
            Console.WriteLine("      2: Raise Fuel Rods");
            Console.WriteLine("      3: Activate Shields");
            Console.WriteLine("      4: Deactivate Shields");
            Console.WriteLine("      5: Quit\n");
        }

        public string getChoice()
        {
            string choice;
            Console.WriteLine("\nWhat do you want to do? ");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();
            return choice;
        }

        public void lowerRods()
        {
            string code;
            Console.WriteLine("\nWARNING:DANGER: Lowering Fuel Rods!");
            Console.WriteLine("You require an authorisation code to do this");
            Console.Write("Enter your code now:");
            code = Console.ReadLine();
            if(code == SYSTEMCODE)
            {
                Console.WriteLine("\n** CODE CORRECT : Fuel rods being lowered");
            }
            else
            {
                Console.WriteLine("\n** INCORRECT : please stay where you are!");
                Console.WriteLine("You will now be escorted from the building!");
            }
        }
    }
}
