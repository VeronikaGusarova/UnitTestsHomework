using System;
using NUnit.Framework;

namespace UnitTestingHomework.NunitTests
{
    [TestFixture]
    public class CosTests : BaseTest
    {
        [TestCase(0)]
        [TestCase(-19646456)]
        [TestCase(8674654)]
        [TestCase(int.MaxValue)]
        [TestCase(int.MinValue)]
        public void CosIntNumbersTest(int num)
        {
            Assert.AreEqual(Math.Cos(num), calculator.Cos(num));
        }

        [TestCase(-127)]
        [TestCase(127)]
        public void CosByteNumbersTest(sbyte num)
        {
            Assert.AreEqual(Math.Cos(num), calculator.Cos(num));
        }

        [TestCase(16.354e-17)]
        [TestCase(15.098123)]
        [TestCase(-19.069713)]
        [TestCase(double.MaxValue)]
        [TestCase(double.MinValue)]
        public void CosDoubleNumbersTest(double num)
        {
            Assert.AreEqual(Math.Cos(num), calculator.Cos(num));
        }

        [TestCase(-3187.09f)]
        [TestCase(float.MaxValue)]
        [TestCase(float.MinValue)]
        public void CosFloatNumbersTest(float num)
        {
            Assert.AreEqual(Math.Cos(num), calculator.Cos(num));
        }

        [TestCase("0")]
        [TestCase("4743")]
        [TestCase("-7986.898")]
        [TestCase("-4.743")]
        public void CosStringNumbersTest(string num)
        {
            double parsedNum;
            double.TryParse(num, out parsedNum);
            Assert.AreEqual(Math.Cos(parsedNum), calculator.Cos(num));
        }
    }
}
