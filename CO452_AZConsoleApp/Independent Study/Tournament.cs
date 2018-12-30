using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Independent_Study
{
    class Tournament
    {
        private static int players;
        private static int team;
        private static int numberOfTeams;
        private static int leftover;

        public static void Teams()
        {
            UserLib.WriteTitle("Game Tournament");

            players = UserLib.GetInt("Enter the total number of players > ");

            team = UserLib.GetInt("Enter the size of a team > ");
            
            numberOfTeams = players / team;

            Console.WriteLine("Number of teams = " + numberOfTeams);

            leftover = players % team;

            Console.WriteLine("Number of players that are leftover without a team = " + leftover);
            
        }
    }
}
