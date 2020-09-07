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
        public Random m_Rnd = new Random();
        public MatrixMover()
        {
        }

        public void setConfiguration(Configuration i_Config)
        {
            this.m_Config = i_Config;
        }

        


        public void GenrateMove(ref Cell[,] io_Grid)
        {
            Cell emptyCell = new Cell(0, 0, eStatus.None);
            for (int i = 0; i < this.m_Config.Bound; i++)
            {
                for (int j = 0; j < this.m_Config.Bound; j++)
                {
                    if (io_Grid[i, j].ID != 0)
                    {
                        List<Tuple<int,int>> possiableMoves = getPossiableMoves(i, j, io_Grid);
                        int rndMoveSelected = m_Rnd.Next(possiableMoves.Count);
                        if (rndMoveSelected > 0)
                        {
                            io_Grid[possiableMoves[rndMoveSelected-1].Item1, possiableMoves[rndMoveSelected-1].Item2] = io_Grid[i, j];
                            io_Grid[i, j] = emptyCell;
                        }
                    }
                }
            }

            
        }

        private List<Tuple<int, int>> getPossiableMoves(int i_I, int i_J, Cell[,] i_Grid)
        {
            List<Tuple<int, int>> returnList = new List<Tuple<int, int>>();
            if (checkLimit(i_I + 1)) returnList.Add(Tuple.Create(i_I + 1, i_J));
            if (checkLimit(i_I - 1)) returnList.Add(Tuple.Create(i_I - 1, i_J));
            if (checkLimit(i_J + 1)) returnList.Add(Tuple.Create(i_I, i_J + 1));
            if (checkLimit(i_J - 1)) returnList.Add(Tuple.Create(i_I, i_J - 1));

            if (checkLimit(i_I + 1) && checkLimit(i_J + 1)) returnList.Add(Tuple.Create(i_I + 1, i_J + 1));
            if (checkLimit(i_I - 1) && checkLimit(i_J - 1)) returnList.Add(Tuple.Create(i_I - 1, i_J - 1));
            if (checkLimit(i_I - 1) && checkLimit(i_J + 1)) returnList.Add(Tuple.Create(i_I - 1, i_J + 1));
            if (checkLimit(i_I + 1) && checkLimit(i_J - 1)) returnList.Add(Tuple.Create(i_I + 1, i_J - 1));




            return returnList;
        }

        private bool checkLimit(int i_Limit)
        {
            return (i_Limit >= 0 && i_Limit < this.m_Config.Bound);
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
                switch (i_Status)
                {
                    case eStatus.Inspector:
                        io_Grid[x, y].Color = Properties.Resources.violet;
                        break;
                    case eStatus.Healty:
                        io_Grid[x, y].Color = Properties.Resources.aqua;
                        break;
                    case eStatus.Sick:
                        io_Grid[x, y].Color = Properties.Resources.red;
                        break;
                    case eStatus.Carry:
                        io_Grid[x, y].Color = Properties.Resources.orange;
                        break;
                    case eStatus.Dead:
                        io_Grid[x, y].Color = Properties.Resources.black;
                        break;
                    default:
                        break;
                }
            }
        }


        private bool isAvailable(int i_X, int i_Y, Cell[,] i_Grid)
        {
            return i_Grid[i_X, i_Y].ID == 0;
        }
    }
}
