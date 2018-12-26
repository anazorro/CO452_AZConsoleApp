using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Unit1
{
    class T15_Concert
    {
        private static string group;
        private static string date;
        private static int numberofTickets;
        private static decimal ticketCost;
        private static decimal totalCost;

        public static void BuyTickets()
        {
            UserLib.WriteTitle("Buy Tickets");

            group = UserLib.GetString("Enter the name of the group > ");
            date = UserLib.GetString("Enter the Date > ");

            numberofTickets = UserLib.GetInt("Enter Number of tickets > ");
            ticketCost = UserLib.GetDecimal("Enter price of ticket > ");

            Console.Clear();
            Console.Write("Bucks New University");
            Console.SetCursorPosition(40, 0);
            Console.Write(date);

            Console.SetCursorPosition(20, 4);
            Console.Write(group);

            Console.SetCursorPosition(0, 8);
            Console.Write("No of Tickets:" + numberofTickets);

            Console.SetCursorPosition(30, 8);
            Console.Write("Cost Per Ticket:" + ticketCost);

            totalCost = totalCost * numberofTickets;

            Console.SetCursorPosition(20, 12);
            Console.Write("Total Cost:" + totalCost.ToString("c"));
        }
    }
}
