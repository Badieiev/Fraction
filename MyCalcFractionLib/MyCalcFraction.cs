﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcFractionLib
{
    public class Fraction
    {
        private int x, y;
        public Fraction() { }
        public Fraction(int x, int y)
        {
            //только числитель может быть отрицательным
           this.x = x;

            if (y == 0)
            {
                Exception ex = new Exception("Знаменатель не может быть 0");
                throw ex;
            }
            if (y<0)
            {
                this.x = -x;
                this.y = Math.Abs(y);
            }
            else
            {
                this.y = y;
            }
        }
        public static Fraction Add(Fraction oth, Fraction els)
        {
            int newNumerator = oth.x * els.y + els.x * oth.y;
            int newDenumerator = oth.y * els.y;
            return new Fraction(newNumerator, newDenumerator);
        }
        public static Fraction Minus(Fraction oth, Fraction els)
        {
            int newNumerator = oth.x * els.y - els.x * oth.y;
            int newDenumerator = oth.y * els.y;
            return new Fraction(newNumerator, newDenumerator);
        }
        public static Fraction Multiply(Fraction oth, Fraction els)
        {
            int newNumerator = oth.x * els.x;
            int newDenumerator = oth.y * els.y;
            return new Fraction(newNumerator, newDenumerator);
        }
        public static Fraction Division(Fraction oth, Fraction els)
        {
            int newNumerator = oth.x * els.y;
            int newDenumerator = oth.y * els.x;
            return new Fraction(newNumerator, newDenumerator);
        }

        public override string ToString()
        {
            return "" + x + "/" + y;
        }
        public override bool Equals(object obj)
        {
            var frac = obj as Fraction;
            if (frac == null)
            {
                return false;
            }
            return frac.x == this.x && frac.y == this.y;
        }



        //public Fraction Add(Fraction oth)
        //{
        //    int newNumerator = this.x * oth.y + this.y * oth.x;
        //    int newDenumerator = this.y * oth.y;
        //    return new Fraction(newNumerator, newDenumerator);
        //}
    }
}