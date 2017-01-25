using System;
using NUnit.Framework;

namespace UnitTestingHomework
{
    [TestFixture]
    public class AbsNUnitTests:BaseTest
    {
        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(1)]
        [TestCase(int.MaxValue)]
        public void AbsIntNumbersTest(int num)
        {
            Assert.AreEqual(Math.Abs(num), calculator.Abs(num));
        }

        [TestCase(0)]
        [TestCase(-127)]
        [TestCase(127)]
        public void AbsByteNumbersTest(sbyte num)
        {
            Assert.AreEqual(Math.Abs(num), calculator.Abs(num));
        }

        [TestCase(16.354e-17)]
        [TestCase(15.098123)]
        [TestCase(-19.069713)]
        [TestCase(double.MaxValue)]
        [TestCase(double.MinValue)]
        public void AbsDoubleNumbersTest(double num)
        {
            Assert.AreEqual(Math.Abs(num), calculator.Abs(num));
        }

        [TestCase(-3187.09f)]
        [TestCase(float.MaxValue)]
        [TestCase(float.MinValue)]
        public void AbsFloatNumbersTest(float num)
        {
            Assert.AreEqual(Math.Abs(num), calculator.Abs(num));
        }

        [TestCase("0")]
        [TestCase("4743")]
        [TestCase("-7986")]
        [TestCase("-4.743")]
        public void AbsStringNumbersTest(string num)
        {
            double parsedNum;
            double.TryParse(num, out parsedNum);
            Assert.AreEqual(Math.Abs(parsedNum), calculator.Abs(num));
        }

    }
}
