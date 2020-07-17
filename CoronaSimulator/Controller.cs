using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CoronaSimulator
{
    public class Controller
    {
        private Configuration m_config = new Configuration();
        private Random m_Rnd = new Random();
        private Cell[,] m_Grid;
        private int m_IDCounter = 0;
        Form1 settings;

        public Controller()
        {
            settings = new Form1();
            settings.m_Control = this;
            settings.ShowDialog();
        }

        public Configuration Config { get => m_config; set => m_config = value; }
        public int IDCounter { get => m_IDCounter; set => m_IDCounter = value; }

        private void Init()
        {
            initGrid();
        }

        private void initGrid()
        {
            int gridBoundSize = Config.Bound;
            m_Grid = new Cell[gridBoundSize, gridBoundSize];
            initAllCells();
            initCellsWithPersons(Config.HealtyNumber, eStatus.Healty);
            initCellsWithPersons(Config.SickNumber, eStatus.Sick);
            initCellsWithPersons(Config.CarryNumber, eStatus.Carry);
        }

        private void initAllCells()
        {
            for (int i = 0; i < Config.Bound; i++)
            {
                for (int j = 0; j < Config.Bound; j++)
                {
                    m_Grid[i, j] = new Cell(0, 0, eStatus.None);
                }
            }
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
                m_Grid[x,y].ID = IDCounter++;
                m_Grid[x, y].Status = i_Status;
                m_Grid[x, y].BodyHeat =i_Status == eStatus.Sick ? m_Rnd.Next(38, 40) + (float)m_Rnd.NextDouble() : m_Rnd.Next(35, 38) + (float)m_Rnd.NextDouble();
            }
        }

        private bool isAvailable(int i_X, int i_Y)
        {
            return m_Grid[i_X, i_Y].ID == 0;
        }
    }
}

