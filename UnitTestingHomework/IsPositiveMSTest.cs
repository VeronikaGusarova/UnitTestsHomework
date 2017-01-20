using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingHomework
{
    [TestClass]
    public class IsPositiveMSTest:BaseTest
    {
        [TestMethod]
        [TestCategory("int numbers")]
        public void IsPositiveIntNumbersZeroTest()
        {
            int num = 0;
            Assert.IsFalse(calculator.isPositive(num));
        }

        [TestMethod]
        [TestCategory("int numbers")]
        public void IsPositiveIntNumbersPositiveTest()
        {
            int num = 8674654;
            Assert.IsTrue(calculator.isPositive(num));
        }

        [TestMethod]
        [TestCategory("int numbers")]
        public void IsPositiveIntNumbersNegativeTest()
        {
            int num = -19646456;
            Assert.IsFalse(calculator.isPositive(num));
        }

        [TestMethod]
        [TestCategory("sbyte numbers")]
        public void IsPositiveByteNumbersTest()
        {
            sbyte num = -127;
            Assert.IsFalse(calculator.isPositive(num));
        }

        [TestMethod]
        [TestCategory("double numbers")]
        public void IsPositiveDoubleNumbersSmallPositiveTest()
        {
            double num = 16.354e-17;
            Assert.IsTrue(calculator.isPositive(num));
        }

        [TestMethod]
        [TestCategory("double numbers")]
        public void IsPositiveDoubleNumbersPositiveTest()
        {
            double num = 15.098123;
            Assert.IsTrue(calculator.isPositive(num));
        }

        [TestMethod]
        [TestCategory("double numbers")]
        public void IsPositiveDoubleNumbersNegativeTest()
        {
            double num = -19.069713;
            Assert.IsFalse(calculator.isPositive(num));
        }

        [TestMethod]
        [TestCategory("double numbers")]
        public void IsPositiveDoubleNumbersMaxValueTest()
        {
            double num = double.MaxValue;
            Assert.IsTrue(calculator.isPositive(num));
        }

        [TestMethod]
        [TestCategory("double numbers")]
        public void IsPositiveDoubleNumbersMinValueTest()
        {
            double num = double.MinValue;
            Assert.IsFalse(calculator.isPositive(num));
        }

        [TestMethod]
        [TestCategory("float numbers")]
        public void IsPositiveFloatNumbersPositiveTest()
        {
            float num = 3187.09f;
            Assert.IsTrue(calculator.isPositive(num));
        }

        [TestMethod]
        [TestCategory("float numbers")]
        public void IsPositiveFloatNumbersNegativeTest()
        {
            float num = -3187.09f;
            Assert.IsFalse(calculator.isPositive(num));
        }

        [TestMethod]
        [TestCategory("string numbers")]
        public void IsPositiveStringNegativeTest()
        {
            string num = "-68.89";
            Assert.IsFalse(calculator.isPositive(num));
        }

        [TestMethod]
        [TestCategory("string numbers")]
        public void IsPositiveStringPositiveTest()
        {
            string num = "68.89";
            Assert.IsTrue(calculator.isPositive(num));
        }
    }
}
