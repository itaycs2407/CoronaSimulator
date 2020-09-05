using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaSimulator
{
    class MatrixMover : IMove
    {
        public Configuration m_Config;
        private Cell[,] m_Grid;
        public int m_TileIndex { get; set; } = 1;
        private List<Tuple<int, int>> m_ElementCord = new List<Tuple<int, int>>();
        MatrixMover(Tile I_Tile)
        {
            m_Grid = new Cell[I_Tile.m_Bound, I_Tile.m_Bound];
        }

        public int[] GenrateMove()
        {
            int[] a = { 1,2,3};
            return a;
        }

        public void setConfiguration(Configuration i_Config)
        {
            this.m_Config = i_Config;
        }

        Control[] IMove.AddElementToScreen(int i_NumberOfTypes, Bitmap i_Color, Tile i_Tile)
        {
            PictureBox tempTile;
            System.Windows.Forms.Control[] tempList = new System.Windows.Forms.Control[i_NumberOfTypes];
            int panellRange = i_Tile.k_StartingCord + i_Tile.m_Bound * i_Tile.m_TileSize;


            for (int i = 0; i < i_NumberOfTypes; i++)
            {
                tempTile = new PictureBox();
                tempTile.Visible = true;
                tempTile.Width = i_Tile.m_TileSize;
                tempTile.Height = i_Tile.m_TileSize;
                tempTile.Tag = m_TileIndex++;
                int rowIndex = ItemUtils.getRandomCordInRangeMatrix(i_Tile.m_Bound);
                int colIndex = ItemUtils.getRandomCordInRangeMatrix(i_Tile.m_Bound);
                while (m_Grid[rowIndex,colIndex].ID == 0)
                {
                   rowIndex = ItemUtils.getRandomCordInRangeMatrix(i_Tile.m_Bound);
                   colIndex = ItemUtils.getRandomCordInRangeMatrix(i_Tile.m_Bound);
                }
                m_Grid[rowIndex, colIndex].ID == tempTile.Tag
                tempTile.Top = 
                tempTile.Left = 
                this.m_ElementCord.Add(Tuple.Create(tempTile.Top, tempTile.Left));
                tempTile.SizeMode = PictureBoxSizeMode.StretchImage;
                tempTile.Image = i_Color;
                tempList[i] = tempTile;
            }
            return tempList;
        }
    }
}
