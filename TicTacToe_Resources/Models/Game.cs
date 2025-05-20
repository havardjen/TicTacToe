using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Resources.Models
{
    public class Game
    {
        public Game(Board board, List<Player> players)
        {
            GameBoard = board;
            Players = players;
        }

        public Board GameBoard { get; set; }
        public List<Player> Players { get; set; }
    }
}
