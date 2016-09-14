using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals_TDD_01;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_I()
        {
            int value = RomanNumerals.ParseRomanNumeral("I");
            Assert.AreEqual(1, value);
        }
    }
}
