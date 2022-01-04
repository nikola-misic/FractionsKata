namespace FractionsKata
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MathUtilTests
    {
        [TestMethod]
        public void GcdTest()
        {
            Assert.AreEqual(1, MathUtil.Gcd(1,1));
            Assert.AreEqual(1, MathUtil.Gcd(5,1));
            Assert.AreEqual(2, MathUtil.Gcd(2,4));
            Assert.AreEqual(3, MathUtil.Gcd(3,15));
            Assert.AreEqual(3, MathUtil.Gcd(12,9));
            Assert.AreEqual(15, MathUtil.Gcd(2 * 3 * 5 * 7, 11 * 3 * 17 * 19 * 5));
        }
    }
}
