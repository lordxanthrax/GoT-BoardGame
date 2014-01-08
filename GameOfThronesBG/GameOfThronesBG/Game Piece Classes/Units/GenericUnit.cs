using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace GameOfThronesBG.Game_Piece_Classes.Units
{
    abstract class GenericUnit
    {
        protected int CombatStrength { set; get; }
        protected int Owner { set; get; }
        protected Color Color { set; get; }
        public int movedThisTurn { set; get; }
        public int locationID { get; set; }

        public GenericUnit(int owner)
        {
            this.Owner = owner;
            this.Color = ColorMaker.ColorChooser(owner);
        }

        public abstract int GetCombatStrength(bool offense, bool castle);
        
    }
}
