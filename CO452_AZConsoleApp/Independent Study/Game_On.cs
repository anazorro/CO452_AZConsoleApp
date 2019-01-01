using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Independent_Study
{
    class Game_On
    {
        private static string name;
        private static string response;
        private static int input;
        private static int number;
        private static int count = 0;
        
        public static void Guess()
        {
            UserLib.WriteTitle("Guessing Game");

            name = UserLib.GetString("Enter your name: ");

            Console.WriteLine(name + ", I am going to pick a number between 1 and 100.");
            Console.WriteLine("You must try to guess the number");

            Random rand = new Random();
            number = rand.Next(100) + 1;

            Console.WriteLine("OK .. I have picked a number.");

            ToGuess();

            Console.WriteLine("Total of guesses = " + count);

            if(count >= 10)
            {
                Console.WriteLine("Terrible!");
            }
            else if (count < 10 && count > 5)
            {
                Console.WriteLine("Good!");
            }
            else if (count < 5)
            {
                Console.WriteLine("Very good!");
            }

            response = UserLib.GetString("Does anyone else want to play (y/n) ? ");

            do
            {
                if (response == "y")
                {
                    name = UserLib.GetString("Enter your name: ");

                    number = rand.Next(100) + 1;

                    ToGuess();

                    Console.WriteLine("Total of guesses = " + count);

                    if (count >= 10)
                    {
                        Console.WriteLine("Terrible!");
                    }
                    else if (count < 10 && count > 5)
                    {
                        Console.WriteLine("Good!");
                    }
                    else if (count < 5)
                    {
                        Console.WriteLine("Very good!");
                    }

                    response = UserLib.GetString("Does anyone else want to play (y/n) ? ");
                }
                else if (response == "n")
                {
                    Console.WriteLine("Thanks for playing!");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Total players = ");
                }
            }
            while (response != "n");


        }

        public static void ToGuess()
        {
            do
            {
                input = UserLib.GetInt("What is your guess, " + name + ": ");

                if (input == number)
                {
                    Console.WriteLine(name + ", you got it: SPOT ON. My number was " + number);
                }
                else if (input > number)
                {
                    Console.WriteLine("That is TOO HIGH, " + name);
                }
                else if (input < number)
                {
                    Console.WriteLine("That is TOO LOW, " + name);
                }
                count++;
            }
            while (input > number || input < number);

        }
    }
}