using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingHomework
{
    [TestClass]
    public class MultiplyMSTests:BaseTest
    {
        [TestMethod]
        [TestCategory("int numbers")]
        public void MultiplyIntNumbersZeroTest()
        {
            int num1 = 0;
            int num2 = 7;
            Assert.AreEqual(num1 * num2, calculator.Multiply(num1, num2));
        }

        [TestMethod]
        [TestCategory("int numbers")]
        public void MultiplyIntNumbersNegativeTest()
        {
            int num1 = -4;
            int num2 = 7;
            Assert.AreEqual(num1 * num2, calculator.Multiply(num1, num2));
        }

        [TestMethod]
        [TestCategory("sbyte numbers")]
        public void MultiplyByteNumbersTest()
        {
            sbyte num1 = -7;
            sbyte num2 = 23;
            Assert.AreEqual(num1 * num2, calculator.Multiply(num1, num2));
        }

        [TestMethod]
        [TestCategory("double numbers")]
        public void MultiplyDoubleNumbersTest()
        {
            Tuple<double, double>[] pairs = {
                new Tuple<double, double>(-5.656, 56.656),
                new Tuple<double, double>(16.354e-17, 1.87e-5)
            };
            foreach(var num in pairs)
                Assert.AreEqual(num.Item1 * num.Item2, calculator.Multiply(num.Item1, num.Item2));
        }

        [TestMethod]
        [TestCategory("float numbers")]
        public void MultiplyFloatNumbersTest()
        {
            Tuple<float, float>[] pairs = {
                new Tuple<float, float>(-3187.09f, 868.69f),
                new Tuple<float, float>(16.354e-17f, 6.876f)
            };
            foreach (var num in pairs)
            {
                Assert.AreEqual(Convert.ToDouble(num.Item1) * Convert.ToDouble(num.Item2), calculator.Multiply(num.Item1, num.Item2));
            }               
        }

        [TestMethod]
        [TestCategory("mixed numbers")]
        public void MultiplyMixedNumbersTest()
        {
            Tuple<double, float>[] pairs = {
                new Tuple<double, float>(-3187.098076, 868.69f),
                new Tuple<double, float>(16.354e-17, 6.876f)
            };
            foreach (var num in pairs)
            {
                Assert.AreEqual(num.Item1 * Convert.ToDouble(num.Item2), calculator.Multiply(num.Item1, num.Item2));
            }
        }

    }
}
