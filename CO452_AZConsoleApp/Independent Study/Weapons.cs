using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Independent_Study
{
    class Weapons
    {
        private static int redTokens;
        private static int greenTokens;
        private static int blueTokens;
        private static string name;
        private static int totalCredit;
        private static int arrow = 50;
        private static int howManyArrows;
        private static int creditsLeft;
                      
        public static void Store()
        {
            UserLib.WriteTitle("Weapons");

            name = UserLib.GetString("Enter your name > ");

            redTokens = UserLib.GetInt("How many red tokens do you have? ");
            greenTokens = UserLib.GetInt("How many green tokens do you have? ");
            blueTokens = UserLib.GetInt("How many blue tokens do you have? ");
            Console.WriteLine("");

            totalCredit = (redTokens * 5) + (greenTokens * 10) + (blueTokens * 20);
            Console.WriteLine("The total credit available is " + totalCredit);
            Console.WriteLine("");

            howManyArrows = totalCredit / arrow;
            Console.WriteLine("In total, you can buy " + howManyArrows + " arrows. ");
            Console.WriteLine("");

            creditsLeft = totalCredit % arrow;
            Console.WriteLine(name + ", you have purchased " + howManyArrows + " and have " + creditsLeft + " credits left. ");
        }
    }
}
