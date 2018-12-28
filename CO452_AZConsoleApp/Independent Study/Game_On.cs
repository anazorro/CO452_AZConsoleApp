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
        private static string y;
        private static string n;
        private static int input;
        private static int number;
       

        public static void Guess()
        {
            UserLib.WriteTitle("Guessing Game");

            name = UserLib.GetString("Enter your name: ");

            Console.WriteLine(name + ", I am going to pick a number between 1 and 100.");
            Console.ReadKey();

            Console.WriteLine("You must try to guess the number");
            Console.ReadKey();

            Random rand = new Random();

            number = rand.Next(100) + 1;

            Console.WriteLine("OK .. I have picked a number.");
            Console.ReadKey();

            YourGuess();

            response = UserLib.GetString("Does anyone else want to play (y/n) ? ");

            do
            {
                if(response == y)
                {
                    YourGuess();
                }
                else if(response == n)
                {
                    Console.WriteLine("Thanks for playing!");
                }
            }
            while (response != n);
        }

        public static void YourGuess()
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
            }
            while (input > number || input < number);
        }
    }
}

