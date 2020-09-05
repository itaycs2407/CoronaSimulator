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
       
        public MatrixMover()
        {
        }

        private void initCellsWithPersons(int i_NumberOfInstances, eStatus i_Status)
        {
            int x, y;
            for (int i = 0; i < i_NumberOfInstances; i++)
            {
                do
                {
                    x = m_Rnd.Next();
                    y = m_Rnd.Next();
                }
                while (!isAvailable(x, y));
                m_Grid[x, y].ID = IDCounter++;
                m_Grid[x, y].Status = i_Status;
                m_Grid[x, y].BodyHeat = i_Status == eStatus.Sick ? m_Rnd.Next(38, 40) + (float)m_Rnd.NextDouble() : m_Rnd.Next(35, 38) + (float)m_Rnd.NextDouble();
            }
        }

        private bool isAvailable(int i_X, int i_Y)
        {
            return m_Grid[i_X, i_Y].ID == 0;
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
        public 

        Control[] IMove.AddElementToScreen(int i_NumberOfTypes, Bitmap i_Color, Tile i_Tile)
        {
            
        }
    }
}
