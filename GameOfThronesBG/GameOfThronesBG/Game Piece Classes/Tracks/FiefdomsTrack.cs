using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfThronesBG.Game_Piece_Classes
{
    class FiefdomsTrack : Track
    {
        private int[] order;

        public FiefdomsTrack(int numPlayers) :
            base(numPlayers)
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
        public void FillTrackDefalt()
        {
            if (this.Size == 4)
            {
                order[0] = 5;
                order[1] = 3;
                order[2] = 1;
                order[3] = 2;
            }

            if (this.Size == 5)
            {
                order[0] = 5;
                order[1] = 6;
                order[2] = 3;
                order[3] = 1;
                order[4] = 2;
            }

            if (this.Size == 6)
            {
                order[0] = 5;
                order[1] = 6;
                order[2] = 4;
                order[3] = 3;
                order[4] = 1;
                order[5] = 2;
            }
        }


    }
}
