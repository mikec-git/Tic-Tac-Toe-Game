using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class StartPlayer
    {
        private static Random rnd = new Random();
        private int p1Num, p2Num;

        public void GameStarter(Player player1, Player player2, out Player xPlayer, out Player oPlayer)
        {
            if (Order(player1.Name, player2.Name))
            {
                xPlayer = player1;
                oPlayer = player2;
            }
            else
            {
                xPlayer = player2;
                oPlayer = player1;
            }
            Console.WriteLine($"\nIt was randomly decided that {xPlayer.Name} starts!");
        }

        private bool Order(string p1Name, string p2Name)
        {
            do
            {
                p1Num = rnd.Next(0, 101);
                p2Num = rnd.Next(0, 101);
            } while (p1Num == p2Num);

            return (p1Num > p2Num) ? true : false; 
        }
    }
}
