using System;
using NUnit.Framework;

namespace UnitTestingHomework.NunitTests
{
    [TestFixture]
    public class DivideTests:BaseTest
    {
        [TestCase(8, 3)]
        [TestCase(-5, -6)]
        [TestCase(654, -7)]
        [TestCase(100, 0)]
        [TestCase(0, 0)]
        public void DivideIntNumbersTest(int num1, int num2)
        {
            Assert.AreEqual(Convert.ToDouble(num1) / Convert.ToDouble(num2), calculator.Divide(num1, num2));
        }

        [TestCase(7, 5)]
        public void DivideByteNumbersTest(sbyte num1, sbyte num2)
        {
            Assert.AreEqual(Convert.ToDouble(num1) / Convert.ToDouble(num2), calculator.Divide(num1, num2));
        }

        [TestCase(7.9, -7.3)]
        [TestCase(16.354e-17, 1.87e-5)]
        [TestCase(15.098123, 5.7884)]
        [TestCase(double.MaxValue, 56.87686)]
        [TestCase(double.MinValue, -56.87686)]
        public void DivideDoubleNumbersTest(double num1, double num2)
        {
            Assert.AreEqual(Convert.ToDouble(num1) / Convert.ToDouble(num2), calculator.Divide(num1, num2));
        }

        [TestCase(-3187.09f, 868.69f)]
        [TestCase(float.MaxValue, -567.8f)]
        [TestCase(float.MinValue, 686.890f)]
        public void DivideFloatNumbersTest(float num1, float num2)
        {
            Assert.AreEqual(Convert.ToDouble(num1) / Convert.ToDouble(num2), calculator.Divide(num1, num2));
        }

    }
}
