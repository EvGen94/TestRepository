namespace MathCalculatorTests 
{
    public class MathCalculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Sum(string a, string b)
        {
            int p = int.Parse(a);
            int q = int.Parse(b);
            return p + q;
        }
    }
}