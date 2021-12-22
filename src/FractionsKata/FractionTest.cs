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
        
        //4/5 / 6/2 = 8/30
        [TestMethod]
        public void FourFifthsDividedBySixthTwosEqualsEightThrirtiets()
        {
            //arrange
            var left = new Fraction(4, 5);
            var right = new Fraction(6, 2);
            
            //act
            var result = left.Divide(right);
            
            //assert
            Assert.AreEqual(8, result.numerator);
            Assert.AreEqual(30, result.denominator);
        }
        
        //2 + 1 = 3
        [TestMethod]
        public void TwoPlusOneEqualsThree()
        {
            //arrange
            var left = new Fraction(2);
            var right = new Fraction(1);
            //act
            var result = left.Plus(right).numerator;
            //assert
            Assert.AreEqual(3, result);
        }
        
        //1/2 + 1/3 = 5/6
        [TestMethod]
        public void OneTwosPlusOneThreesEqualsFiveSixs()
        {
            //arrange
            var left = new Fraction(1,2);
            var right = new Fraction(1, 3);
            //act
            var result = left.Plus(right);
            //assert
            Assert.AreEqual(5, result.numerator);
            Assert.AreEqual(6, result.denominator);
        }
        
        //2 - 1 = 1
        [TestMethod]
        public void TwoMinusOneEqualsOne()
        {
            //arrange
            var left = new Fraction(2);
            var right = new Fraction(1);
            //act
            var result = left.Minus(right).numerator;
            //assert
            Assert.AreEqual(1,result);
        }
        
        //1/2 - 1/3 = 1/6
        [TestMethod]
        public void OneTwosMinusOneThreesEqualsOneSixts()
        {
            //arrange
            var left = new Fraction(1, 2);
            var right = new Fraction(1, 3);
            //act
            var result = left.Minus(right);
            //assert
            Assert.AreEqual(1, result.numerator);
            Assert.AreEqual(6, result.denominator);

        }
        
        //1/2 <=> 1/2
        [TestMethod]
        public void OneTwosEqualsOneTwos()
        {
            //arrange
            var left = new Fraction(1, 2);
            var right = new Fraction(1, 2);
            
            //act
            var equalsResult = left.ExactEquals(right);
            //assert
            Assert.IsTrue(equalsResult);
        }
        
        // 2/4 => 1/2
        [TestMethod]
        public void TwoFoursSimplifiedToOneTwos()
        {
            //arrange
            var fraction = new Fraction(2, 4);
            //act
            var result = fraction.Simplify();
            //assert
            Assert.AreEqual(1,result.numerator);
            Assert.AreEqual(2,result.denominator);
        }
        
        // 30/60 => 1/2
        [TestMethod]
        public void ThirtySixtysSimplifiedToOneTwos()
        {
            //arrange
            var fraction = new Fraction(30, 60);
            //act
            var result = fraction.Simplify();
            //assert
            Assert.AreEqual(1,result.numerator);
            Assert.AreEqual(2,result.denominator);
        }

        // 30/60 <=> 1/2
        [TestMethod]
        public void ThirtySixtyEqualsOneTwos()
        {
            //arrange
            var left = new Fraction(30, 60);
            var right = new Fraction(1, 2);
            //act
            var result = left.SimplifyEquals(right);
            //assert
            Assert.IsTrue(result);
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

        //Times
        public Fraction Times(Fraction right)
        {
            return new Fraction(this.numerator * right.numerator, this.denominator * right.denominator);
        }
        
        //Divide
        public Fraction Divide(Fraction right)
        {
            return new Fraction(this.numerator * right.denominator, this.denominator * right.numerator);
        }
        
        
        //Add
        public Fraction Plus(Fraction right)
        {
            return new Fraction((this.numerator * right.denominator) + (right.numerator * this.denominator),this.denominator*right.denominator);
        }
        
        //Substract
        public Fraction Minus(Fraction right)
        {
            return new Fraction((this.numerator * right.denominator) - (right.numerator * this.denominator),this.denominator*right.denominator);
        }
        
        //Equals
        public bool ExactEquals(Fraction right)
        {
            return this.numerator == right.numerator && this.denominator == right.denominator;
        }

        public bool SimplifyEquals(Fraction right)
        {
            return this.Simplify().ExactEquals(right);
        }

        //Simplify
        public Fraction Simplify()
        {
            var divisor = 0;
            for (var i = this.numerator; i >= 1; i--)
            {
                if (this.numerator % i == 0 && this.denominator % i == 0)
                {
                    divisor = i;
                    break;
                }
            }

            return new Fraction(this.numerator/divisor, this.denominator/divisor);
        }
    }
}
