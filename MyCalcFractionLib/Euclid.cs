using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcFractionLib
{
    public class Euclid
    {
        //public static int Altogether(int x, int y)
        //{
        //    int countWhole = 0;
        //    while (x>y)
        //    {
        //        countWhole++;
        //        x = x - y;
        //    }
        //    return countWhole;
        //}

        public static int Altogether(ref int x, ref int y)
        {
            int countWhole = 0;
            int newX = x;
            int newY = y;
            while (newX > newY)
            {
                countWhole++;//нахождение целого
                newX = newX - newY;
            }

            while (newY > newX)
            {
                newY = newY - newX;//нахождение общего делителя
            }
            x = x / newY;
            y = y / newY;
            return countWhole;
        }

        public int GetGCD(int a, int b)
        {
        while (a > 0 && b > 0)
            {
            if (a > b)
                a = a % b;
            else
                b = b % a;
            }
        return a + b;
        }
    }
}
