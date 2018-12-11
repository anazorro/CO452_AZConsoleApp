using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Unit2
{
    class T33_Fairy
    {
        public static void Load()
        {
            //only use decimal for money THE REST IS DOUBLE
            
            const double MAX_WEIGHT = 2400;
            const decimal TICKET_COST = 60m;

            double weight = 0;
            double totalWeight = 0;
            int count = 0;
            decimal money = 0;
            bool isFull = false;
        

            UserLib.WriteTitle("Space Ferry");
            
            while(!isFull)
            {
                weight = UserLib.GetDouble("Enter your weight > ");

                if (totalWeight + weight > MAX_WEIGHT)
                {
                    Console.WriteLine("Not Accepted!!");
                    isFull = true;
                }
                else
                {
                    Console.WriteLine("Passenger Accepted!!");
                    //+= means money = money + 60(TICKET_COST) instead of line thirty nine.
                    totalWeight += weight;
                    money += TICKET_COST;
                    count++;
                }
            } //end of while

            Console.WriteLine("Number of Passengers = " + count);
            Console.WriteLine("Total Money = " + money.ToString("c"));
            Console.WriteLine("Total Weight = " + totalWeight.ToString());

        }//end of method
    }//end of class
}
