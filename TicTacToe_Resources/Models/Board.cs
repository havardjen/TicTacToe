using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Resources.Models
{
    public class Board
    {
        public Board(int size)
        {
            _size = size;
        }

        private readonly int _size;

        public Cell[,] Cells { get; set; }
    }
}
