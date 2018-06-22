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
            Console.Title = "Mike's Tic Tac Toe Game";
            Console.WriteLine("Mike's Tic Tac Toe Game!");
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
            Console.Clear();

            Console.Write("Type the name of Player 1: ");
            string p1Name = Console.ReadLine();
            Console.Write("Type the name of Player 2: ");
            string p2Name = Console.ReadLine();

            Player player1 = new Player(p1Name);
            Player player2 = new Player(p2Name);
            StartDecider decider = new StartDecider();

            bool firstMove = decider.StartPlayer(player1.startNum, player2.startNum);
            Console.WriteLine((firstMove == true) ? $"{player1.Name} Starts!" : $"{player2.Name} Starts!");



            Console.ReadKey();
        }
    }
}
