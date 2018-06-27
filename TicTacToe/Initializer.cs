using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    static class Initializer
    {
        static public void Intro(out string p1Name, out string p2Name)
        {
            Console.Title = "Mike's Tic Tac Toe Game";
            Console.WriteLine("Mike's Tic Tac Toe Game!");
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Type the name of Player 1: ");
            p1Name = Console.ReadLine();
            Console.Write("Type the name of Player 2: ");
            p2Name = Console.ReadLine();
        }

        static public void Ending(States winner, bool draw, string xName, string oName)
        {
            if (winner == States.X)
            {
                Console.Write("\nThe winner of this round is: ");
                Console.WriteLine($"{xName}");
            }
            else if (winner == States.O)
            {
                Console.Write("\nThe winner of this round is: ");
                Console.WriteLine($"{oName}");
            } else if (winner == States.Undecided && draw)
            {
                Console.WriteLine("\nDraw game! Neither player wins this round!");
            }
        }
    }
}
