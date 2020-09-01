using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaSimulator
{
    public interface IMove
    {
        void setConfiguration(Configuration i_Config);
        int[] GenrateMove();
        System.Windows.Forms.Control[] AddElementToScreen(int i_NumberOfTypes, Bitmap i_Color, Tile i_Tile);
    }
}
