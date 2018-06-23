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
        
        public Tuple<int,int> BoardPosition(int squareNum)
        {
            // Will follow keyboard numpad format
            switch (squareNum)
            {
                case 1: return Tuple.Create(2, 0); 
                case 2: return Tuple.Create(2, 1);
                case 3: return Tuple.Create(2, 2);
                case 4: return Tuple.Create(1, 0);
                case 5: return Tuple.Create(1, 1);
                case 6: return Tuple.Create(1, 2);
                case 7: return Tuple.Create(0, 0);
                case 8: return Tuple.Create(0, 1);
                case 9: return Tuple.Create(0, 2);
                default: return null;
            }
            
        }

    }
}
