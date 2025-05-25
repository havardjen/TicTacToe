using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Resources.Models
{
    public class Cell
    {
        public Cell()
        {
            Content = string.Empty;
        }

        
        private string _content;


        public static List<string> ValidContent { get { return new List<string> { "X", "O", "" }; } }

        public string Content 
        {
            get { return _content; }
            set
            {
                if(!ValidContent.Contains(value))
                    throw new ArgumentException(Messages.ErrorMessageIncorrectCellContents);

                _content = value;
            }
        }
    }
}
