using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTI
{
    public class Board
    {
        private int playerTurn { get; set; }
        public char[,] state;
        private int score { get; set; }
        public Board(int sizex, int sizey)
        {
            this.playerTurn = 0;
            this.state = new char[sizex, sizey];
            this.score = 0;
        }
        public void setSqare(int x,in int y, char charater)
        {
            this.state[x,y] = charater;
        }

    }
}
