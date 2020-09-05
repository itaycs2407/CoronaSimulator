using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaSimulator
{
    public class ItemUtils
    {

        public static int getRandomCordInRangeMatrix(int i_Bound)
        {
            Random rangeRnd = new Random();
            return rangeRnd.Next(i_Bound);
        }
    }
}
