﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        public static Random rnd = new Random();
        public string Name { get; }
        public int startNum { get; }
        private int squareNum;

        public Player(string name)
        {
            Name = name;
            this.startNum = rnd.Next(0, 101);
        }
        
        public int PlayerMove (string squareNumString)
        {
            squareNum = Convert.ToInt32(squareNumString);
        }
    }
}
