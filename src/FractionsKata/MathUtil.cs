namespace FractionsKata
{
    public static class MathUtil
    {
        public static int Gcd(int a, int b)
        {
            while ((a % b) > 0)  {
                var r = a % b;
                a = b;
                b = r;
            }
            return b;
        }
    }
}
