using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcolatriceLybrary;

namespace TestCalcolatrice
{
    [TestClass]
    public class UnitTest1olatrice
    {
        [TestMethod]
        public void TestSomma()
        {
            int add1 = 2;
            int add2 = 3;
            int epected = 5;

            var calc = new Calcolatrice();
            int result = calc.Somma(add1, add2);

            Assert.AreEqual(epected, result);
        }
    }
}
