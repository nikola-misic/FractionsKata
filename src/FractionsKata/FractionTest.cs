namespace FractionsKata
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FractionTest
    {
        [TestMethod]
        public void OneTimesTwoEqualTwo()
        {
            //1 * 2 == 2
            
            //arrange
            var fraction = new Fraction(1);
            
            //act
            var result = fraction.Times(new Fraction(2));
            
            //assert
            Assert.AreEqual(2, result.numerator);
        }

        [TestMethod]
        public void OneThirdTimesFiveEqualsFiveThirds()
        {
            //1/3 * 5 = 5/3
            
            //arrange
            var left = new Fraction(1, 3);

            //act
            var result = left.Times(new Fraction(5));
            
            //assert
            Assert.AreEqual(5, result.numerator);
            Assert.AreEqual(3, result.denominator);
        }
        
        //4/5 * 2/6 = 8/30
        [TestMethod]
        public void FourFifthsTimesTwoSixthsEqualsEightThrirtiets()
        {
            //arrange
            var left = new Fraction(4, 5);
            var right = new Fraction(2, 6);
            
            //act
            var result = left.Times(right);
            
            //assert
            Assert.AreEqual(8, result.numerator);
            Assert.AreEqual(30, result.denominator);
        }
    }

    public class Fraction
    {
        public int numerator;
        public int denominator;
        
        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }
        
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction Times(Fraction right)
        {
            return new Fraction(this.numerator * right.numerator, this.denominator * right.denominator);
        }
        
        //Divide
        //Add
        //Substract
        //Equals
    }
}
