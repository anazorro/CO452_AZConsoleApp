using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CO452_AZConsoleApp.Unit2
{
    class T32_Display
    {
        public static void ShowName()
        {
            Random generator = new Random();

            int count = 0;
            int x = 10;
            int y = 4;

            while(count < 10)
            {
                UserLib.WriteTitle("ShowName");
                Console.SetCursorPosition(x, y);
                Console.Write("Ana");

                y = y + 2;

                x = generator.Next(10, 70);
                
                count++;

                Thread.Sleep(400);
                Console.Clear();

            }
        }
    }
}
