using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaSimulator
{
    public class ItemUtils
    {

        public static bool isOnTop(int i_Top, int i_Left, int i_SideSize, List<Tuple<int, int>> m_ElementCord)
        {
            bool result = false;
            for (int i = 0; i < m_ElementCord.Count && !result; i++)
            {
                Tuple<int, int> t = m_ElementCord[i];
                if (!result)
                {
                    result = (((i_Top + i_SideSize >= t.Item1) && (i_Top + i_SideSize <= t.Item1 + i_SideSize)) || ((i_Left + i_SideSize >= t.Item2) && (i_Left + i_SideSize <= t.Item2 + i_SideSize)));
                    result = result || (((i_Top >= t.Item1) && (i_Top <= t.Item1 + i_SideSize)) || ((i_Left >= t.Item2) && (i_Left <= t.Item2 + i_SideSize)));
                }
            }
            return result;
        }
        public static int getRandomCordInRangeFreeFlow(int i_PanellRange, int i_TileSize)
        {
            Random rangeRnd = new Random();
            int result = rangeRnd.Next(i_PanellRange);
            while (result > i_PanellRange - i_TileSize)
            {
                result = rangeRnd.Next(i_PanellRange);
            }
            return result;
        }

        public static int getRandomCordInRangeMatrix(int i_Bound)
        {
            Random rangeRnd = new Random();
            return rangeRnd.Next(i_Bound);
        }
    }
}
