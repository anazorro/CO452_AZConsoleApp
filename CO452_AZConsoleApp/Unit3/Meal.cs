using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Unit3
{
    public class Meal
    {
        //Attributes
        private decimal foodCost;
        private decimal drinkCost;
        private decimal weekCost;
        private decimal dayCost;
        private int noDays;

        private string name;

        //Methods
        public void InputData()
        {
            name = UserLib.GetString("Enter your name > ");

            //this 4 lines of code could be replaced with
            string input; // local input variable
            Console.Write("Enter the price of a meal: £");
            input = Console.ReadLine();
            foodCost = Convert.ToDecimal(input);

            //replaced
            //with this: foodCost = UserLib.GetDecimal("Enter the price of a meal >")

            Console.Write("Enter the price of a drink: £");
            input = Console.ReadLine();
            drinkCost = Convert.ToDecimal(input);

            Console.Write("Enter the number of days per week at college: ");
            input = Console.ReadLine();
            noDays = Convert.ToInt32(input);
        }

        public void CalculateTotalCosts()
        {
            dayCost = foodCost + (3 * drinkCost);
            weekCost = dayCost * noDays;
        }

        public void OutputCosts()
        {
            Console.WriteLine("\nYour Final Costing Results" + name);
            Console.WriteLine("==========================");
            Console.WriteLine("Total cost for one day = £" + dayCost.ToString("0.00"));
            Console.WriteLine("Total cost for one week = £" + weekCost.ToString("0.00"));
        }
    }
}
