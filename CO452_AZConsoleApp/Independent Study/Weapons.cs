using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Independent_Study
{
    class Weapons
    {
        private const int redTokens = 5;
        private const int greenTokens = 10;
        private const int blueTokens = 20;
        private string name;

        public static void Store()
        {
            name = UserLib.GetString("Enter your name > ");


        }
    }
}
