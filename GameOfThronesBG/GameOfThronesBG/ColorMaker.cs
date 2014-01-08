using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace GameOfThronesBG
{
    class ColorMaker
    {
        public static Color ColorChooser(int faction)
        {
            Color ownerColor = Color.White;

            switch (faction)
            {
                case 0:
                    ownerColor = Color.White;
                    break;

                case 1:
                    ownerColor = Color.Yellow;
                    break;

                case 2:
                    ownerColor = Color.Red;
                    break;

                case 3:
                    ownerColor = Color.Silver;
                    break;

                case 4:
                    ownerColor = Color.SandyBrown;
                    break;

                case 5:
                    ownerColor = Color.Black;
                    break;

                case 6:
                    ownerColor = Color.ForestGreen;
                    break;
            }

            return ownerColor;
        }
    }
}
