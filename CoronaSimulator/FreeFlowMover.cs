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
        private List<Tuple<int, int>> m_ElementCord = new List<Tuple<int, int>>();

        public System.Windows.Forms.Control[] AddElementToScreen(int i_NumberOfTypes, Bitmap i_Color, Tile i_Tile)
        {
            PictureBox tempTile;
            const int k_NumberOfTriesToRandom = 10;
            int numberOfTriesToRandomCTR = 0;
            System.Windows.Forms.Control[] tempList = new  System.Windows.Forms.Control[i_NumberOfTypes];
            int panellRange = i_Tile.k_StartingCord + i_Tile.m_Bound * i_Tile.m_TileSize ;
            //int panellRange = i_Tile.k_StartingCord + i_Tile.m_Bound * (i_Tile.m_TileSize + i_Tile.k_SpaceBetweenTiles) - i_Tile.k_SpaceBetweenTiles;
            for (int i = 0; i < i_NumberOfTypes; i++)
            {
                tempTile = new PictureBox();
                tempTile.Visible = true;
                tempTile.Width = i_Tile.m_TileSize;
                tempTile.Height = i_Tile.m_TileSize;
                tempTile.Tag = m_TileIndex++;
                tempTile.Top = ItemUtils.getRandomCordInRangeFreeFlow(panellRange, i_Tile.m_TileSize);
                tempTile.Left = ItemUtils.getRandomCordInRangeFreeFlow(panellRange, i_Tile.m_TileSize);
                while ((ItemUtils.isOnTop(tempTile.Top, tempTile.Left, i_Tile.m_TileSize, m_ElementCord)) && numberOfTriesToRandomCTR < k_NumberOfTriesToRandom)
                {
                    tempTile.Top = ItemUtils.getRandomCordInRangeFreeFlow(panellRange, i_Tile.m_TileSize);
                    tempTile.Left = ItemUtils.getRandomCordInRangeFreeFlow(panellRange, i_Tile.m_TileSize);
                    numberOfTriesToRandomCTR++;
                }
                numberOfTriesToRandomCTR = 0;
                this.m_ElementCord.Add(Tuple.Create(tempTile.Top, tempTile.Left));
                tempTile.SizeMode = PictureBoxSizeMode.StretchImage;
                tempTile.Image = i_Color;
                tempList[i] = tempTile;
            }
            return tempList;
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
