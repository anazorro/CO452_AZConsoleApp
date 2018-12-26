using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Independent_Study
{
    class Rocket
    {
        private static decimal length;
        private static decimal width;
        private static decimal height;
        private static decimal price = 10;
        private static decimal volume;
        private static decimal totalCost;
        public const decimal second = 1;
        public static decimal totalSeconds;

        public static void Calculate()
        {
            UserLib.WriteTitle("Rocket Game Calculator");
             
            length = UserLib.GetDecimal("Enter the length of the fuel tank (metres) > ");
            width = UserLib.GetDecimal("Enter the width of the fuel tank (metres) > ");
            height = UserLib.GetDecimal("Enter the height of the fuel tank (metres) > ");

            volume = length * width * height;

            Console.WriteLine("The volume is  " + volume + "!");

            totalCost = ( volume * price );

            Console.WriteLine("The total cost to fill the tank is " + totalCost);

            totalSeconds = volume * second / 6;

            Console.WriteLine("This rocket fuel will last " + totalSeconds + " seconds");

        }
    }
}
