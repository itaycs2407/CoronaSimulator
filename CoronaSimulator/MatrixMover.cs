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

        public void setConfiguration(Configuration i_Config)
        {
            this.m_Config = i_Config;
        }

        


        public void GenrateMove(ref Cell[,] io_Grid)
        {
            for (int i = 0; i < this.m_Config.Bound; i++)
            {
                io_Grid[i, 1] = io_Grid[this.m_Config.Bound - i -1, 1];
                io_Grid[i, 3] = io_Grid[this.m_Config.Bound - i -1, 3];
                io_Grid[i, 2] = io_Grid[this.m_Config.Bound - i -1, 2];
            }
        }
         

        public void CreateElements(ref Cell[,] io_Grid)
        {
            int counter = 1;
            CreateElement(ref counter ,this.m_Config.SickNumber, eStatus.Sick, ref io_Grid);
            CreateElement(ref counter ,this.m_Config.HealtyNumber, eStatus.Healty, ref io_Grid);
            CreateElement(ref counter ,this.m_Config.CarryNumber, eStatus.Carry, ref io_Grid);
            CreateElement(ref counter ,this.m_Config.InspectorsNumber, eStatus.Inspector, ref io_Grid);
        }


        public void CreateElement(ref int io_IDCounter ,int  i_NumberOfInstances , eStatus i_Status,ref Cell[,] io_Grid)
        {
            Random m_Rnd = new Random();
            int x, y;
            for (int i = 0; i < i_NumberOfInstances; i++)
            {
                do
                {
                    x = m_Rnd.Next(this.m_Config.Bound);
                    y = m_Rnd.Next(this.m_Config.Bound);
                }
                while (!isAvailable(x, y, io_Grid));
                io_Grid[x, y].ID = io_IDCounter++;
                io_Grid[x, y].Status = i_Status;
                io_Grid[x, y].BodyHeat = i_Status == eStatus.Sick ? m_Rnd.Next(38, 40) + (float)m_Rnd.NextDouble() : m_Rnd.Next(35, 38) + (float)m_Rnd.NextDouble();
            }
        }


        private bool isAvailable(int i_X, int i_Y, Cell[,] i_Grid)
        {
            return i_Grid[i_X, i_Y].ID == 0;
        }
    }
}
