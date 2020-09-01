using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaSimulator
{
    class FreeFlowMover : IMove
    {
        public int m_TileIndex { get; set; } = 1;
        public Configuration m_Config;
        private Random rangeRnd = new Random();

        public System.Windows.Forms.Control[] AddElementToScreen(int i_NumberOfTypes, Bitmap i_Color, Tile i_Tile)
        {
            PictureBox tempTile;
            System.Windows.Forms.Control[] tempList = new  System.Windows.Forms.Control[i_NumberOfTypes];
            int panellRange = i_Tile.k_StartingCord + i_Tile.m_Bound * (i_Tile.m_TileSize + i_Tile.k_SpaceBetweenTiles) - i_Tile.k_SpaceBetweenTiles;
            for (int i = 0; i < i_NumberOfTypes; i++)
            {
                tempTile = new PictureBox();
                tempTile.Visible = true;
                tempTile.Width = i_Tile.m_TileSize;
                tempTile.Height = i_Tile.m_TileSize;
                tempTile.Tag = m_TileIndex++;
                tempTile.Top = getRandomCordInRange(panellRange, i_Tile.m_TileSize);
                tempTile.Left = getRandomCordInRange(panellRange, i_Tile.m_TileSize);

                tempTile.SizeMode = PictureBoxSizeMode.StretchImage;
                tempTile.Image = i_Color;
                tempList[i] = tempTile;
               // this.splitContainer2.Panel2.Controls.Add(tempTile);
            }
            return tempList;
        }

        private int getRandomCordInRange(int i_PanellRange, int i_TileSize)
        {
            int result = rangeRnd.Next(i_PanellRange);
            while (result > i_PanellRange- i_TileSize)
            {
                result = rangeRnd.Next(i_PanellRange);
            }
            return result;
        }

        public int[] GenrateMove()
        {
            throw new NotImplementedException();
        }

        public void setConfiguration(Configuration i_Config)
        {
            this.m_Config = i_Config;
        }
    }
}
