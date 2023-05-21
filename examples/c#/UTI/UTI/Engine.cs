using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace UTI
{
    
    class Engine
    {
        private Board board;
        int score { get; set; }
        // some settings
        int winglenght { get; set; }
        int players { get; set; }
        bool multi { get; set; }
        bool transpotable { get; set; }
        int depth { get; set; }
        int level { get; set; }
        int sizex { get; set; }
        int sizey { get; set; }
        public Engine()
        {
            sizex = 3;
            sizey = 3;
            board = new Board(sizex, sizey);
            score = 0;
            players = 2;
            multi = false;
            transpotable = false;
            // depth and level i have not implemented at all
        }
        public int CalculateMove()
        {
            score = 0;
            List<int> moves = new List<int>();
            //just returning a random move
            for (int i = 1; i < (sizey * sizex); i++)
            {
               if (CheckMove(i))
                {
                    moves.Add(i);
                }
            }
            var random = new Random();
            int index = random.Next(moves.Count);
            score = random.Next(-100, 100); // like the move the score is also a random number
            return (moves[index]);
        }
        private bool  CheckMove(int square)
        {
            /*
            | 1 | 2 | 3 |
            | 4 | 5 | 6 |
            | 7 | 8 | 9 |
            to coords
            */
            int x = (square - 1) / sizex;
            int y = (square - 1) % sizex;
            if (board.state[x, y] == default)
            {
                return true;
            }
            else return false;
        }
        public void MakeMove(int move, int player)
        {
            if (player != 1 || player != 2)
            {
                throw new CustomExpetion("OnlyDefaultPlayerCount");
            }
            if (move > sizex * sizey)
            {
                throw new CustomExpetion("BoardsizeNotSupported");
            }
            if (move < 0)
            {
                throw new CustomExpetion("NegativeDimentia");
            }
            int x = (move - 1) / sizex;
            int y = (move - 1) % sizex;
            board.state[x, y] = (GetSymbol(player)); //sets the board correctly

        }
        public char GetSymbol(int player)
        {
            if (player == 1)
            {
                return ('X');
            }
            else
            {
                return ('O');
            }

        }
        public void Setpos(string position)
        {
            
            string[] Moves = position.Split(';');
            foreach (string move in Moves)
            {
                
            }
            

        } 
        public void NewGame()
        {
            board = new Board(sizex, sizey);
        }
    }
}
