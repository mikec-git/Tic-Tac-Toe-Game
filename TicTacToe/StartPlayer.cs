using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class StartPlayer
    {
        private static Random rnd = new Random();
        private int p1Num, p2Num;

        public bool Order(string p1Name, string p2Name)
        {
            do
            {
                p1Num = rnd.Next(0, 101);
                p2Num = rnd.Next(0, 101);
            } while (p1Num == p2Num);
            
            Console.WriteLine("\nIt was randomly decided that: ");
            Console.WriteLine((p1Num > p2Num) ? $"{p1Name} Starts!" : $"{p2Name} Starts!");

            return (p1Num > p2Num) ? true : false; 
        }
    }
}
