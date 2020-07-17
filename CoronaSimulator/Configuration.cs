using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CoronaSimulator
{
    public class Configuration
    {
        private int m_NumOfInspectors = 0;
        private int m_Bound = 10;
        private int m_Tick = 1000;
        private int m_DistanceToBecomeCarrying = 1;
        private int m_stepDistance = 1;
        private int m_HealtyNumbe = 5;
        private int m_SickNumber = 10;
        private int m_CarryNumber = 10;

        public int NumOfInspectors { get => m_NumOfInspectors; set => m_NumOfInspectors = value; }
        public int Bound { get => m_Bound; set => m_Bound = value; }
        public int Tick { get => m_Tick; set => m_Tick = value; }
        public int DistanceToBecomeCarrying { get => m_DistanceToBecomeCarrying; set => m_DistanceToBecomeCarrying = value; }
        public int StepDistance { get => m_stepDistance; set => m_stepDistance = value; }
        public int HealtyNumber { get => m_HealtyNumber; set => m_HealtyNumber = value; }
        public int SickNumber { get => m_SickNumber; set => m_SickNumber = value; }
        public int CarryNumber { get => m_CarryNumber; set => m_CarryNumber = value; }
        public int HealtyNumbe { get => m_HealtyNumbe; set => m_HealtyNumbe = value; }
    }
}
