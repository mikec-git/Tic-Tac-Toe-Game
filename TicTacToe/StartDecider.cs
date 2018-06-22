using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class StartDecider
    {
        public bool StartPlayer(int p1Num, int p2Num)
        {
            while (p1Num == p2Num)
            {
                Random rnd = new Random();
                p1Num = rnd.Next(0, 101);
            }

            return (p1Num > p2Num) ? true : false; 
        }
    }
}
