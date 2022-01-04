namespace FractionsKata
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FractionTest
    {
        [TestMethod]
        public void OneTimesTwoEqualTwo()
        {
            //arrange
            var fraction = new Fraction(1);

            //act
            var result = fraction.Multiply(new Fraction(2));

            //assert
            Assert.AreEqual(new Fraction(2), result);
        }

        [TestMethod]
        public void OneThirdTimesFiveEqualsFiveThirds()
        {
            //arrange
            var left = new Fraction(1, 3);

            //act
            var result = left.Multiply(new Fraction(5));

            //assert
            Assert.AreEqual(new Fraction(5, 3), result);
        }

        [TestMethod]
        public void FourFifthsTimesTwoSixthsEqualsEightThrirtiets()
        {
            //arrange
            var left = new Fraction(4, 5);
            var right = new Fraction(2, 6);

            //act
            var result = left.Multiply(right);

            //assert
            Assert.AreEqual(new Fraction(8, 30), result);
        }

        // 2 / 1 = 2
        [TestMethod]
        public void TwoDividedByOneIsOne()
        {
            var left = new Fraction(2);
            var right = new Fraction(1);

            var result = left.Divide(right);

            Assert.AreEqual(new Fraction(2, 1), result);
        }

        // 1/3 / 1/5 = 5/3
        [TestMethod]
        public void OneThirdDividedByOneFifthIsFiveThirds()
        {
            var left = new Fraction(1, 3);
            var right = new Fraction(1, 5);

            var result = left.Divide(right);

            Assert.AreEqual(new Fraction(5, 3), result);
        }

        // 1/5 / 1/3 = 3/5
        [TestMethod]
        public void OneFifthDividedByOneThirdIsThreeFifths()
        {
            var left = new Fraction(1, 5);
            var right = new Fraction(1, 3);

            var result = left.Divide(right);

            Assert.AreEqual(new Fraction(3, 5), result);
        }
        
        // 1 -> "1"
        [TestMethod]
        public void ToStringOne()
        {
            Assert.AreEqual("1", new Fraction(1).ToString());    
        }
        
        // 2/1 -> "2"
        [TestMethod]
        public void ToStringTwoWholes()
        {
            Assert.AreEqual("2", new Fraction(2).ToString());
        }
        
        // 7/8 -> "7/8"
        [TestMethod]
        public void ToStringSevenEights()
        {
            Assert.AreEqual("7/8", new Fraction(7, 8).ToString());
        }
        
        // -2/3 -> "-2/3"
        [TestMethod]
        public void ToStringNegativeNumerator()
        {
            Assert.AreEqual("-2/3", new Fraction(-2, 3).ToString());
        }
        
        // 2/-3 -> "-2/3"
        [TestMethod]
        public void ToStringNegativeDenominator()
        {
            Assert.AreEqual("-2/3", new Fraction(2, -3).ToString());
        }
        
        // -5/-7 -> "5/7"
        [TestMethod]
        public void ToStringBothNumeratorAndDenominatorNegative()
        {
            Assert.AreEqual("5/7", new Fraction(-5, -7).ToString());
        }
        
        //0/5 -> "0"
        [TestMethod]
        public void ToStringZeroNumeratorPositiveDenominator()
        {
            Assert.AreEqual("0", new Fraction(0, 5).ToString());
        }
        
        // 0/-3 -> "0"
        [TestMethod]
        public void ToStringZeroNumeratorNegativeDenominator()
        {
            Assert.AreEqual("0", new Fraction(0, -3).ToString());
        }

        [TestMethod]
        public void FractionIsNotEqualToString()
        {
            Assert.AreNotEqual(new Fraction(1), "1", "Fraction(1) should not have been equal to string \"1\"");
        }
        
        //1 == 1
        [TestMethod]
        public void OneEqualsOne()
        {
            Assert.AreEqual(new Fraction(1), new Fraction(1));
        }
        
        // 2/1 == 2
        [TestMethod]
        public void TwoWholesEqualTwo()
        {
            Assert.AreEqual(new Fraction(2, 1), new Fraction(2));
        }
        
        // 7/3 == 7/3
        [TestMethod]
        public void SevenThirdsEqualsSevenThirds()
        {
            Assert.AreEqual(new Fraction(7, 3), new Fraction(7, 3));
        }
        
        // 7/3 != 7/5
        [TestMethod]
        public void SevenThirdsIsNotEqualToSevenFifths()
        {
            Assert.AreNotEqual(new Fraction(7, 3), new Fraction(7, 5));
        }
        
        // 1 != 2
        [TestMethod]
        public void OneIsNotEqualTwo()
        {
            Assert.AreNotEqual(new Fraction(1), new Fraction(2));
        }
        
        // 2/4 == 1/2
        [TestMethod]
        public void TwoQuartersEqualsOneHalf()
        {
            Assert.AreEqual(new Fraction(2, 4), new Fraction(1, 2));
        }
        
        // 3/15 == 1/5
        [TestMethod]
        public void ThreeFiftheensEqualsOneFifth()
        {
            Assert.AreEqual(new Fraction(3, 15), new Fraction(1, 5));
        }
        
        // 12/9 == 4/3
        [TestMethod]
        public void TwelveNightsEqualsFourThirds()
        {
            Assert.AreEqual(new Fraction(12, 9), new Fraction(4, 3));
        }
        
        // 1 == 1
        // 2/1 == 2
        // 2/4 == 1/2
        // 1 != 2
        [TestMethod]
        public void GetHashCodeTests()
        {
            Assert.AreEqual(new Fraction(1).GetHashCode(), new Fraction(1).GetHashCode());
            Assert.AreEqual(new Fraction(2, 1).GetHashCode(), new Fraction(2).GetHashCode());
            Assert.AreEqual(new Fraction(1, 2).GetHashCode(), new Fraction(1, 2).GetHashCode());
            Assert.AreNotEqual(new Fraction(1, 2).GetHashCode(), new Fraction(1, 3).GetHashCode());
            Assert.AreEqual(new Fraction(2, 4).GetHashCode(), new Fraction(1, 2).GetHashCode());
            Assert.AreNotEqual(new Fraction(1).GetHashCode(), new Fraction(2).GetHashCode());
        }
        
        
        // 1/1 + 1/1 = 2/1
        [TestMethod]
        public void OnePlusOneEqualsTwo()
        {
            var left = new Fraction(1);
            var right = new Fraction(1);

            var result = left.Add(right);
            
            Assert.AreEqual(new Fraction(2), result);
        }
        
        //1/3 + 1/3 == 2/3
        [TestMethod]
        public void OneThirdPlusOneThirdsEqualsTwoThirds()
        {
            var left = new Fraction(1, 3);
            var right = new Fraction(1, 3);

            var result = left.Add(right);
            
            Assert.AreEqual(new Fraction(2, 3), result);
        }

        // 1/5 + 1/2 = 7/10
        [TestMethod]
        public void OneFifthPlusOneHalfEqualsOneTenth()
        {
            var left = new Fraction(1, 5);
            var right = new Fraction(1, 2);

            var result = left.Add(right);
            
            Assert.AreEqual(new Fraction(7, 10), result);
        }
        
        
        // 5 - 2 = 3
        [TestMethod]
        public void FiveMinusTwoEqualsThree()
        {
            var left = new Fraction(5);
            var right = new Fraction(2);

            var result = left.Subtract(right);
            
            Assert.AreEqual(new Fraction(3), result);
        }
        
        // 4/5 - 1/5 = 3/5
        [TestMethod]
        public void FourFifthsMinusOneFifthEqualsThreeFifths()
        {
            var left = new Fraction(4, 5);
            var right = new Fraction(1, 5);

            var result = left.Subtract(right);
            
            Assert.AreEqual(new Fraction(3, 5), result);
        }
        
        // 1/2 - 1/5 = 3/10
        [TestMethod]
        public void OneHalfMinusOneFifthEqualsThreeTenths()
        {
            var left = new Fraction(1, 2);
            var right = new Fraction(1, 5);

            var result = left.Subtract(right);
            
            Assert.AreEqual(new Fraction(3, 10), result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ZeroDenominatorThrowsException()
        {
            new Fraction(1, 0);
        }
    }
}
