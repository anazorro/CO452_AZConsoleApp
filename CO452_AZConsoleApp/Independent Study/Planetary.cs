using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Independent_Study
{
    class Planetary
    {
        private static string planet;
        private static double radius;
        private static double volume;

        private static double Pi = 3.142;
        private static int power = 3;



        public static void Sums()
        {
            UserLib.WriteTitle("Planetary Sums");

            planet = UserLib.GetString("Enter the name of a planet > ");

            radius = UserLib.GetDouble("Enter the radius of the planet you chose in kilometres > ");

            volume = 4.0 / 3 * Pi * Math.Pow(radius, 3);

            Console.WriteLine();
            Console.WriteLine("Planet: " + planet + " \t\t Radius: " + radius + " km");
            Console.WriteLine("\n\t Volume of " + planet);
            Console.WriteLine("\t =============");
            Console.WriteLine("\t " + volume.ToString("###,###.00") + " cubic kilometres");

        }
        
        
    }
}
