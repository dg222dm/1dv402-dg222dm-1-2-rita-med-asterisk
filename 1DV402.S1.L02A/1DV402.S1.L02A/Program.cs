using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L02A
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int column = 0; column < 25; column++)
            {
                switch (column % 3)
                {
                    case 0: Console.ForegroundColor = ConsoleColor.Yellow; // sätter färgen till gul om kolumn % 3 = 0
                        break;
                    case 1: Console.ForegroundColor = ConsoleColor.Magenta; // färgen blir "magenta" om kolumn % 3 = 1
                        break;
                    case 2: Console.ForegroundColor = ConsoleColor.Green; // färgen blir grön om kolumn % 3 = 2
                        break;
                }
                for (int row = 1; row <= 39; row++)
                { 
                    Console.Write("* ");
                }
                Console.WriteLine();
                if ((column % 2) == 0) // Om kolumn % 2 == 0 ska ett mellanrum finnas i början av raden
                {
                    Console.Write(" "); 
                }
                Console.ResetColor();  
                
            }

        }
    }
}
