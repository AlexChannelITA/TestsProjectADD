using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcolatriceLybrary;
using System;

namespace TestCalcolatrice
{
    [TestClass]
    public class UnitTestCalcolatrice
    {
        [TestMethod]
        public void TestSomma()
        {
            int[] addendi = { 2, 3, 4 };
            int epected = 9;

            var calc = new Calcolatrice();
            int result = calc.Somma(addendi);

            Assert.AreEqual(epected, result);
        }

        public void TestSommaNull()
        {
            int[] addendi = null;

            Exception expected = null;

            Calcolatrice sum = new Calcolatrice();

            try
            {
                sum.Somma(addendi);
            }
            catch
            {
                expected = new ArgumentException();
            }

            Assert.IsNotNull(expected);
        }
    }
}
