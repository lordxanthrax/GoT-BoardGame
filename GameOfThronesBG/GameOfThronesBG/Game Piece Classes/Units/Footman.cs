using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfThronesBG.Game_Piece_Classes.Units
{
    class Footman : GenericUnit
    {
        public Footman(int owner)
            : base(owner)
        {
            this.CombatStrength = 1;
        }

        public override int GetCombatStrength(bool offense, bool castle)
        {
            return CombatStrength;
        }
    }
}
