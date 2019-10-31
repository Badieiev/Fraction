using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcFractionLib
{
    public class Fraction
    {
        private int x, y;
        public int X { get { return x; }}
        public int Y { get { return y; }}
        public Fraction() { }
        public Fraction(int x_, int y_)
        {
            this.x = x_;
            this.y = y_;

            if (y == 0)
            {
                Exception ex = new Exception("Знаменатель не может быть 0");
                throw ex;
            }

            if (y<0)    //нужно проверять на отрицательные числа?
            {
                this.x = -x;
                this.y = Math.Abs(y);
            }

            int GCD = Euclid.GetGCD(Math.Abs(x), Math.Abs(y)); 
            this.y = y / GCD;
            this.x = this.x / GCD;
        }

        public int FindIntegerPart()
        {
            return this.x / this.y;
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

        public override int GetHashCode()
        {
            int hash = 3;
            hash = (hash * 7) + x.GetHashCode();
            hash = (hash * 7) + y.GetHashCode();
            return hash;
        }

        //public Fraction Add(Fraction oth)
        //{
        //    int newNumerator = this.x * oth.y + this.y * oth.x;
        //    int newDenumerator = this.y * oth.y;
        //    return new Fraction(newNumerator, newDenumerator);
        //}
    }
}
