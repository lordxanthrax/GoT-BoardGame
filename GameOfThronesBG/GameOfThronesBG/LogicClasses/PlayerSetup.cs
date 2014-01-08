using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GameOfThronesBG.LogicClasses
{
    class PlayerSetup
    {
        public static int DoPlayerSetup()
        {
            int numPlayers = 0;

            PlayerSetupForm playerSetupForm = new PlayerSetupForm();
            playerSetupForm.ShowDialog();
            numPlayers = playerSetupForm.GetNumberOfPlayers();
            playerSetupForm.Dispose();

            return numPlayers;
        }
        public static ArrayList CreatePlayers(int numPlayers)
        {
            ArrayList playerList = new ArrayList();
            return playerList;
        }
    }
}
