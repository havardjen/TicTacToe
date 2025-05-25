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
            ValidatePlayersInput(players);

            GameBoard = board;
            Players = players;
        }

        public Board GameBoard { get; set; }
        public List<Player> Players { get; set; }



        private void ValidatePlayersInput(List<Player> players)
        {
            if (players == null)
                throw new ArgumentException(Messages.ErrorMessagePlayersNotInitialized);
            else if (players.Count == 0)
                throw new ArgumentException(Messages.ErrorMessagePlayersNotInitialized);
            else if (players.Count < 2)
                throw new ArgumentException(Messages.ErrorMessageTooFewPlayers);
            else if (players.Count > 2)
                throw new ArgumentException(Messages.ErrorMessageTooManyPlayers);
        }
    }
}
