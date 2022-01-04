namespace FractionsKata
{
    using System;

    public class Fraction
    {
        private readonly int numerator;
        private readonly int denominator;
        
        public Fraction(int numerator)
        {
            this.numerator = numerator;
            this.denominator = 1;
        }
        
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero");
            }

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

        public override int GetHashCode()
        {
            int gcd = MathUtil.Gcd(this.numerator, this.denominator);
            return (this.numerator / gcd, this.denominator / gcd).GetHashCode();
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
        
        public Fraction Add(Fraction other)
        {
            return new Fraction(this.numerator*other.denominator + this.denominator*other.numerator, this.denominator * other.denominator);
        }

        public Fraction Subtract(Fraction other)
        {
            return new Fraction(this.numerator*other.denominator - other.numerator * this.denominator, this.denominator * other.denominator);
        }
    }
}
