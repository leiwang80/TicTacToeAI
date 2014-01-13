using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Player
    {
        internal String name;
        internal String symbol;
        internal bool isAI;

        public Player(String str, String c, bool b=false)
        {
            name = str;
            symbol = c;
            isAI = b;
        }

    }
}
