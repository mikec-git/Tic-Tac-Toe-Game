using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Initializer.Intro(out string p1Name, out string p2Name);

            Board board = new Board();
            Player player1 = new Player(p1Name);
            Player player2 = new Player(p2Name);
            Player xPlayer, oPlayer;
            StartPlayer starter = new StartPlayer();
            Renderer render = new Renderer();

            // Prints out keypad instructions for players
            render.Instructions();

            // I thought it would be fair to randomly determine who starts first
            starter.GameStarter(player1, player2, out xPlayer, out oPlayer);

            // Game runs while no states are three-in-a-row, and while the board is not yet completely filled
            while (GameStatus.Winner(board) == States.Undecided && !GameStatus.DrawCheck(board))
            {
                render.DrawBoard(board);
                if (board.CurrentMove == States.X)  board.InputMoveToBoard(xPlayer, board);
                else                                board.InputMoveToBoard(oPlayer, board);
            }
            render.DrawBoard(board);

            Initializer.Ending(GameStatus.Winner(board), GameStatus.DrawCheck(board), xPlayer.Name, oPlayer.Name);

            Console.WriteLine("\nPress any key to exit: ");
            Console.ReadKey();
        }
    }
}
