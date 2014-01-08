using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfThronesBG.Game_Piece_Classes
{
    class IronThroneTrack : Track
    {
        private int[] order;
 
        public IronThroneTrack(int numPlayers)
            : base(numPlayers)
        {
            this.order = new int[numPlayers];
        }

        private void FillTrack(int[] newOrder)
        {
            if (newOrder.Length == order.Length)
            {
                this.order = newOrder;
            }
        }

        //iron throne is the starting turn order, so we'll refer to the numbers as follows
        //for the rest of the code:
        // 1. Baratheon
        // 2. Lannister
        // 3. Stark
        // 4. Martell
        // 5. Grejoy
        // 6. Tyrell
        public void FillTrackDefault()
        {
            if (this.Size == 4)
            {
                order[0] = 1;
                order[1] = 2;
                order[2] = 3;
                order[3] = 5;
            }

            else if (this.Size == 5)
            {
                order[0] = 1;
                order[1] = 2;
                order[2] = 3;
                order[3] = 5;
                order[4] = 6;
            }

            else if (this.Size == 6)
            {
                order[0] = 1;
                order[1] = 2;
                order[2] = 3;
                order[3] = 4;
                order[4] = 5;
                order[5] = 6;
            }
        }
    }
}
