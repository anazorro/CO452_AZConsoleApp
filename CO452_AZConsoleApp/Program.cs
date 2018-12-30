using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CO452_AZConsoleApp.Independent_Study;
using CO452_AZConsoleApp.Unit1;
using CO452_AZConsoleApp.Unit2;
using CO452_AZConsoleApp.Unit3;

namespace CO452_AZConsoleApp
{
    class Program
    {
        private static void Main(string[] args)
        {
            //RunWeek1();

            //RunWeek2();

            //CalcutateMeal();

            //CalcutateGameScore();

            //PlayCraps();

            //Rocket.Calculate();

            //Planetary.Sums();

            //T15_Concert.BuyTickets();

            //Tournament.Teams();

            //Game_On.Guess();

            Weapons.Store();

            Console.ReadKey();
        }


        private static void PlayCraps()
        {
            //because its dinamic:
            Craps craps = new Craps();

            craps.Play();
        }

        private static void CalcutateGameScore()
        {
            Game game = new Game();

            UserLib.WriteTitle("Game Calculator");

            game.InputData();
            game.CalculateScore();
            game.DisplayDetails();
            game.DisplayMessage();

        }

        private static void CalcutateMeal()
        {
            Meal meal = new Meal();

            UserLib.WriteTitle("Meal Calculator");

            meal.InputData();
            meal.CalculateTotalCosts();
            meal.OutputCosts();

        }

        private static void RunWeek2()
        {
            //Week2
            T31_Game.BuyWeapons();
            T32_Display.ShowName();
            T33_Fairy.Load();
            T34_Pressure.Check();
        }

        private static void RunWeek1()
        {
            //Week1
            T11_Town.Check();
            T12_VAT.Calculate();
            T13_Course.CalulateMarks();
        }
    }
}
