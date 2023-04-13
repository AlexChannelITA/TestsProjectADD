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
            int[] addendi = { 2, 3, 4 };
            int epected = 9;

            var calc = new Calcolatrice();
            int result = calc.Somma(addendi);

            Assert.AreEqual(epected, result);
        }
    }
}
