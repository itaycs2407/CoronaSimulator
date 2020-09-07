using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
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
            this.splitContainer2.Panel2.Controls.Clear();
            int k_StartingCord = 3;
            int k_SpaceBetweenTiles = 1;
            int xPos, yPos;
            PictureBox tempTile= null;
        // calculate the ratio for tilesize dependeing on the panel size.
            int panelMinSize = Math.Min(splitContainer2.Panel2.Width, splitContainer2.Panel2.Height) ;
            int tileSize = panelMinSize / this.SimulatorConfiguration.Bound;
            for (int i = 0; i < this.SimulatorConfiguration.Bound; i++)
            {
                yPos = k_StartingCord + i * tileSize + k_SpaceBetweenTiles;
                for (int j = 0; j < SimulatorConfiguration.Bound; j++)
                {
                    xPos = k_StartingCord + j * tileSize + k_SpaceBetweenTiles;
                    tempTile = new PictureBox();
                    tempTile.Visible = true;
                    tempTile.Width = tileSize;
                    tempTile.Height = tileSize;
                    tempTile.Tag = m_Grid[i, j].ID;
                    tempTile.Top = yPos;
                    tempTile.Left = xPos;
                    tempTile.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (m_Grid[i,j].ID !=0)
                    {
                        tempTile.Image = m_Grid[i, j].Color;
                    }
                    else
                    {
                        tempTile.Image = null;
                    }

                    if (tempTile!=null)
                    {
                        this.splitContainer2.Panel2.Controls.Add(tempTile);
                        
                    }
                }

            }
            Application.DoEvents();
        }

        private void Move_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.m_Control.MoveElemnts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void SimulatorForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = this.SimulatorConfiguration.Tick;
        }
    }
}
