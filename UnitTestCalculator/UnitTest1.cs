using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        #region testing Add method
        [TestMethod]
        public void TestAdd()
        {
            NonScientific ncalc = new NonScientific();
            decimal expected = 4;
            decimal actual = ncalc.Add(2, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddNegativeResult()
        {
            NonScientific ncalc = new NonScientific();
            decimal expected = -1;
            decimal actual = ncalc.Add(2, -3);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddZero()
        {
            NonScientific ncalc = new NonScientific();
            decimal expected = 2;
            decimal actual = ncalc.Add(2, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddSmallNumber()
        {
            NonScientific ncalc = new NonScientific();
            decimal expected = 2.000001m;
            decimal actual = ncalc.Add(2, 0.000001m);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestAddLargeNumber()
        {
            NonScientific ncalc = new NonScientific();
            decimal expected = 1000002;
            decimal actual = ncalc.Add(2, 1000000m);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region testing Subtract method
        [TestMethod]
        public void TestSubtractSmallNumbers()
        {
            NonScientific n = new NonScientific();
            decimal expected = 2;
            decimal actual = n.Subtract(4, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractSameNumbers()
        {
            NonScientific n = new NonScientific();
            decimal expected = 0;
            decimal actual = n.Subtract(4, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractNegativeNumbers()
        {
            NonScientific n = new NonScientific();
            decimal expected = -3;
            decimal actual = n.Subtract(-4, -1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractLargeNumbers()
        {
            NonScientific n = new NonScientific();
            decimal expected = 999000000001;
            decimal actual = n.Subtract(1000000000000, 999999999);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubstractNegativeAndPositive()
        {
            NonScientific n = new NonScientific();
            decimal expected = -16;
            decimal actual = n.Subtract(-12, 4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractPositiveAndNegative()
        {
            NonScientific n = new NonScientific();
            decimal expected = 16;
            decimal actual = n.Subtract(12, -4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractZeroAndNumber()
        {
            NonScientific n = new NonScientific();
            decimal expected = -5;
            decimal actual = n.Subtract(0, 5);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSubtractNumberAndZero()
        {
            NonScientific n = new NonScientific();
            decimal expected = 4;
            decimal actual = n.Subtract(4, 0);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region testing Multiply method
        [TestMethod]
        public void TestMultiplyZero()
        {
            NonScientific n = new NonScientific();
            decimal expected = 0;
            decimal actual = n.Multiply(2, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyNegative()
        {
            NonScientific n = new NonScientific();
            decimal expected = -4;
            decimal actual = n.Multiply(2, -2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMultiplyNegatives()
        {
            NonScientific n = new NonScientific();
            decimal expected = 6;
            decimal actual = n.Multiply(-3, -2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMultiplyLarge()
        {
            NonScientific n = new NonScientific();
            decimal expected = 4000000;
            decimal actual = n.Multiply(2000000, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMultiplyZeros()
        {
            NonScientific n = new NonScientific();
            decimal expected = 0;
            decimal actual = n.Multiply(0, 0);
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region testing Divide method
        [TestMethod]
        public void TestDivide()
        {
            NonScientific ncalc = new NonScientific();
            decimal expected = 1;
            decimal actual = ncalc.Divide(2, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void TestDivideByZero()
        {
            NonScientific ncalc = new NonScientific();
            decimal expected = 0;
            decimal actual = ncalc.Divide(2, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivideBySmallNumber()
        {
            NonScientific ncalc = new NonScientific();
            decimal expected = 20000000;
            decimal actual = ncalc.Divide(2, 0.0000001m);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivideByLargeNumber()
        {
            NonScientific ncalc = new NonScientific();
            decimal expected = 0.000002m;
            decimal actual = ncalc.Divide(2, 1000000m);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDivideByNegative()
        {
            NonScientific ncalc = new NonScientific();
            decimal expected = -3m;
            decimal actual = ncalc.Divide(6, -2);
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
