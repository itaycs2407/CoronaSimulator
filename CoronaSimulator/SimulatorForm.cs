using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CoronaSimulator
{
    public partial class SimulatorForm : Form
    {
        private Configuration m_SimulatorConfiguration;

        public Controller m_Control = null;

        private IMove m_MoveControler;
        
        public SimulatorForm()
        {
            InitializeComponent();
        }

        public Configuration SimulatorConfiguration { get => m_SimulatorConfiguration; set => m_SimulatorConfiguration = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
  
        
        internal void UpdateUi(Cell[,] m_Grid)
        {
            int k_StartingCord = 3;
            int k_SpaceBetweenTiles = 1;
            int xPos, yPos;
            PictureBox tempTile= null;
        // calculate the ratio for tilesize dependeing on the panel size.
            int panelMinSize = Math.Min(splitContainer2.Panel2.Width, splitContainer2.Panel2.Height) ;
            int tileSize = panelMinSize / this.SimulatorConfiguration.Bound;
            for (int i = 0; i < this.SimulatorConfiguration.Bound; i++)
            {
                xPos = 0;
                yPos = k_StartingCord + i * tileSize + k_SpaceBetweenTiles;
                for (int j = 0; j < SimulatorConfiguration.Bound; j++)
                {
                    xPos = k_StartingCord + j * tileSize + k_SpaceBetweenTiles;
                    if (m_Grid[i,j].ID !=0)
                    {
                        tempTile = new PictureBox();
                        tempTile.Visible = true;
                        tempTile.Width = tileSize;
                        tempTile.Height = tileSize;
                        tempTile.Tag = m_Grid[i, j].ID;
                        tempTile.Top = yPos;
                        tempTile.Left = xPos;
                        tempTile.SizeMode = PictureBoxSizeMode.StretchImage;
                        switch (m_Grid[i,j].Status)
                        {
                            case eStatus.Inspector:
                                tempTile.Image = Properties.Resources.violet;
                                break;
                            case eStatus.Healty:
                                tempTile.Image = Properties.Resources.aqua;
                                break;
                            case eStatus.Sick:
                                tempTile.Image = Properties.Resources.red;
                                break;
                            case eStatus.Carry:
                                tempTile.Image = Properties.Resources.orange;
                                break;
                            case eStatus.Dead:
                                tempTile.Image = Properties.Resources.black;
                                break;
                            default:
                                break;
                        }
                        if (tempTile!=null)
                        {
                            this.splitContainer2.Panel2.Controls.Add(tempTile);
                        }
                    }
                }

            }

        }

        private void Move_Click(object sender, EventArgs e)
        {
            this.m_Control.MoveElemnts();
        }
    }
}
