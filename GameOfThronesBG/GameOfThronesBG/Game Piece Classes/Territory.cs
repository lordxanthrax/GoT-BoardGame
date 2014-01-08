using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace GameOfThronesBG.Game_Piece_Classes
{
    

    class Territory
    {
        private ArrayList Neighbors { get; set; }
        public int TerritoryID { get; private set; }
        private int Supply { get; set; }
        private int Power { get; set; }
        private string Name { get; set; }
        private bool HasCastle { get; set; }
        private bool HasStronghold { get; set; }
        private int Water { get; set; }
        public int PosX { get; private set; }
        public int PosY { get; private set; }
        public int Owner { get; set; }
        public ArrayList Units { get; set; }

        public Territory(int territoryID, int supply, int power, ArrayList neighbors,
            string name, bool hasCastle, bool hasStronghold, int water, int posx, int posy,
            int owner)
        {
            Neighbors = new ArrayList();
            Units = new ArrayList();

            foreach (string territory in neighbors)
            {
                int tempNeighbor = int.Parse(territory);
                this.Neighbors.Add(tempNeighbor);
            }

            this.TerritoryID = territoryID;
            this.Supply = supply;
            this.Power = power;
            this.Name = name;
            this.HasCastle = hasCastle;
            this.HasStronghold = hasStronghold;
            this.Water = water;
            this.PosX = posx;
            this.PosY = posy;
            this.Owner = owner;
        }
        public Territory(Territory territory)
        {
            Neighbors = new ArrayList();
            foreach (string tempTerr in territory.Neighbors)
            {
                int tempNeighbor = int.Parse(tempTerr);
                this.Neighbors.Add(tempNeighbor);
            }

            this.TerritoryID = territory.TerritoryID;
            this.Supply = territory.Supply;
            this.Power = territory.Power;
            this.Name = territory.Name;
            this.HasCastle = territory.HasCastle;
            this.HasStronghold = territory.HasStronghold;
            this.Water = territory.Water;
            this.PosX = territory.PosX;
            this.PosY = territory.PosY;
            this.Owner = territory.Owner;
        }
    }
}
