using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public static Random rnd = new Random();
        public string name { get; }
        public int startNum { get; }
        private int squareNum;

        public Player(string name)
        {
            this.name = name;
            startNum = rnd.Next(0, 101);
        }
        
        public Tuple<int,int> PlayerMove (Board board)
        {
            do
            {
                Console.WriteLine("Enter board position: ");
                string squareNumString = Console.ReadLine();
                squareNum = Convert.ToInt32(squareNumString);
                if (squareNum < 1 || squareNum > 9)
                {
                    Console.WriteLine("That is an incorrect input, try again.");
                }
            } while (squareNum < 1 || squareNum < 9);

            var position = board.BoardPosition(squareNum);
            return position;
        }
    }
}
