using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Independent_Study.Nuclear_Control
{
    class Test
    {
        private string choice;
        private NuclearStation myStation;

        public static void Main()
        {
            Test myTest = new Test();
            myTest.testStation();
        }

        public Test()
        {
            myStation = new NuclearStation();
        }

        public void testStation()
        {
            myStation.display();
            choice = myStation.getChoice();
            if (choice == "1")
            {
                myStation.lowerRods();
            }
        }
        
    }
}
