using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Independent_Study
{
    class Tournament
    {
        private static int totalOfPlayers;
        private static int sizeOfATeam;
        private static int numberOfTeams;
        private static int leftoverPlayers;

        public static void Teams()
        {
            numberOfTeams = totalOfPlayers / sizeOfATeam;
            
        }
    }
}
