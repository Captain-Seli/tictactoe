using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class WinInfo
    {
        public WinType Type { get; set; } // Stores the type of win: row, col, or diag.
        public int Number { get; set; } // Stores which row, col, or diag has won.
    }
}
