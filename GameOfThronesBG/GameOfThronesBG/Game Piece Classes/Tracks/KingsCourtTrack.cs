using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfThronesBG.Game_Piece_Classes
{
    class KingsCourtTrack : Track
    {
        private int[] order;

        public KingsCourtTrack(int numPlayers) :
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
                this.order[0] = 2;
                this.order[1] = 3;
                this.order[2] = 1;
                this.order[3] = 5;
            }

            if (this.Size == 5)
            {
                this.order[0] = 2;
                this.order[1] = 3;
                this.order[2] = 1;
                this.order[3] = 6;
                this.order[4] = 5;
            }

            if (this.Size == 6)
            {
                this.order[0] = 2;
                this.order[1] = 3;
                this.order[2] = 4;
                this.order[3] = 1;
                this.order[4] = 6;
                this.order[5] = 5;
            }
        }
    }
}
