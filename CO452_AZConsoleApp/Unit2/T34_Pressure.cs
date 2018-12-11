using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO452_AZConsoleApp.Unit2
{
    class T34_Pressure
    {
        //we use word static so that we can use a class instead of object
        public static void Check()
        {
            
            const int MIN_PRESSURE = 10;
            const int MAX_PRESSURE = 100;
            const int DANGEROUS_PRESSURE = 120;

            int pressure = 0;

            //do something while the pressure is less than 120
            //with do/while it does it first and after checks it 
            //with repeat until it checks it before it does it however c# doesnt have ''repeat until'' other languages do
            do
            {
                pressure = UserLib.GetInt("Pressure > ");
                if (pressure < MIN_PRESSURE)
                {
                    Console.WriteLine("Too Low!");
                }
                else if ((pressure >= MIN_PRESSURE) && (pressure <= MAX_PRESSURE))
                {
                    Console.WriteLine("Pressure is Normal!");
                }
                else if ((pressure >= MAX_PRESSURE) && (pressure <= DANGEROUS_PRESSURE))
                {
                    Console.WriteLine("Pressure is too high!");
                }
                else if (pressure >= DANGEROUS_PRESSURE)
                {
                    Console.WriteLine("Pressure is Dangerous!");
                }
            } while (pressure < DANGEROUS_PRESSURE);
        }
    }
}
