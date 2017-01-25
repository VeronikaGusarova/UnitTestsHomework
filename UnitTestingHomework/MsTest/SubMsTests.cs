using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingHomework
{
    [TestClass]
    public class SubMSTests:BaseTest
    {
        [TestMethod]
        [TestCategory("int numbers")]
        public void SubIntNumbersTest()
        {
            Tuple<int, int>[] pairs = {
                new Tuple<int, int>(6, -4),
                new Tuple<int, int>(-8, 2),
                new Tuple<int, int>(8, 2),
            };
            foreach (var num in pairs)
                Assert.AreEqual(num.Item1 - num.Item2, calculator.Sub(num.Item1, num.Item2));
        }

        [TestMethod]
        [TestCategory("double numbers")]
        public void SubDoubleNumbersTest()
        {
            Tuple<double, double>[] pairs = {
                new Tuple<double, double>(-6.87687, 4.7878),
                new Tuple<double, double>(16.354e-17, -2.779),
                new Tuple<double, double>(16.354e-17, 89.892)
            };
            foreach (var num in pairs)
                Assert.AreEqual(num.Item1 - num.Item2, calculator.Sub(num.Item1, num.Item2));
        }

        [TestMethod]
        [TestCategory("float numbers")]
        public void SubFloatNumbersTest()
        {
            Tuple<float, float>[] pairs = {
                new Tuple<float, float>(2.787f, 2.7f),
                new Tuple<float, float>(16.354e-17f, -2.89f)
            };
            foreach (var num in pairs)
                Assert.AreEqual(num.Item1 - num.Item2, calculator.Sub(num.Item1, num.Item2));
        }

        [TestMethod]
        [TestCategory("string numbers")]
        public void SubStringNumbersTest()
        {
            Tuple<string, string>[] pairs = {
                new Tuple<string, string>("6", "-4"),
                new Tuple<string, string>("-8.8987", "2")
            };
            foreach (var num in pairs)
                Assert.AreEqual(Convert.ToDouble(num.Item1) - Convert.ToDouble(num.Item2), calculator.Sub(num.Item1, num.Item2));
        }

        [TestMethod]
        [TestCategory("mixed numbers")]
        public void SubMixedNumbersTest()
        {
            Tuple<int, double>[] pairs = {
                new Tuple<int, double>(6, 8),
                new Tuple<int, double>(-8, 8.7)
            };
            foreach (var num in pairs)
                Assert.AreEqual(num.Item1 - num.Item2, calculator.Sub(num.Item1, num.Item2));
        }

        [TestMethod]
        [TestCategory("mixed numbers")]
        public void SubMixedNumbersTest2()
        {
            Tuple<double, int>[] pairs = {
                new Tuple<double, int>(6.89, 8),
                new Tuple<double, int>(-8.89, 7)
            };
            foreach (var num in pairs)
                Assert.AreEqual(num.Item1 - num.Item2, calculator.Sub(num.Item1, num.Item2));
        }

        [TestMethod]
        [TestCategory("mixed numbers")]
        public void SubMixedNumbersTest3()
        {
            Tuple<float, double>[] pairs = {
                new Tuple<float, double>(6.89f, 8.78),
                new Tuple<float, double>(-8.89f, 7.687)
            };
            foreach (var num in pairs)
                Assert.AreEqual(num.Item1 - num.Item2, calculator.Sub(num.Item1, num.Item2));
        }

        [TestMethod]
        [TestCategory("mixed numbers")]
        public void SubMixedNumbersTest4()
        {
            Tuple<double, float>[] pairs = {
                new Tuple<double, float>(6.89, 8.78f),
                new Tuple<double, float>(-8.89797976, 7.97f)
            };
            foreach (var num in pairs)
                Assert.AreEqual(num.Item1 - num.Item2, calculator.Sub(num.Item1, num.Item2));
        }

    }
}
