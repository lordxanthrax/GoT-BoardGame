using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfThronesBG.Game_Piece_Classes.Cards
{
    class CombatCards
    {
        private string Name { set; get; }
        private int Strength { set; get; }
        private int Fortifications { set; get; }
        private int Swords { set; get; }
        private string Text { set; get; }

        public CombatCards(string name, int strength, int fortifications, int swords, string text)
        {
            this.Name = name;
            this.Strength = strength;
            this.Fortifications = fortifications;
            this.Swords = swords;
            this.Text = text;
        }

    }
}
