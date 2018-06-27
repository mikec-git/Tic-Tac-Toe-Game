using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {
        public States[,] State { get; private set; }
        public States CurrentMove { get; private set; }

        public Board()
        {
            State = new States[3, 3];
            CurrentMove = States.X;
        }

        public void InputMoveToBoard(Player currentPlayer, Board board)
        {
            Console.WriteLine($"\n{currentPlayer.Name}'s Turn...");
            var position = currentPlayer.PlayerMove(board);
            while (CheckIfUndecided(position, board) == false)
            {
                Console.WriteLine("That selection is already taken. Try again: ");
                position = currentPlayer.PlayerMove(board);
            }

            board.State[position.Item1, position.Item2] = board.CurrentMove;
            board.CurrentMove = ((board.CurrentMove == States.X) ? States.O : States.X);
        }

        // Correlates user input for board number (1 to 9) with rows and columns
        // Will follow keyboard numpad format
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

        private bool CheckIfUndecided(Tuple<int,int> position, Board board)
        {
            if (board.State[position.Item1,position.Item2] == States.Undecided) return true;

            return false;
        }
    }
}
