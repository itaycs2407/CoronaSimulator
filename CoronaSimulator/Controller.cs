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
        private Configuration m_config;
        private Random m_Rnd = new Random();
        private Cell[,] m_Grid;
        private int m_IDCounter = 0;
        private SettingsForm m_SettingsFrm;
        private SimulatorForm m_SimulatorFrm;
        private IMove m_MoveController;

        public Controller()
        {
            m_SettingsFrm = new SettingsForm();
            m_SimulatorFrm = new SimulatorForm();
            m_SettingsFrm.m_Control = this;
            m_SimulatorFrm.m_Control = this;
        }

        public void Run()
        {
            m_SettingsFrm.ShowDialog();
            m_SimulatorFrm.SimulatorConfiguration = this.m_config;
            setMoveControler();
            Init();
            m_SimulatorFrm.ShowDialog();
        }

        public Configuration Config { get => m_config; set => m_config = value; }

        public int IDCounter { get => m_IDCounter; set => m_IDCounter = value; }


        public void setMoveControler()
        {
            this.m_MoveController = new MatrixMover();
            this.m_MoveController.setConfiguration(this.Config);
        }
        public Cell[,] GetGrid()
        {
            return this.m_Grid;
        }
        public void SetGrid(Cell [,] i_Grid)
        {
            this.m_Grid = i_Grid;
        }
        private void Init()
        {
            initGrid();
            this.m_Grid = m_MoveController.CreateElement();
            updateUi(this.m_Grid);
        }

        private void updateUi(Cell [,] i_Grid)
        {
            this.m_SimulatorFrm.UpdateUi(m_Grid); 
        }
        private void initGrid()
        {
            int gridBoundSize = Config.Bound;
            m_Grid = new Cell[gridBoundSize, gridBoundSize];
            initAllCells();
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

        
    }
}

