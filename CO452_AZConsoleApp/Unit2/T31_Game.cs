using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Unit2
{
    class T31_Game
    {
        //data - define variable
        private static decimal money;

        //method - function
        public static void BuyWeapons()
        {
            //no need to say if private or public because its inside the method makes it private
            decimal price;
            decimal moneyLeft;
            decimal total = 0;

            int count;

            //in here isnt returning a value
            UserLib.WriteTitle("Buy Weapons");

            //in here is returning a value
            money = UserLib.GetDecimal("How much money do you have > ");

            for(count = 1; count <= 6; count++)
            {
                price = UserLib.GetDecimal("Enter the price of weapon " + count + " > ");
                total = total + price;
                moneyLeft = money - total;
                Console.WriteLine("Money Left " + moneyLeft.ToString("c"));
            }

            Console.WriteLine("Total = " + total.ToString("c"));
        }
    }
}
