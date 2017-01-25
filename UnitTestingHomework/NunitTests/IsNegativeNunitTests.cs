using System;
using NUnit.Framework;

namespace UnitTestingHomework
{
    [TestFixture]
    public class IsNegativeNUnitTests:BaseTest
    {
        [TestCase(0)]
        [TestCase(8674654)]
        [TestCase(int.MaxValue)]
        public void IsNegativePositiveIntNumbersTest(int num)
        {
            Assert.IsFalse(calculator.isNegative(num)); 
        }

        [TestCase(-19646456)]
        [TestCase(int.MinValue)]
        public void IsNegativeNegativeIntNumbersTest(int num)
        {
            Assert.IsTrue(calculator.isNegative(num));
        }

        [TestCase(-127)]
        [TestCase(-68)]
        public void IsNegativeByteNegativeNumbersTest(sbyte num)
        {
            Assert.IsTrue(calculator.isNegative(num));
        }

        [TestCase(54)]
        [TestCase(127)]
        public void IsNegativeBytePositiveNumbersTest(sbyte num)
        {
            Assert.IsFalse(calculator.isNegative(num));
        }

        [TestCase(-16.354e-17)]
        [TestCase(-19.069713)]
        [TestCase(double.MinValue)]
        public void IsNegativeDoubleNegativeNumbersTest(double num)
        {
            Assert.IsTrue(calculator.isNegative(num));
        }

        [TestCase(16.354e-17)]
        [TestCase(15.098123)]
        [TestCase(double.MaxValue)]
        public void IsNegativeDoublePositiveNumbersTest(double num)
        {
             Assert.IsFalse(calculator.isNegative(num));
        }

        [TestCase(-3187.09f)]
        [TestCase(float.MinValue)]
        public void IsNegativeFloatNegativeNumbersTest(float num)
        {
             Assert.IsTrue(calculator.isNegative(num));
        }

        [TestCase(3187.09f)]
        [TestCase(float.MaxValue)]
        public void IsNegativeFloatPositiveNumbersTest(float num)
        {
             Assert.IsFalse(calculator.isNegative(num));
        }

        [TestCase("-7986")]
        [TestCase("-4.743")]
        public void IsNegativeStringNegativeNumbersTest(string num)
        {
            double parsedNum;
            double.TryParse(num, out parsedNum);
            Assert.IsTrue(calculator.isNegative(num));
        }

        [TestCase("0")]
        [TestCase("4743")]
        public void IsNegativeStringNumbersTest(string num)
        {
            double parsedNum;
            double.TryParse(num, out parsedNum);
            Assert.IsFalse(calculator.isNegative(num));
        }
    }
}
