using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        private State[,] state;
        public static State CurrentMove { get; private set; }

        public Board()
        {
            state = new State[3, 3];
            CurrentMove = State.X;
        }

        /* Correlates user input for board number (1 to 9) with rows and columns
         Will follow keyboard numpad format */
        public Tuple<int, int> BoardPosition(int squareNum)
        {
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

        public void InputMoveToBoard(Player currentPlayer, Board board)
        {
            var position = currentPlayer.PlayerMove(board);
            while (!CheckIfUndecided(position))
            {
                Console.WriteLine("The chosen location is already taken. Try again: ");
                position = currentPlayer.PlayerMove(board);
            }

            state[position.Item1, position.Item2] = CurrentMove;
            CurrentMove = ((CurrentMove == State.X) ? State.O : State.X);
        }

        private bool CheckIfUndecided(Tuple<int,int> position)
        {
            if (state[position.Item1,position.Item2] == State.Undecided)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
