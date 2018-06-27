using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    static class GameStatus
    {
        public static States Winner(Board board)
        {
            if (WinCheck(board, States.X) == true)      return States.X;
            else if (WinCheck(board, States.O) == true) return States.O;
            else                                        return States.Undecided;
        }

        private static bool WinCheck(Board board, States state)
        {
            for (int row = 0; row < 3; row++)
            {
                if (board.State[row, 0] == state && board.State[row,1] == state && board.State[row,2] == state)
                {
                    return true;
                }
            }
            for (int col = 0; col < 3; col++)
            {
                if (board.State[0, col] == state && board.State[1, col] == state && board.State[2, col] == state)
                {
                    return true;
                }
            }
            if (board.State[0,0] == state && board.State[1,1] == state && board.State[2,2] == state)
            {
                return true;
            }
            if (board.State[0,2] == state && board.State[1,1] == state && board.State[2,0] == state)
            {
                return true;
            }
            return false;
        }

        public static bool DrawCheck(Board board)
        {
            foreach (States state in board.State)
            {
                if (state == States.Undecided) return false;
            }

            Console.WriteLine("\nDraw game! Neither player wins this round!");
            return true;
        }
    }
}
