using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfThronesBG.Game_Piece_Classes.RandomTokens
{
    class OrderToken
    {
        private char OrderType { set; get; }
        private bool Starred { set; get; }

        public OrderToken(char orderType, bool starred)
        {
            this.OrderType = orderType;
            this.Starred = starred;
        }

    }
}
