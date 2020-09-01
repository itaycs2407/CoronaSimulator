using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaSimulator
{
    public class Tile
    {

        public int k_StartingCord { get; private set; } = 3;
        public int k_SpaceBetweenTiles { get; private set; } = 1;
        public int m_PanelRange { get; private set; }
        public int m_PanelMinSize { get; private set; }
        public int m_TileSize { get; private set; }
        public int m_Bound { get; private set; }

        public Tile(int i_Bound,int i_PanelMinSize)
        {
            this.m_Bound = i_Bound;
            this.m_PanelMinSize = i_PanelMinSize;
            this.m_TileSize = this.m_PanelMinSize / this.m_Bound;
            this.m_PanelRange = k_StartingCord + m_Bound * (m_TileSize + k_SpaceBetweenTiles) - k_SpaceBetweenTiles;
        }
    }
}
