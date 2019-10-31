using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcFractionLib
{
    public class Euclid
    {
        public static int GetGCD(int x, int y)
        {
            while (x > 0 && y > 0)
            {
                if (x > y)
                    x = x % y;
                else
                    y = y % x;
            }

            return x + y;
        }
    }
}
