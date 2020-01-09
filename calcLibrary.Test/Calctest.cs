using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLibrary.Test
{
    [TestClass]
    public class Calctest
    {
        [TestMethod]
        public void testRadQ()
        {
            double num = 4;
            double rad = 2;
            double ris = Calc.RadQ(num);
            Assert.AreEqual(ris, rad);
        }
    }
}
