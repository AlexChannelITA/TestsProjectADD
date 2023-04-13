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
            int add3 = 4;
            int epected = 9;

            var calc = new Calcolatrice();
            int result = calc.Somma(add1, add2, add3);

            Assert.AreEqual(epected, result);
        }
    }
}
