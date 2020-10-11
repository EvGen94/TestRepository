using System;
namespace MathCalculatorTests 
{
    public class MathCalculator
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}