using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Formulas
    {
        public Int32 GetGrayLevel(Int32 pl_level)
        {
            if(pl_level <= 5)
            {
                return 0;
            }
            else if(pl_level <= 39)
            {
                return pl_level - 5 - pl_level / 10;
            }
            // Over 39
            else
            {
                return pl_level - 1 - pl_level / 5;
            }
        }


        public Int32 GetZeroDifference(Int32 pl_level)
        {
            if (pl_level < 8) return 5;
            if (pl_level < 10) return 6;
            if (pl_level < 12) return 7;
            if (pl_level < 16) return 8;
            if (pl_level < 20) return 9;
            if (pl_level < 30) return 11;
            if (pl_level < 40) return 12;
            if (pl_level < 45) return 13;
            if (pl_level < 50) return 14;
            if (pl_level < 55) return 15;
            if (pl_level < 60) return 16;
            return 17;
        }
    }
}
