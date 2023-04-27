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

        [TestMethod]
        [DataRow(new int[] { 4, 4, 0 }, 8)]
        [DataRow(new int[] { 0, 0, 0 }, 0)]
        [DataRow(new int[] { -4, 4, 0 }, 0)]
        [DataRow(new int[] { 1, 4, 0 }, 5)]

        public void TestMethodDataRow(int[] addendi, int expected)
        {
            Calcolatrice sum = new Calcolatrice();

            int result = sum.Somma(addendi);

            Assert.AreEqual(expected, result);

        }
        /*public void TestSommaNull()
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

            Assert.IsNotNull(expected);*/
        }
    }
}
