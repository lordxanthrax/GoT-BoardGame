using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameOfThronesBG.Game_Piece_Classes;

namespace GameOfThronesBG
{
    class MapPopulator
    {
        public static ArrayList CreateTerritoryList(String territoryPath, int numPlayers)
        {
            ArrayList territoriesArray = new ArrayList();


            StreamReader sr = new StreamReader(territoryPath);
            sr.ReadLine();
            sr.ReadLine();

            string line;

            int territoryID;
            int supply;
            int power;
            string name;
            bool hasCastle;
            bool hasStronghold;
            int waterConfig;
            int posX;
            int posY;
            int owner;

            Territory tempTerritory;

            ArrayList connections = new ArrayList();

            //start adding the territories to the board
            while ((line = sr.ReadLine()) != null)
            {
                if (line != "")
                {
                    string[] elements = line.Split(',');
                    territoryID = int.Parse(elements[0]);
                    supply = int.Parse(elements[1]);
                    power = int.Parse(elements[2]);
                    name = elements[3];
                    owner = 0;

                    if (elements[4] == "1")
                    {
                        hasCastle = true;
                    }
                    else
                    {
                        hasCastle = false;
                    }

                    if (elements[5] == "1")
                    {
                        hasStronghold = true;
                    }
                    else
                    {
                        hasStronghold = false;
                    }

                    waterConfig = int.Parse(elements[6]);
                    posX = (int)(int.Parse(elements[7]) * 1.6);
                    posY = (int)(int.Parse(elements[8]) * 1.65);

                    for (int i = 9; i < elements.Length; i++)
                    {
                        connections.Add(elements[i]);
                    }

                    if (territoryID == 32 || territoryID == 36)
                    {
                        owner = 1;
                    }
                    if (territoryID == 20 || territoryID == 25)
                    {
                        owner = 2;
                    }
                    if (territoryID == 4 || territoryID == 7)
                    {
                        owner = 3;
                    }
                    if (territoryID == 15 || territoryID == 11)
                    {
                        owner = 5;
                    }
                    if(numPlayers == 5 || numPlayers == 6)
                    {
                        if (territoryID == 34 || territoryID == 39)
                        {
                            owner = 6;
                        }
                    }
                    if (numPlayers == 6)
                    {
                        if (territoryID == 47 || territoryID == 50)
                        {
                            owner = 4;
                        }
                    }  

                    tempTerritory = new Territory(territoryID, supply, power, connections, name,
                        hasCastle, hasStronghold, waterConfig, posX, posY, owner);

                    territoriesArray.Add(tempTerritory);
                }

                
            }
            
            return territoriesArray;
        }
    }
}
