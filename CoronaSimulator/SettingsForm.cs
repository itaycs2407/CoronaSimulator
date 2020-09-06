using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoronaSimulator
{
    public partial class SettingsForm : Form
    {
        public Controller m_Control = null;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadSettings();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            saveSettings();
            this.Close();
        }

        private void LoadSettings()
        {
            numericCarry.Value = m_Control.Config.CarryNumber;
            numericFieldSize.Value = m_Control.Config.Bound;
            numericHealty.Value = m_Control.Config.HealtyNumber;
            numericSick.Value = m_Control.Config.SickNumber;
            numericTick.Value = m_Control.Config.Tick;
            //TODO: fetch the data from config
            zeroAllStatistics();
        }

        private void zeroAllStatistics()
        {
            FirstScroll.Text = SecondScroll.Text = ThirdScroll.Text = ForthScroll.Text =convertInt2Float(hScrollBar1).ToString();
        }

        private void saveSettings()
        {
            Configuration savedConfiguration = new Configuration();

            savedConfiguration.CarryNumber = (int)numericCarry.Value;
            savedConfiguration.Bound = (int)numericFieldSize.Value;
            savedConfiguration.HealtyNumber = (int)numericHealty.Value;
            savedConfiguration.SickNumber = (int)numericSick.Value;
            savedConfiguration.Tick = (int)numericTick.Value;
            savedConfiguration.IncludeCenters = checkBoxIncludeCenters.Checked;
            savedConfiguration.NumberOfCenters = 0;
            savedConfiguration.CentersSize = 0;
            if (savedConfiguration.IncludeCenters)
            {
                savedConfiguration.NumberOfCenters = (int)numericNumOfCenters.Value;
                savedConfiguration.CentersSize = (int)numericCentersSize.Value;
            }
            savedConfiguration.StepType = "Matrix";
      
            float.TryParse(FirstScroll.Text, out float s1);
            float.TryParse(SecondScroll.Text, out float s2);
            float.TryParse(ThirdScroll.Text, out float s3);
            float.TryParse(ForthScroll.Text, out float s4);
            savedConfiguration.Statistics1 = s1;
            savedConfiguration.Statistics2 = s2;
            savedConfiguration.Statistics3 = s3;
            savedConfiguration.Statistics4 = s4;

            m_Control.Config = savedConfiguration;
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

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            FirstScroll.Text = convertInt2Float(sender).ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            SecondScroll.Text = convertInt2Float(sender).ToString();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            ThirdScroll.Text = convertInt2Float(sender).ToString();
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            ForthScroll.Text = convertInt2Float(sender).ToString();
        }

        private float convertInt2Float(object sender)
        {
            string currenValueSTR = (sender as HScrollBar).Value.ToString();
            float currentValueFloat;
            float.TryParse(currenValueSTR, out currentValueFloat);
            return currentValueFloat /= 100;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool isEnabeled = checkBoxIncludeCenters.Checked;
            numericCentersSize.Enabled = isEnabeled;
            numericNumOfCenters.Enabled = isEnabeled;
            if (!isEnabeled)
            {
                numericCentersSize.Value = numericNumOfCenters.Value = 0;
            }
        }


        
    }
}
