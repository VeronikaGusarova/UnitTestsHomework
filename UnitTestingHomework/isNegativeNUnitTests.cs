using System;
using NUnit.Framework;

namespace UnitTestingHomework
{
    [TestFixture]
    public class IsNegativeNUnitTests:BaseTest
    {
        [TestCase(0)]
        [TestCase(-19646456)]
        [TestCase(8674654)]
        [TestCase(int.MaxValue)]
        [TestCase(int.MinValue)]
        public void IsNegativeIntNumbersTest(int num)
        {
            if (num <= 0)
                Assert.IsTrue(calculator.isNegative(num));
            else
                Assert.IsFalse(calculator.isNegative(num)); 
        }

        [TestCase(-127)]
        [TestCase(127)]
        public void IsNegativeByteNumbersTest(sbyte num)
        {
            if (num <= 0)
                Assert.IsTrue(calculator.isNegative(num));
            else
                Assert.IsFalse(calculator.isNegative(num));
        }

        [TestCase(16.354e-17)]
        [TestCase(15.098123)]
        [TestCase(-19.069713)]
        [TestCase(double.MaxValue)]
        [TestCase(double.MinValue)]
        public void IsNegativeDoubleNumbersTest(double num)
        {
            if (num <= 0)
                Assert.IsTrue(calculator.isNegative(num));
            else
                Assert.IsFalse(calculator.isNegative(num));
        }

        [TestCase(3187.09f)]
        [TestCase(-3187.09f)]
        [TestCase(float.MaxValue)]
        [TestCase(float.MinValue)]
        public void IsNegativeFloatNumbersTest(float num)
        {
            if (num <= 0)
                Assert.IsTrue(calculator.isNegative(num));
            else
                Assert.IsFalse(calculator.isNegative(num));
        }

        [TestCase("0")]
        [TestCase("4743")]
        [TestCase("-7986")]
        [TestCase("-4.743")]
        public void IsNegativeStringNumbersTest(string num)
        {
            double parsedNum;

            if (double.TryParse(num, out parsedNum))
            {
                if (parsedNum <= 0)
                    Assert.IsTrue(calculator.isNegative(num));
                else
                    Assert.IsFalse(calculator.isNegative(num));
            }
            else
                Assert.Fail("Unable to parse input value '{0}' to double", num);
        }
    }
}
