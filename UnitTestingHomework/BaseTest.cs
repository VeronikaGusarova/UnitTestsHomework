using System;
using NUnit.Framework;
using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestingHomework
{
    [TestFixture]
    [TestClass]
    public class BaseTest
    {
        protected Calculator calculator;

        [SetUp]
        [TestInitialize]
        public void SetUp()
        {
            calculator = new Calculator();
        }
    }
}
