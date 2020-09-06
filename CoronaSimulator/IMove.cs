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
        void GenrateMove(ref Cell[,] io_Grid);
        void CreateElements(ref Cell [,] io_Grid);
    }
}
