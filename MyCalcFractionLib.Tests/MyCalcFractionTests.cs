using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCalcFractionLib.Tests
{
    [TestClass]
    public class MyCalcFractionTests
    {
        [TestMethod]
        public void Sum1_2and1_2return4_4()
        {
            //arrange
            Fraction expected=new Fraction(-1,2);

            //act
            Fraction a = new Fraction(1,-1);
            Fraction b = new Fraction(1,2);
            Fraction c = Fraction.Add(a, b);

            //assert
            Assert.AreEqual(expected,c);
        }

        [TestMethod]
        public void ZeroDenumThrowEx()
        {
            //arrange

            //act
            bool isTestFailed = true;
            try
            {
                Fraction f = new Fraction(1, 0);
            }
            catch (Exception)
            {
                isTestFailed = false;
            }

            if (isTestFailed)
            {
                Assert.Fail();
            }
        }
            //try
            //{
            //    Fraction a = new Fraction(1, 1);
            //    Assert.Fail();
            //}
            //catch (AssertFailedException) { throw; }
            //catch (Exception)
            //{

            //}
            //assert

        [TestMethod]
        public void Min1_2and1_2return0_4()
        {
            //arrange
            Fraction expected = new Fraction(0, 4);

            //act
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(1, 2);
            Fraction c = Fraction.Minus(a, b);

            //assert
            Assert.AreEqual(expected, c);
        }

        [TestMethod]
        public void Multi1_2and1_2return1_4()
        {
            //arrange
            Fraction expected = new Fraction(-1, 4);

            //act
            Fraction a = new Fraction(1, -2);
            Fraction b = new Fraction(1, 2);
            Fraction c = Fraction.Multiply(a, b);

            //assert
            Assert.AreEqual(expected, c);
        }

        [TestMethod]
        public void Division1_2and1_2return2_2()
        {
            //arrange
            Fraction expected = new Fraction(-10, 6);

            //act
            Fraction a = new Fraction(2, -3);
            Fraction b = new Fraction(2, 5);
            Fraction c = Fraction.Division(a, b);

            //assert
            Assert.AreEqual(expected, c);
        }
        
        [TestMethod]
        public void GetGCD1071and462return2()
        {
            //arrange
            int x = 1071;
            int y = 462;
            int expected = 21;

            //act
            int actual = Euclid.GetGCD(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindIntegerPatr1071and462return2()
        {
            //arrange
            int expected = 2;

            //act
            Fraction c = new Fraction(1071,462);
            int actual = c.FindIntegerPart();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FractionInConctructor2and4return1and2()
        {
            //arrange
            Fraction f = new Fraction(2,4);

            //act

            //assert
            Assert.AreEqual(f.X, 1);
            Assert.AreEqual(f.Y, 2);
        }

        [TestMethod]//тест перегрузки
        public void Add2_3and1_2return7_6()
        {
            //arrange
            Fraction expected = new Fraction(7, 6);


            //act
            Fraction a = new Fraction(2, 3);
            Fraction b = new Fraction(1, 2);
            Fraction c = a + b;

            //assert
            Assert.AreEqual(expected, c);
        }
    }
}
