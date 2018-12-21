using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Unit3
{
    class Game
    {
        //Attributes
        private int noOfAliensDestroyed;
        private int valueOfTreasure;
        private int noOfHours;
        private int noDays;
        private decimal score;
        private decimal rawScore;

        private string name;

        //Methods
        public void InputData()
        {
            name = UserLib.GetString("Enter your name > ");
            noOfAliensDestroyed = UserLib.GetInt("Enter number of Aliens Destroyed > ");
            valueOfTreasure = UserLib.GetInt("Enter value of treasure > ");
        }

        public void CalculateScore()
        {
            rawScore = (noOfAliensDestroyed * 20) + (valueOfTreasure * 50);

            if(noOfHours > 10)
            {
                score = rawScore / 2;
            }
            else if(noOfHours > 7)
            {
                score = rawScore * 70 / 100;
            }
            else if(noOfHours > 5)
            {
                score = rawScore * 80 / 100;
            }
            else if (noOfHours < 3)
            {
                score = rawScore / 2;
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("name = " + name);
            Console.WriteLine("score = " + score);
            Console.WriteLine("raw score = " + rawScore);
        }

        public void DisplayMessage()
        {
            Console.WriteLine("Well done");
        }
    }
}
