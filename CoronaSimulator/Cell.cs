using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaSimulator
{
    public class Cell 
    {
        private int m_ID = 0;
        private float m_BodyHeat;
        private eStatus m_Status;
        private bool k_IsIsolated = !true;
        public Bitmap Color { get; set; }
        public Cell(int i_ID, float i_BodyHeat, eStatus i_InitStatus)
        {
            this.ID = i_ID;
            this.BodyHeat = i_BodyHeat;
            this.Status = i_InitStatus;
            this.Color = null;
           
        }

       
        public int ID { get => m_ID; set => m_ID = value; }
        public float BodyHeat { get => m_BodyHeat; set => m_BodyHeat = value; }
        public eStatus Status { get => m_Status; set => m_Status = value; }
        public bool K_IsIsolated { get => k_IsIsolated; set => k_IsIsolated = value; }
    }
}


