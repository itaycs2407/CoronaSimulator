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
       
        private IMove m_MoveControler;
        
        public SimulatorForm()
        {
            InitializeComponent();
        }

        public Configuration SimulatorConfiguration { get => m_SimulatorConfiguration; set => m_SimulatorConfiguration = value; }

        public void setMoveControler()
        {
            if (SimulatorConfiguration.StepType == "FreeFlow")
            {
                this.m_MoveControler = new FreeFlowMover();
            }
            else
            {
                this.m_MoveControler = new MatrixMover();
            }
            this.m_MoveControler.setConfiguration(this.SimulatorConfiguration);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
  
        private void init()
        {
            // calculate the ratio for tilesize dependeing on the panel size.
            int panelMinSize = Math.Min(splitContainer2.Panel2.Width, splitContainer2.Panel2.Height) ;
            Tile tile = new Tile(SimulatorConfiguration.Bound, panelMinSize);
            Control[] ControlsArray;
            List<Control> tempControlList = new List<Control>();
       
            tempControlList.AddRange(this.m_MoveControler.AddElementToScreen(SimulatorConfiguration.HealtyNumber, Properties.Resources.aqua, tile));
            tempControlList.AddRange(this.m_MoveControler.AddElementToScreen(SimulatorConfiguration.SickNumber, Properties.Resources.red, tile));
            tempControlList.AddRange(this.m_MoveControler.AddElementToScreen(SimulatorConfiguration.CarryNumber, Properties.Resources.orange, tile));
            tempControlList.AddRange(this.m_MoveControler.AddElementToScreen(SimulatorConfiguration.NumOfInspectors, Properties.Resources.violet, tile));
            ControlsArray = tempControlList.ToArray();
            foreach (var control in ControlsArray)
            {
                this.splitContainer2.Panel2.Controls.Add(control);
            }
        }
        /*
        private void createTypesOfElement(int i_NumberOfTypes, Bitmap i_Color)
        {
            PictureBox tempTile;
            int panellRange = k_StartingLeft + SimulatorConfiguration.Bound * (m_TileSize + k_SpaceBetweenTiles) - k_SpaceBetweenTiles;
            Random rangeRnd = new Random();
            for (int i = 0; i < i_NumberOfTypes; i++)
            {
                tempTile = new PictureBox();
                tempTile.Visible = true;
                tempTile.Width = m_TileSize;
                tempTile.Height = m_TileSize;
                tempTile.Tag = m_TileIndex++;
                tempTile.Top = rangeRnd.Next(panellRange);

                tempTile.Left = rangeRnd.Next(panellRange);

                tempTile.SizeMode = PictureBoxSizeMode.StretchImage;
                tempTile.Image = i_Color;
                this.splitContainer2.Panel2.Controls.Add(tempTile);
            }
        }
*/
        private void SimulatorForm_Load(object sender, EventArgs e)
        {
            init();
        }
    }
}
