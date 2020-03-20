using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestAnQualityLab.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TopNumber_3and4_Minus10returned()
        {
            // arrange
            double a = 3;
            double b = 4;
            double expected = -10;

            // action
            double actual = Program.TopNumber(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BottomNumber_3and4_Minus9returned()
        {
            // arrange
            double a = 3;
            double b = 4;
            double expected = -9;

            // action
            double actual = Program.BottomNumber(a, b);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateResult_Minus10andMinus9_1returned()
        {
            // arrange
            double a = -10;
            double b = -9;
            int expected = 1;

            // action
            int actual = Convert.ToInt32(Program.CalculateResult(a, b));

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
