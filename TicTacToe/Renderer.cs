using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Renderer
    {
        private char[,] gameBoard;
        private char[,] instructionBoard;
        private char symbol;
        private int renderRow, renderCol;

        public Renderer()
        {
            gameBoard = new char[5, 11];
            instructionBoard = new char[5, 11];

            for (int vRow = 0; vRow < 5; vRow += 2)
            {
                for(int vCol = 3; vCol < 8; vCol += 3)
                {
                    gameBoard[vRow,vCol] = '|';
                    instructionBoard[vRow, vCol] = '|';
                    if (vCol == 3) vCol++;
                }
                
                for(int iCol = 1, num = '7'; iCol < 10; iCol += 4, num++)
                {
                    if (vRow == 2 && num == '7') num = '4';
                    else if (vRow == 4 && num == '7') num = '1';
                    instructionBoard[vRow, iCol] = (Char)num;
                }
                    
            }

            for(int hRow = 1; hRow < 4; hRow += 2)
            {
                for(int hCol = 0; hCol < 11; hCol++)
                {
                    gameBoard[hRow, hCol] = (hCol != 3 && hCol != 7) ? '-' : '+';
                    instructionBoard[hRow, hCol] = (hCol != 3 && hCol != 7) ? '-' : '+';
                }
            }
        }

        public void Instructions()
        {
            Console.WriteLine("Players can use the numpad to place their move according to the following mapping: ");
            PrintAll(instructionBoard);
        }

        public void DrawBoard(Board board)
        {
            ConvertBoard(board);
            PrintAll(gameBoard);
        }

        private void PrintAll(Char[,] selectedBoard)
        {
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 11; col++)
                {
                    Console.Write(selectedBoard[row, col]);
                }
                Console.WriteLine("");
            }
        }

        // Converts current game board to the render version
        private void ConvertBoard(Board board)
        {
            for(int row = 0; row < 3; row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    if(board.State[row,col] != States.Undecided)
                    {
                        AddToRenderBoard(row, col, board.State[row, col]);
                    }
                }
            }
        }

        // Adds the state char to the designated location on the rendered game board
        private void AddToRenderBoard(int row, int col, States state)
        {
            symbol = (state == States.X) ? 'X' : 'O';
            TranslatedCoord(row, col, out renderRow, out renderCol);
            gameBoard[renderRow, renderCol] = symbol;
        }

        // Translates the rows and columns for the 3x3 game board to the rendered game board coordinates
        private void TranslatedCoord(int row, int col, out int renderRow, out int renderCol)
        {
            if (row == 0)       renderRow = 0;
            else if (row == 1)  renderRow = 2;
            else                renderRow = 4;

            if (col == 0)       renderCol = 1;
            else if (col == 1)  renderCol = 5;
            else                renderCol = 9;
        }
    }
}
