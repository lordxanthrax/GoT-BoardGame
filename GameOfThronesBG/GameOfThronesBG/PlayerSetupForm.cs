using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameOfThronesBG
{
    public partial class PlayerSetupForm : Form
    {
        int numPlayers;

        public PlayerSetupForm()
        {
            InitializeComponent();
        }

        private void PlayerSetupForm_Load(object sender, EventArgs e)
        {
            
        }

        public int GetNumberOfPlayers()
        {
            return numPlayers;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (rbnFourPlayer.Checked)
            {
                numPlayers = 4;
            }
            if (rbnFivePlayer.Checked)
            {
                numPlayers = 5;
            }
            if (rbnSixPlayer.Checked)
            {
                numPlayers = 6;
            }

            this.Close();
        }
    }
}
