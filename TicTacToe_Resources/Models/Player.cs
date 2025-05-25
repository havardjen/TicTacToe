using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Resources.Models
{
    public class Player
    {
        public Player(PlayerType typeOfPlayer)
        {
            TypeOfPlayer = typeOfPlayer;
        }

        public PlayerType TypeOfPlayer { get; set; }
    }

    public enum PlayerType
    {
        Human,
        Computer
    }
}
