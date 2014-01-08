using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfThronesBG.Game_Piece_Classes.Units
{
    class Siege : GenericUnit
    {
        public Siege(int owner)
            : base(owner)
        {
            this.CombatStrength = 0;
        }

        public override int GetCombatStrength(bool offense, bool castle)
        {
            int tempCombatStrength = 0;

            if (offense && castle)
            {
                tempCombatStrength = 4;
            }

            return tempCombatStrength;
        }
    }
}
