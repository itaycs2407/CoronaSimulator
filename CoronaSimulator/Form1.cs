using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaSimulator
{
    public partial class Form1 : Form
    {
        public Controller m_Control = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            saveSettings();
        }

        private void LoadSettings()
        {
            numericCarry.Value = m_Control.Config.CarryNumber;
            numericFieldSize.Value = m_Control.Config.Bound;
            numericHealty.Value = m_Control.Config.HealtyNumber;
            numericSick.Value = m_Control.Config.SickNumber;
            numericTick.Value = m_Control.Config.Tick;
        }

        private void saveSettings()
        {
            m_Control.Config.CarryNumber = (int)numericCarry.Value;
            m_Control.Config.Bound = (int)numericFieldSize.Value;
            m_Control.Config.HealtyNumber = (int)numericHealty.Value;
            m_Control.Config.SickNumber = (int)numericSick.Value;
            m_Control.Config.Tick = (int)numericTick.Value;
        }

        private void numericHealty_ValueChanged(object sender, EventArgs e)
        {
            if (checkSimulatorLimit())
            {
                (sender as NumericUpDown).Value = m_Control.Config.HealtyNumber;
            }
        }

        private bool checkSimulatorLimit()
        {
            int fieldCapacity = (int)(numericFieldSize.Value * numericFieldSize.Value);
            bool isValidNumber = fieldCapacity >= numericCarry.Value + numericHealty.Value + numericSick.Value;
            if (!isValidNumber)
            {
                MessageBox.Show("Number of persons on fields exceed its limits.","Warning", MessageBoxButtons.OK);
            }
            return !isValidNumber;
        }

        private void numericSick_ValueChanged(object sender, EventArgs e)
        {
            if (checkSimulatorLimit())
            {
                (sender as NumericUpDown).Value = m_Control.Config.SickNumber;
            }
        }

        private void numericCarry_ValueChanged(object sender, EventArgs e)
        {
            if (checkSimulatorLimit())
            {
                (sender as NumericUpDown).Value = m_Control.Config.CarryNumber;
            }
        }

        private void numericFieldSize_ValueChanged(object sender, EventArgs e)
        {
            if (checkSimulatorLimit())
            {
                (sender as NumericUpDown).Value = m_Control.Config.Bound;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
