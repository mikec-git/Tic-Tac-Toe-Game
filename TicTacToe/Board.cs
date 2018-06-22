using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        State[,] state;

        public Board()
        {
            state = new State[3, 3];
        }

    }
}
