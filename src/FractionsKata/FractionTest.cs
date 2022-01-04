namespace FractionsKata
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NuGet.Frameworks;

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
            Assert.AreEqual(2, result.numerator);
        }

        [TestMethod]
        public void OneThirdTimesFiveEqualsFiveThirds()
        {
            //arrange
            var left = new Fraction(1, 3);

            //act
            var result = left.Multiply(new Fraction(5));

            //assert
            Assert.AreEqual(5, result.numerator);
            Assert.AreEqual(3, result.denominator);
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
            Assert.AreEqual(8, result.numerator);
            Assert.AreEqual(30, result.denominator);
        }

        // 2 / 1 = 2
        [TestMethod]
        public void TwoDividedByOneIsOne()
        {
            var left = new Fraction(2);
            var right = new Fraction(1);

            var result = left.Divide(right);

            Assert.AreEqual(2, result.numerator);
            Assert.AreEqual(1, result.denominator);
        }

        // 1/3 / 1/5 = 5/3
        [TestMethod]
        public void OneThirdDividedByOneFifthIsFiveThirds()
        {
            var left = new Fraction(1, 3);
            var right = new Fraction(1, 5);

            var result = left.Divide(right);

            Assert.AreEqual(5, result.numerator);
            Assert.AreEqual(3, result.denominator);
        }

        // 1/5 / 1/3 = 3/5
        [TestMethod]
        public void OneFifthDividedByOneThirdIsThreeFifths()
        {
            var left = new Fraction(1, 5);
            var right = new Fraction(1, 3);

            var result = left.Divide(right);

            Assert.AreEqual(3, result.numerator);
            Assert.AreEqual(5, result.denominator);
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

        public Fraction Multiply(Fraction right)
        {
            return new Fraction(this.numerator * right.numerator, this.denominator * right.denominator);
        }

        public Fraction Divide(Fraction other)
        {
            return new Fraction(this.numerator * other.denominator, this.denominator * other.numerator);
        }

        public override bool Equals(object obj)
        {
            if (obj is Fraction other)
            {
                return this.numerator * other.denominator == other.numerator * this.denominator;
            }
            
            return false;
        }

        public override string ToString()
        {
            if (this.numerator == 0)
            {
                return "0";
            }

            if (this.denominator == 1) return this.numerator.ToString();
            
            string sign = this.numerator * this.denominator < 0 ? "-" : "";
            return $"{sign}{Math.Abs(this.numerator)}/{Math.Abs(this.denominator)}";
        }
        
        //Divide
        //Add
        //Substract
        //Equals
    }
}
