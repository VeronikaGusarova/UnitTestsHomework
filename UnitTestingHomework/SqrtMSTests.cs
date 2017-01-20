using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingHomework
{
    [TestClass]
    public class SqrtMSTests:BaseTest
    {
        [TestMethod]
        [TestCategory("int numbers")]
        public void SqrtIntNumbersTest()
        {
            int[] values = { 0, -687686, 787876, int.MinValue, int.MaxValue };
            foreach (var num in values)
                Assert.AreEqual(calculator.Sqrt(num), Math.Sqrt(num));
        }

        [TestMethod]
        [TestCategory("double numbers")]
        public void SqrtDoubleNumbersTest()
        {
            double[] values = { 16.354e-17, -78.78768, 24.86776, double.MinValue, double.MaxValue };
            foreach (var num in values)
                Assert.AreEqual(calculator.Sqrt(num), Math.Sqrt(num));
        }

        [TestMethod]
        [TestCategory("sbyte numbers")]
        public void SqrtSbyteNumbersTest()
        {
            sbyte[] values = { 76, -45, sbyte.MinValue, sbyte.MaxValue };
            foreach (var num in values)
                Assert.AreEqual(calculator.Sqrt(num), Math.Sqrt(num));
        }

        [TestMethod]
        [TestCategory("float numbers")]
        public void SqrtFloatNumbersTest()
        {
            float[] values = { 16.354e-17f, -78.78768f, 24.86776f };
            foreach (var num in values)
                Assert.AreEqual(calculator.Sqrt(num), Math.Sqrt(num));
        }

        [TestMethod]
        [TestCategory("string numbers")]
        public void SqrtStringNumbersTestDouble()
        {
            string[] values = { "16.354e-17", "-7879.7978" };
            foreach (var num in values)
                Assert.AreEqual(calculator.Sqrt(num), Math.Sqrt(Convert.ToDouble(num)));
        }

        [TestMethod]
        [TestCategory("string numbers")]
        public void SqrtStringNumbersTestInt()
        {
            string[] values = { "78", "-8" };
            foreach (var num in values)
                Assert.AreEqual(calculator.Sqrt(num), Math.Sqrt(Convert.ToDouble(num)));
        }

    }
}
