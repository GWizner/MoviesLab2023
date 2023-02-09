using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab2023
{
    public class GetColor
    {
        public static void CategoryColor(int key)
        {

            if (key == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (key == 1)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (key == 2)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            else if (key == 3)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
            else if (key == 4)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (key == 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            else if (key == 6)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (key == 7)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
            }
        }
    }
}
