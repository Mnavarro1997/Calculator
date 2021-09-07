using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calcu.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            var s = Suma.Sum(1,2);
            Assert.AreEqual(s, 3);
        }

        [TestMethod]
        public void TestSumaFail()
        {
            var s = Suma.Sum(-1, 2);
            Assert.AreEqual( 5, s);
        }
        [TestMethod]
        public void TestResta()
        {
            var r = Resto.Rest(-8, 2);
            Assert.AreEqual(-10, r);
        }
        [TestMethod]
        public void TestRestaFail()
        {
            var r = Suma.Sum(-7, -5);
            Assert.AreEqual(-1, r);
        }
        [TestMethod]
        public void TestMulti()
        {
            var r = Multiplicacion.Mult(3, 3);
            Assert.AreEqual(9, r);
        }
        public void TestMultiFail()
        {
            var r = Multiplicacion.Mult(3, 3);
            Assert.AreEqual(5, r);
        }

    }
}
