using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Independent_Study
{
    class Game_Choices
    {
        private static string name;
        private static int skillLevel;
        private static string response;


        public static void FourSkills()
        {
            UserLib.WriteTitle("Game Choices");

            name = UserLib.GetString("Enter your name > ");

            Instructions();

            DoSwitch();
        }

        private static void DoSwitch()
        {
            do
            {
                switch (skillLevel)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("Thank you " + name + ", you have chosen level " + skillLevel);
                        response = UserLib.GetString("Is that what you want (y/n)? ");
                        Console.WriteLine("");
                        do
                        {
                            if (response == "y")
                            {
                                Console.WriteLine("Good: " + name + ", you have chosen level " + skillLevel + " and you can now start the game!");
                            }
                            else if (response == "n")
                            {
                                Instructions();
                                do
                                {
                                    switch (skillLevel)
                                    {
                                        case 1:
                                        case 2:
                                        case 3:
                                        case 4:
                                            Console.WriteLine("Thank you " + name + ", you have chosen level " + skillLevel);
                                            response = UserLib.GetString("Is that what you want (y/n)? ");
                                            Console.WriteLine("");
                                            do
                                            {
                                                if (response == "y")
                                                {
                                                    Console.WriteLine("Good: " + name + ", you have chosen level " + skillLevel + " and you can now start the game!");
                                                }
                                                else if (response == "n")
                                                {
                                                    Instructions();
                                                }
                                            }
                                            while (response != "y"); break;

                                        default:
                                            Console.WriteLine("Sorry, " + name + ", you should choose 1-4: ");
                                            skillLevel = UserLib.GetInt("What skill level do you chose? "); break;

                                    }
                                }
                                while (response != "y");
                            }
                        }
                        while (response != "y"); break;

                    default:
                        Console.WriteLine("Sorry, " + name + ", you should choose 1-4: ");
                        skillLevel = UserLib.GetInt("What skill level do you chose? "); break;

                }
            }
            while (response != "y");
        }

        public static void Instructions()
        {
            Console.WriteLine(name + ", there are 4 skill levels in this game: ");
            Console.WriteLine("\t1. Advanced");
            Console.WriteLine("\t2. Experienced");
            Console.WriteLine("\t3. Average");
            Console.WriteLine("\t4. Novice");

            skillLevel = UserLib.GetInt("What skill level do you chose? ");
        }
    }
}

