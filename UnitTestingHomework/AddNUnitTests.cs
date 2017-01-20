using System;
using NUnit.Framework;

namespace UnitTestingHomework
{
    [TestFixture]
    public class AddNUnitTests:BaseTest
    {
        [TestCase(0, 0)]
        [TestCase(-1, -1)]
        [TestCase(100, 200)]
        public void AddIntNumbersTest(int num1, int num2)
        {
            Assert.AreEqual(calculator.Add(num1, num2), (num1 + num2));
        }

        [TestCase(0, 5)]
        public void AddByteNumbersTest(sbyte num1, sbyte num2)
        {
            Assert.AreEqual(calculator.Add(num1, num2), (num1 + num2));
        }

        [TestCase(7.9, -7.3)]
        [TestCase(16.354e-17, 1.87e-5)]
        [TestCase(15.098123, 5.7884)]
        [TestCase(double.MaxValue, 56.87686)]
        [TestCase(double.MinValue, -56.87686)]
        public void AddDoubleNumbersTest(double num1, double num2)
        {
            Assert.AreEqual(calculator.Add(num1, num2), (num1 + num2));
        }

        [TestCase(-3187.09f, 868.69f)]
        [TestCase(float.MaxValue, -567.8f)]
        [TestCase(float.MinValue, 686.890f)]
        public void AddFloatNumbersTest(float num1, float num2)
        {
            Assert.AreEqual(calculator.Add(num1, num2), (num1 + num2));
        }

        [TestCase("0", "87")]
        [TestCase("4743", "8.67")]
        [TestCase("-7986.89", "86.79")]
        public void AddStringNumbersTest(string num1, string num2)
        {
            double parsedNum1, parsedNum2;

            if (double.TryParse(num1, out parsedNum1) && double.TryParse(num2, out parsedNum2))
                Assert.AreEqual(calculator.Add(num1, num2), (parsedNum1 + parsedNum2));
            else
                Assert.Fail("Unable to parse input values to double");
        }
    }
}
