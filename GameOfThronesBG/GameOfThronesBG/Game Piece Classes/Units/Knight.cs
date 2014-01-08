using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfThronesBG.Game_Piece_Classes.Units
{
    class Knight : GenericUnit
    {
        public Knight(int owner)
            : base(owner)
        {
            this.CombatStrength = 2;
        }

        public override int GetCombatStrength(bool offense, bool castle)
        {
            return CombatStrength;
        }
    }
}
